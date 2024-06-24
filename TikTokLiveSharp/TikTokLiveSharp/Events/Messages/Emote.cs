using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class Emote : AMessageData
    {
        public readonly Objects.User User;

        public readonly string EmoteId;

        public readonly Objects.Picture Picture;

        internal Emote(WebcastEmoteChatMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            if (msg?.Sender != null)
                User = new Objects.User(msg.Sender);
            EmoteId = msg?.Details?.Id;
            Picture = new Objects.Picture(new List<string> { msg?.Details?.Image?.Url });
        }
    }
}
