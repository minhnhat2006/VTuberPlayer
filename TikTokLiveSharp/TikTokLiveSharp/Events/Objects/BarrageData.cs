using System.Collections.Generic;

namespace TikTokLiveSharp.Events.MessageData.Objects
{
    public sealed class BarrageData
    {
        public readonly string EventType;
        public readonly string Label;
        public IReadOnlyList<(User, string)> Users;

        public BarrageData(string eventType, string label, List<(User, string)> list)
        {
            EventType = eventType;
            Label = label;
            Users = list;
        }
    }
}
