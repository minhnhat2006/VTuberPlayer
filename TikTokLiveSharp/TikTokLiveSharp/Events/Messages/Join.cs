using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public class Join : AMessageData
    {
        public readonly Objects.User User;

        /// <summary>
        /// Can be 0 for SocialMessage
        /// </summary>
        public readonly ulong TotalViewers;

        internal Join(WebcastSocialMessage msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            if (msg?.Sender != null)
                User = new Objects.User(msg.Sender);
            TotalViewers = 0;
        }

        internal Join(WebcastMemberMessage msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            if (msg?.Sender != null)
                User = new Objects.User(msg.Sender);
            TotalViewers = msg?.TotalViewers ?? 0;
        }
    }
}
