using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastLinkMicFanTicketMethod : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public FanTicketDataContainer Data { get; set; }
    }

    [ProtoContract]
    public partial class FanTicketDataContainer : AProtoBase
    {
        [ProtoMember(1)]
        public FanTicketData Details { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Icon { get; set; } = "";
    }

    [ProtoContract]
    public partial class FanTicketData : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Id { get; set; }

        [ProtoMember(2)]
        public uint Data { get; set; }
    }
}
