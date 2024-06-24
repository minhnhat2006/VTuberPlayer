using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class SubNotify : AMessageData
    {
        public readonly Objects.User User;

        internal SubNotify(WebcastSubNotifyMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            if (msg?.Sender != null)
                User = new Objects.User(msg.Sender);
        }
    }
}
