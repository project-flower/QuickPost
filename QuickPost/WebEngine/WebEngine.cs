using QuickPost.Common;
using QuickPost.Exceptions;
using QuickPost.Models;
using QuickPost.PInvokes;
using System;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json.Nodes;

namespace QuickPost
{
    public class WebEngine
    {
        #region Public Fields
        #endregion

        #region Private Fields

        private static readonly CancellationToken cancellationToken = new();
        private static string chatPostMessageEndpoint = string.Empty;
        private static string credTokenPrefix = string.Empty;
        private static string credWebhookPrefix = string.Empty;
        private static readonly HttpClient httpClient = new();

        #endregion

        #region Static Methods

        static WebEngine()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            }
            catch
            {
            }
        }

        #endregion

        #region Public Methods

        public static void Initialize(string chatPostMessageEndpoint, string credTokenPrefix, string credWebhookPrefix)
        {
            WebEngine.chatPostMessageEndpoint = chatPostMessageEndpoint;
            WebEngine.credTokenPrefix = credTokenPrefix;
            WebEngine.credWebhookPrefix = credWebhookPrefix;
        }

        public static void Post(PostItem postItem)
        {
            if (postItem is ChatPostMessage chatPostMessage)
            {
                PostChatPostMessage(chatPostMessage);
            }
            else if (postItem is IncomingWebhook incomingWebhook)
            {
                PostIncomingWebhook(incomingWebhook);
            }
        }

        #endregion

        #region Private Methods

        private static void AnalyzeResponse(string body)
        {
            if (string.Compare(body, "ok", true) == 0) return;

            var json = JsonNode.Parse(body);
            string error;

            try
            {
                if (json!["ok"]!.ToString() == "true") return;

                error = json!["error"]!.ToString();
            }
            catch
            {
                throw new HttpFailedResponseException("HTTP レスポンスが検証できません。");
            }

            throw new HttpFailedResponseException(error);
        }

        private static void Post(string endPoint, HttpContent content)
        {
            Task<HttpResponseMessage> task = httpClient.PostAsync(endPoint, content, cancellationToken);
            Exception? exception = task.Exception;

            if (exception != null)
            {
                throw exception;
            }

            HttpResponseMessage response = task.Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpProtocolException((long)response.StatusCode, response.ReasonPhrase, null);
            }

            Task<string> read = response.Content.ReadAsStringAsync();
            exception = read.Exception;

            if (exception != null)
            {
                throw exception;
            }

            AnalyzeResponse(read.Result);
        }

        private static void PostChatPostMessage(ChatPostMessage message)
        {
            Credential credential;

            try
            {
                credential = CredentialManager.Read($"{credTokenPrefix}{message.TokenName}");
                Dictionary<string, string> attachment = new() {
                    { "token", credential.Password }
                    , { "channel", message.Channel }
                    , { "text", message.Text }};
                PostUrlEncoded(chatPostMessageEndpoint, attachment);
            }
            catch
            {
                throw;
            }
        }

        private static void PostIncomingWebhook(IncomingWebhook webhook)
        {
            Credential credential;

            try
            {
                credential = CredentialManager.Read($"{credWebhookPrefix}{webhook.EndpointName}");
                PostJson(credential.Password, webhook.Payload);
            }
            catch
            {
                throw;
            }
        }

        private static void PostJson(string endPoint, string body)
        {
            try
            {
                Post(endPoint, new StringContent(body, Encoding.UTF8, "application/json"));
            }
            catch
            {
                throw;
            }
        }

        private static void PostUrlEncoded(string endPoint, IEnumerable<KeyValuePair<string, string>> body)
        {
            Post(endPoint, new FormUrlEncodedContent(body));
        }

        #endregion
    }
}
