using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GoalUpdateUser : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Id { get; set; }

        [ProtoMember(2)]
        public Picture ProfilePicture{ get; set; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Nickname { get; set; } = "";

        [ProtoMember(4)]
        public ulong Timestamp { get; set; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string IdString { get; set; } = "";

        [ProtoMember(6)]
        public uint Data1 { get; set; }

        [ProtoMember(7)]
        public uint Data2 { get; set; }

        [ProtoMember(10)]
        public GoalUpdateUserDetails Details { get; set; }
    }

    [ProtoContract]
    public partial class GoalUpdateUserDetails : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public uint Data2 { get; set; }

        [ProtoMember(3)]
        public uint Data3 { get; set; }

        [ProtoMember(10)]
        public GoalUserPictureContainer Links { get; set; }
    }

    [ProtoContract]
    public partial class GoalUserPictureContainer : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public Picture Links { get; set; }
    }
}
