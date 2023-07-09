using QuickPost.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace QuickPost
{
    public static class WebEngine
    {
        #region Public Fields

        public static string CredName { get; private set; } = string.Empty;
        public static string EndPoint { get; private set; } = string.Empty;

        #endregion

        #region Private Fields

        private static readonly CancellationToken cancellationToken = new();
        private static readonly HttpClient httpClient = new();

        #endregion

        #region Static Methods

        static WebEngine()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
            }
            catch
            {
            }
        }

        #endregion

        #region Public Methods

        public static void Initialize(string endPoint, string credName)
        {
            CredName = credName;
            EndPoint = endPoint;
        }

        public static void Post(PostItem postItem)
        {
            string token = "";

            var nameValueCollection = new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("token", token),
                new KeyValuePair<string, string>("channel", postItem.Channel),
                new KeyValuePair<string, string>("text", postItem.Message)
            };

            var content = new FormUrlEncodedContent(nameValueCollection);
            Task<HttpResponseMessage> task = httpClient.PostAsync(EndPoint, content, cancellationToken);
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
        }

        #endregion
    }
}
