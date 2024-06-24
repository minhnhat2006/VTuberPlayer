using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class Subscribe : AMessageData
    {
        public readonly Objects.User NewSubscriber;

        internal Subscribe(WebcastMemberMessage msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            if (msg?.Sender != null)
                NewSubscriber = new Objects.User(msg.Sender);
        }
    }
}
