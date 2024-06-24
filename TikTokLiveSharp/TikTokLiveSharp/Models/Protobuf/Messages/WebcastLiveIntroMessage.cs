using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastLiveIntroMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public ulong RoomId { get; set; }

        [ProtoMember(3)]
        public ulong Data1 { get; set; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Description { get; set; } = "";

        [ProtoMember(5)]
        public User Host { get; set; }

        [ProtoMember(6)]
        public uint Data2 { get; set; }

        [ProtoMember(7)]
        public IntroData MessageData { get; set; }

        [ProtoMember(8)]
        [DefaultValue("")]
        public string Language { get; set; } = "";
    }


    [ProtoContract]
    public partial class IntroData : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(21)]
        public ValueLabel Details { get; set; }
    }
}
