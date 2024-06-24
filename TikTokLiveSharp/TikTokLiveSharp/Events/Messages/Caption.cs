using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class Caption : AMessageData
    {
        public readonly ulong CaptionTimeStamp;

        public readonly string ISOLanguage;

        public readonly string Text;

        internal Caption(WebcastCaptionMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            CaptionTimeStamp = msg?.Timestamp ?? 0;
            ISOLanguage = msg?.CaptionData?.ISOLanguage;
            Text = msg?.CaptionData?.Text;
        }
    }
}
