using ProtoBuf;
using System.Collections.Generic;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LinkMicArmiesItems : AProtoBase
    {
        [ProtoMember(1)]
        public ulong HostUserId { get; set; }

        [ProtoMember(2)]
        public List<LinkMicArmiesGroup> BattleGroups { get; set; } = new List<LinkMicArmiesGroup>();
    }

    [ProtoContract]
    public partial class LinkMicArmiesGroup : AProtoBase
    {
        [ProtoMember(1)]
        public List<User> Users { get; set; } = new List<User>();

        [ProtoMember(2)]
        public uint Points { get; set; }
    }
}
