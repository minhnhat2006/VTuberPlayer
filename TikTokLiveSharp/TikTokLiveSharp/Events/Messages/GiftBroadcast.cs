using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class GiftBroadcast : AMessageData
    {
        public readonly Objects.Picture Picture;

        public readonly string ShortURL;

        public readonly string NotifyEventType;
        public readonly string NotifyLabel;
        public readonly string NotifyType;

        internal GiftBroadcast(WebcastGiftBroadcastMessage msg) : 
            base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            Picture = new Objects.Picture(msg?.Picture);
            var data = msg?.Data;
            ShortURL = data?.uri;
            NotifyEventType = data?.RoomNotifyMessage?.Data?.Type;
            NotifyLabel = data?.RoomNotifyMessage?.Data?.Label;
            NotifyType = data?.NotifyType;
        }
    }
}
