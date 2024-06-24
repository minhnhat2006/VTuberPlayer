using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class LinkLayerMessage : AMessageData
    {
        /// <summary>
        /// UNCONFIRMED
        /// </summary>
        public readonly ulong LinkId;

        public readonly (ulong, ulong) Link1;
        public readonly (ulong, ulong) Link2;

        internal LinkLayerMessage(WebcastLinkLayerMessage msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            LinkId = msg?.Id ?? 0;
            Link1 = (msg?.IdContainer1?.Ids?.Id1 ?? 0, msg?.IdContainer1?.Ids?.Id2 ?? 0);
            Link2 = (msg?.IdContainer2?.Ids?.Id1 ?? 0, msg?.IdContainer2?.Ids?.Id2 ?? 0);
        }
    }
}
