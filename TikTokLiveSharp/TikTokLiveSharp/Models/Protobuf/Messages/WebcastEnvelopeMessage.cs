using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Envelope
    /// </summary>
    [ProtoContract]
    public partial class WebcastEnvelopeMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        /// <summary>
        /// Sender?
        /// </summary>
        [ProtoMember(2)]
        public EnvelopeUser User { get; set; }

        [ProtoMember(3)]
        public uint Data1 { get; set; }
    }

    [ProtoContract]
    public partial class EnvelopeUser : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Id { get; set; } = "";

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Username { get; set; } = "";

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Id2 { get; set; } = "";

        [ProtoMember(5)]
        public uint Data2 { get; set; }

        [ProtoMember(6)]
        public uint Data3 { get; set; }

        [ProtoMember(7)]
        public ulong Timestamp1 { get; set; }

        [ProtoMember(8)]
        [DefaultValue("")]
        public string Id1String { get; set; } = "";

        [ProtoMember(9)]
        public Picture Picture { get; set; }

        [ProtoMember(10)]
        [DefaultValue("")]
        public string Timestamp2String { get; set; } = "";

        [ProtoMember(11)]
        [DefaultValue("")]
        public string Id2String { get; set; } = "";

        [ProtoMember(12)]
        public uint Data4 { get; set; }
    }
}
