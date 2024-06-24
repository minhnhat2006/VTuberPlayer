using System;
using TikTokLiveSharp.Client.Proxy;

namespace TikTokLiveSharp.Client
{
    /// <summary>
    /// Settings for TikTok-Client
    /// </summary>
    [Serializable]
    public struct ClientSettings
    {
        /// <summary>
        /// Timeout for Connections
        /// </summary>
#if UNITY
        [UnityEngine.Header("Settings")]
        [UnityEngine.Tooltip("Timeout for Connections")]
#endif
        public TimeSpan Timeout;
        /// <summary>
        /// Polling-Interval for Socket-Connection
        /// </summary
#if UNITY
        [UnityEngine.Tooltip("Polling-Interval for Socket-Connection")]
#endif
        public TimeSpan PollingInterval;
        /// <summary>
        /// Proxy for Connection
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Proxy for Connection")]
#endif
        public RotatingProxy Proxy;
        /// <summary>
        /// ISO-Language for Client
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("ISO-Language for Client")]
#endif
        public string ClientLanguage;
        /// <summary>
        /// Size for Buffer for Socket-Connection
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Size for Buffer for Socket-Connection")]
#endif
        public uint SocketBufferSize;

        /// <summary>
        /// Whether to Retry if Connection Fails
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Whether to Retry if Connection Fails")]
#endif
        public bool RetryOnConnectionFailure;

        #region Connecting
        /// <summary>
        /// Whether to handle Messages received from Room when Connecting
        /// </summary>
#if UNITY
        [UnityEngine.Header("OnConnect")]
        [UnityEngine.Tooltip("Whether to handle Messages received from Room when Connecting")]
#endif
        public bool HandleExistingMessagesOnConnect;
        /// <summary>
        /// Whether to download List of Gifts for Room when Connecting
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Whether to download List of Gifts for Room when Connecting")]
#endif
        public bool DownloadGiftInfo;
        #endregion

        #region Debug
        /// <summary>
        /// Whether to print Logs to Console
        /// </summary>
#if UNITY
        [UnityEngine.Header("Debug")]
        [UnityEngine.Tooltip("Whether to print Logs to Console")]
#endif
        public bool PrintToConsole;
        /// <summary>
        /// LoggingLevel for Logs
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("LoggingLevel for Logs")]
#endif
        public LogLevel LogLevel;

        /// <summary>
        /// Whether to print Base64-Data for Messages to Console
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Whether to print Base64-Data for Messages to Console")]
#endif
        public bool PrintMessageData;

        /// <summary>
        /// Whether to check Messages for Unparsed Data
        /// </summary>
#if UNITY
        [UnityEngine.Tooltip("Whether to check Messages for Unparsed Data")]
#endif
        public bool CheckForUnparsedData;
        #endregion
    }

    [Serializable]
    [Flags]
    public enum LogLevel
    {
        /// <summary>
        /// Log Nothing
        /// </summary>
        None = 0,
        /// <summary>
        /// Log Errors
        /// </summary>
        Error = 1,
        /// <summary>
        /// Log Warnings
        /// </summary>
        Warning = 2,
        /// <summary>
        /// Log Information
        /// </summary>
        Information = 4,
        /// <summary>
        /// Verbose Logging
        /// </summary>
        Verbose = 8
    }
}