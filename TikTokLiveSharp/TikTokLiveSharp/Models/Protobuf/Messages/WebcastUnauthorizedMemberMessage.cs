using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastUnauthorizedMemberMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(3)]
        public MemberMessageData Details1 { get; set; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Data2 { get; set; } = "";

        [ProtoMember(5)]
        public MemberMessageData Details2 { get; set; }
    }
}
