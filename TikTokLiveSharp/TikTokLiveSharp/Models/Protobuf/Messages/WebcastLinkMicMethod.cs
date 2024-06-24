using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastLinkMicMethod : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public ulong Data1 { get; set; }

        [ProtoMember(5)]
        public ulong Id1 { get; set; }

        [ProtoMember(6)]
        public uint Data2 { get; set; }

        [ProtoMember(7)]
        public uint Data3 { get; set; }

        [ProtoMember(8)]
        public ulong Id2 { get; set; }

        [ProtoMember(9)]
        public uint Data4 { get; set; }

        [ProtoMember(10)]
        public ulong Data5 { get; set; }

        [ProtoMember(38)]
        public ulong Id3 { get; set; }

        [ProtoMember(39)]
        public uint Data6 { get; set; }

        /// <summary>
        /// Combines Data6 & Id
        /// </summary>
        [ProtoMember(40)]
        [DefaultValue("")]
        public string Data7 { get; set; } = "";

        [ProtoMember(43)]
        public uint Data8 { get; set; }
    }
}
