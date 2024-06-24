using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.MessageData.Objects
{
    public sealed class LinkMicArmy
    {
        public sealed class Army
        {
            public readonly IReadOnlyList<User> Users;
            public readonly uint Points;
            public Army(List<User> users, uint points)
            {
                Users = users;
                Points = points;
            }
        }

        public readonly ulong ArmyId;
        public readonly List<Army> Armies;

        public LinkMicArmy(ulong armyId, List<Army> armies)
        {
            ArmyId = armyId;
            Armies = armies;
        }

        internal LinkMicArmy(Models.Protobuf.Objects.LinkMicArmiesItems army)
        {
            ArmyId = army?.HostUserId ?? 0;
            Armies = army?.BattleGroups?.Select(g => new Army(g?.Users?.Select(u => 
            {
                if (u != null)
                    return new User(u);
                return null;
            }).ToList(), g?.Points ?? 0)).ToList();
        }
    }
}