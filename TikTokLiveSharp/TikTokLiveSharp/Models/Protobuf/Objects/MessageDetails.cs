using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class MessageDetails : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public TikTokColor Color { get; set; }

        [ProtoMember(11)]
        [DefaultValue("")]
        public string Category { get; set; } = "";

        [ProtoMember(21)]
        public UserContainer User { get; set; }
    }

    [ProtoContract]
    public partial class MemberMessageData : AProtoBase
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
        public List<MessageDetails> Details { get; set; } = new List<MessageDetails>();
    }

    [ProtoContract]
    public partial class SocialMessageData : AProtoBase
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
        public List<MessageDetails> Details { get; set; } = new List<MessageDetails>();
    }

    [ProtoContract]
    public partial class RankTextMessage : AProtoBase
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
        public List<MessageDetails> Details { get; set; } = new List<MessageDetails>();
    }
}