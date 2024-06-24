using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class LikeData : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Type { get; set; } = "";

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Label { get; set; } = "";

        [ProtoMember(3)]
        public TikTokColor Color { get; set; }

        [ProtoMember(4)]
        public LikeUserContainer User { get; set; }
    }

    [ProtoContract]
    public partial class LikeUserContainer : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Data1 { get; set; }

        [ProtoMember(21)]
        public UserContainer User;
    }
}
