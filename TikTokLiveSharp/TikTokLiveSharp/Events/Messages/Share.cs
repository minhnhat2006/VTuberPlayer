using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class Share : AMessageData
    {
        /// <summary>
        /// CAN BE NULL!
        /// </summary>
        public readonly Objects.User User;
        public readonly uint Amount;

        public Share(WebcastSocialMessage msg, int amount)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            if (msg?.Sender != null)
                User = new Objects.User(msg.Sender);
            Amount = (uint)amount;
        }

        internal Share(WebcastSocialMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            if (msg?.Sender != null)
                User = new Objects.User(msg.Sender);
            Amount = 1u;
        }
    }
}
