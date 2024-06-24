using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class LinkMicBattle : AMessageData
    {
        public readonly IReadOnlyList<Objects.LinkMicBattleTeam> Team1;
        public readonly IReadOnlyList<Objects.LinkMicBattleTeam> Team2;
        /// <summary>
        /// UNCONFIRMED. Could be another type of Id
        /// </summary>
        public readonly ulong BattleId;

        internal LinkMicBattle(Models.Protobuf.Messages.WebcastLinkMicBattle msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            BattleId = msg?.Id ?? 0;
            Team1 = msg?.Teams1?.Select(t => new Objects.LinkMicBattleTeam(t))?.ToList();
            Team2 = msg?.Teams2?.Select(t => new Objects.LinkMicBattleTeam(t))?.ToList();
        }
    }
}
