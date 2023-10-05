namespace QuickPost.Exceptions
{
    public class HttpFailedResponseException : Exception
    {
        #region Public Methods

        public HttpFailedResponseException(string message)
            : base(message)
        {
        }

        #endregion
    }
}
