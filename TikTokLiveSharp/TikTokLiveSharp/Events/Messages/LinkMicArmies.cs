using System.Collections.Generic;
using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class LinkMicArmies : AMessageData
    {
        /// <summary>
        /// UNCONFIRMED. Could be another type of Id
        /// </summary>
        public readonly ulong BattleId;

        public readonly int BattleStatus;

        public readonly Objects.Picture Picture;

        public readonly IReadOnlyList<Objects.LinkMicArmy> Armies;

        internal LinkMicArmies(WebcastLinkMicArmies msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            BattleId = msg?.Id ?? 0;
            Armies = msg?.BattleItems?.Select(a => new Objects.LinkMicArmy(a))?.ToList();
            Picture = new Objects.Picture(msg?.Picture);
            BattleStatus = msg?.BattleStatus ?? 0;
        }
    }
}
