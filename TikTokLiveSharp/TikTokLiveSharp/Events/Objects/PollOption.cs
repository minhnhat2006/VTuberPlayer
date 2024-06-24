using System.Collections.Generic;

namespace TikTokLiveSharp.Events.MessageData.Objects
{
    public sealed class PollOption
    {
        public sealed class Option
        {
            public readonly string Label;
            public readonly uint Total;

            public Option(string label, uint total)
            {
                Label = label;
                Total = total;
            }
        }

        public readonly Objects.User User;
        public readonly IReadOnlyList<Option> Options;

        public PollOption(Objects.User user, IReadOnlyList<Option> options)
        {
            User = user;
            Options = options;
        }
    }
}