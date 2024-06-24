using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastBarrageMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(3)]
        public uint Data1 { get; set; }

        [ProtoMember(4)]
        public Picture Picture { get; set; }

        [ProtoMember(5)]
        public BarrageMessage Message { get; set; }

        [ProtoMember(6)]
        public uint Data2 { get; set; }

        [ProtoMember(7)]
        public Picture Picture2 { get; set; }

        [ProtoMember(8)]
        public Picture Picture3 { get; set; }

        [ProtoMember(100)]
        public BarrageUser UserData { get; set; }
    }

    [ProtoContract]
    public partial class BarrageMessage : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string EventType { get; set; } = "";

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Label { get; set; } = "";

        [ProtoMember(3)]
        public TikTokColor Color { get; set; }

        [ProtoMember(4)]
        public List<BarrageData> Data1 { get; set; }
    }

    [ProtoContract]
    public partial class BarrageData : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Data1 { get; set; }

        [ProtoMember(11)]
        [DefaultValue("")]
        public string Data2 { get; set; } = "";

        [ProtoMember(21)]
        public UserContainer User { get; set; }
    }


    [ProtoContract]
    public partial class BarrageUser : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public uint Data2 { get; set; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string UserId { get; set; } = "";

        [ProtoMember(4)]
        public User User { get; set; }
    }
}
