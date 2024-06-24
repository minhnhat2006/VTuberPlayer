using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GoalUpdateData : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Id { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(3)]
        public uint Data2 { get; set; }

        [ProtoMember(4)]
        public GoalUpdateDetails Details { get; set; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Label { get; set; } = "";

        [ProtoMember(6)]
        public uint Data3 { get; set; }

        [ProtoMember(7)]
        public uint Data4 { get; set; }

        [ProtoMember(8)]
        public ulong Timestamp { get; set; }

        [ProtoMember(9)]
        public ulong Timestamp2 { get; set; }

        [ProtoMember(11)]
        public List<GoalUpdateUser> Users { get; set; } = new List<GoalUpdateUser>();

        [ProtoMember(12)]
        public uint Data5 { get; set; }

        [ProtoMember(13)]
        [DefaultValue("")]
        public string IdString { get; set; } = "";

        /// <summary>
        /// Same value as Label?
        /// </summary>
        [ProtoMember(14)]
        [DefaultValue("")]
        public string Label2 { get; set; }
    }

    [ProtoContract]
    public partial class GoalUpdateDetails : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public uint Data2 { get; set; }

        [ProtoMember(3)]
        public uint Data3 { get; set; }

        [ProtoMember(4)]
        public uint Data4 { get; set; }

        [ProtoMember(5)]
        public GoalUpdateGiftData Data5 { get; set; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string Data6 { get; set; } = "";
    }

    [ProtoContract]
    public partial class GoalUpdateGiftData : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Name { get; set; } = "";

        [ProtoMember(2)]
        public Picture Picture { get; set; }

        [ProtoMember(3)]
        public uint Data1 { get; set; }

        [ProtoMember(4)]
        public uint Data2 { get; set; }
    }
}
