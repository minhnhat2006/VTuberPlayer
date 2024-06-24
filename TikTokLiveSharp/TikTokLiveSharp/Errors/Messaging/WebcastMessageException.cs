using System;

namespace TikTokLiveSharp.Errors.Messaging
{
    /// <summary>
    /// Exception related to TikTok-Messaging (Parsing/Handling)
    /// </summary>
    public class WebcastMessageException : Exception
    {
        public WebcastMessageException(string message, Exception inner) : base(message, inner)
        { }
    }
}
