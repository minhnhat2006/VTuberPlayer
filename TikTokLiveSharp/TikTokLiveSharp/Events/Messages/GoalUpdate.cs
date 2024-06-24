using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class GoalUpdate : AMessageData
    {
        /// <summary>
        /// UNCONFIRMED
        /// </summary>
        public readonly ulong GoalId;

        public readonly Objects.Picture Picture;

        public readonly string EventType;
        public readonly string Label;

        public readonly IReadOnlyList<Objects.User> Users;

        internal GoalUpdate(WebcastGoalUpdateMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            Picture = new Objects.Picture(msg?.Picture);
            GoalId = msg?.Id ?? 0;
            EventType = msg?.Data?.Type;
            Label = msg?.UpdateData?.Label;
            Users = msg?.UpdateData?.Users?.Select(u => new Objects.User(u.Id, null, u.Nickname, null, new Objects.Picture(u.ProfilePicture), null, null, null, 0, 0, 0, null))?.ToList();
        }
    }
}
