using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public class RankText : AMessageData
    {
        public readonly string EventType;

        public readonly string Label;

        internal RankText(WebcastRankTextMessage msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            EventType = msg?.Details?.Type;
            Label = msg?.Details?.Label;
        }
    }
}
