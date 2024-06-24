using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class IMDelete : AMessageData
    {
        public readonly string Data1;
        public readonly string Data2;

        internal IMDelete(WebcastImDeleteMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            Data1 = msg?.Data1;
            Data2 = msg?.Data2;
        }
    }
}
