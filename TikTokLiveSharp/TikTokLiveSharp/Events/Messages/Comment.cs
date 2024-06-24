using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class Comment : AMessageData
    {
        public readonly Objects.User User;

        public readonly string Text;

        public readonly string Language;

        public readonly IReadOnlyList<Objects.User> MentionedUsers;

        public readonly IReadOnlyList<Objects.Picture> Pictures;

        internal Comment(RoomPinMessageData data) 
            : base(data?.Details?.RoomId ?? 0, data?.Details?.MessageId ?? 0, data?.Details?.ServerTime ?? 0)
        {
            if (data?.Sender != null)
                User = new Objects.User(data.Sender);
            Text = data?.Comment;
            Language = data?.Language;
        }

        internal Comment(WebcastChatMessage msg) : 
            base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            if (msg?.Sender != null)
                User = new Objects.User(msg?.Sender);
            Text = msg?.Comment;
            Language = msg?.Language;
            if (msg?.MentionedUsers != null && msg.MentionedUsers.Count > 0)
                MentionedUsers = new List<Objects.User>(msg.MentionedUsers.Select(u => u == null ? null : new Objects.User(u)));
            if (msg?.Images != null && msg.Images.Count > 0)
                Pictures = new List<Objects.Picture>(msg.Images.Select(p => new Objects.Picture(p.Picture)));
        }
    }
}
