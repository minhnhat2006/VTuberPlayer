using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class Follow : AMessageData
    {
        /// <summary>
        /// CAN BE NULL!
        /// </summary>
        public readonly Objects.User NewFollower;
        public readonly ulong TotalFollowers;

        internal Follow(WebcastSocialMessage msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            if (msg?.Sender != null)
                NewFollower = new Objects.User(msg.Sender);
            TotalFollowers = msg?.TotalFollowers ?? 0;
        }
    }
}
