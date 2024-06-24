using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastMsgDetectMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        /// <summary>
        /// Only uses Indexes 1, 2 & 4
        /// </summary>
        [ProtoMember(3)]
        public DataContainer Data2 { get; set; }

        [ProtoMember(4)]
        public TimestampContainer Timestamps { get; set; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string Language { get; set; } = "";
    }
}
