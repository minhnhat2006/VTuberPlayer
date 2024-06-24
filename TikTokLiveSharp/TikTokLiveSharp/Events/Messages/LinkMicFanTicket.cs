using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class LinkMicFanTicket : AMessageData
    {
        public readonly ulong Id;
        public readonly uint Data1;
        public readonly uint Data2;

        internal LinkMicFanTicket(WebcastLinkMicFanTicketMethod msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            Id = msg?.Data?.Details?.Id ?? 0;
            Data1 = msg?.Data?.Data1 ?? 0;
            Data2 = msg?.Data?.Details?.Data ?? 0;
        }
    }
}
