using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Headers
{
    [ProtoContract]
    public partial class MessageHeader : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string MessageType { get; set; } = "";

        [ProtoMember(2)]
        public ulong MessageId { get; set; }

        [ProtoMember(3)]
        public ulong RoomId { get; set; }

        [ProtoMember(4)]
        public ulong ServerTime { get; set; }

        [ProtoMember(5)]
        public uint Data1 { get; set; }

        [ProtoMember(6)]
        public uint Data2 { get; set; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string Description { get; set; } = "";

        [ProtoMember(8)]
        public HeaderData HeaderData { get; set; }

        [ProtoMember(9)]
        public ulong Data3 { get; set; }

        [ProtoMember(10)]
        public ulong Data4 { get; set; }

        [ProtoMember(11)]
        public ulong Data5 { get; set; }

        [ProtoMember(15)]
        [DefaultValue("")]
        public string Details { get; set; } = "";

        [ProtoMember(17)]
        [DefaultValue("")]
        public string Description2 { get; set; } = "";

        [ProtoMember(18)]
        public ControlData ControlData { get; set; }

        [ProtoMember(21)]
        public ulong Data6 { get; set; }

        [ProtoMember(22)]
        public ulong Data7 { get; set; }

        [ProtoMember(23)]
        public ulong Data8 { get; set; }

        [ProtoMember(24)]
        public ulong Data9 { get; set; }

        [ProtoMember(25)]
        public ulong Timestamp1 { get; set; }
    }

    [ProtoContract]
    public partial class HeaderData : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string MessageType { get; set; } = "";

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Details { get; set; } = "";

        [ProtoMember(3)]
        public TikTokColor Color { get; set; }

        [ProtoMember(4)]
        public List<HeaderDataDetails> AdditionalData { get; set; } = new List<HeaderDataDetails>();
    }

    [ProtoContract]
    public partial class ControlData : AProtoBase
    {
        [ProtoMember(1)]
        public StringData MessageType { get; set; }

        [ProtoMember(2)]
        public ulong ServerTime { get; set; }
    }

    [ProtoContract]
    public partial class HeaderDataDetails : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(11)] 
        [DefaultValue("")] 
        public string Data2 { get; set; } = "";

        [ProtoMember(21)] 
        public List<UserContainer> Users { get; set; } = new List<UserContainer>();
    }
}
