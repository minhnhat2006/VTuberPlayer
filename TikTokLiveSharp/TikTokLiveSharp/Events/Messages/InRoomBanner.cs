using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class InRoomBanner : AMessageData
    {
        public readonly string JSON;

        internal InRoomBanner(WebcastInRoomBannerMessage msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            JSON = msg?.Json;
        }
    }
}
