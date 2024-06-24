using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class PollMessage : AMessageData
    {
        public readonly ulong Id;

        public readonly Objects.PollOption Option1;

        public readonly Objects.PollOption Option2;

        public readonly List<Objects.PollOption.Option> Options;

        internal PollMessage(WebcastPollMessage msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            Id = msg?.Id ?? 0;
            Option1 = new Objects.PollOption(msg?.Options1?.User == null ? null : new Objects.User(msg.Options1.User), msg.Options1.Options.Select(o => new Objects.PollOption.Option(o.Label, o.CurrentTotal))?.ToList());
            Option2 = new Objects.PollOption(msg?.Options2?.User == null ? null : new Objects.User(msg.Options2.User), msg.Options2.Options.Select(o => new Objects.PollOption.Option(o.Label, o.CurrentTotal))?.ToList());
            Options = msg?.PollData?.Options?.Select(o => new Objects.PollOption.Option(o.Label, o.CurrentTotal))?.ToList();
        }
    }
}
