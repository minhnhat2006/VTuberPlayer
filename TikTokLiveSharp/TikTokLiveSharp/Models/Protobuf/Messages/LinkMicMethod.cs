using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Separate from WebcastLinkMicMethod. This contains RTC-Data
    /// </summary>
    [ProtoContract]
    public partial class LinkMicMethod : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(8)]
        public ulong RTCChannelId { get; set; }

        /// <summary>
        /// Either data2 or data3 is probably RTC_Vendor
        /// </summary>
        [ProtoMember(9)]
        public uint Data2 { get; set; }

        /// <summary>
        /// Either data2 or data3 is probably RTC_Vendor
        /// </summary>
        [ProtoMember(10)]
        public uint Data3 { get; set; }

        [ProtoMember(11)]
        public uint Data4 { get; set; }

        [ProtoMember(13)]
        public ulong Data5 { get; set; }

        [ProtoMember(24)]
        public ulong Id1 { get; set; }

        [ProtoMember(28)]
        public ulong Data6 { get; set; }

        /// <summary>
        /// Either data7 or data9 is probably RTC_MixType
        /// </summary>
        [ProtoMember(29)]
        public ulong Data7 { get; set; }

        [ProtoMember(31)]
        [DefaultValue("")]
        public string Data8 { get; set; } = "";

        /// <summary>
        /// RTC-Data in JSON-Format
        /// </summary>
        [ProtoMember(32)]
        [DefaultValue("")]
        public string Json { get; set; } = "";

        [ProtoMember(37)]
        [DefaultValue("")]
        public string RTCUserId { get; set; } = "";

        [ProtoMember(43)]
        public uint Data9 { get; set; }

        [ProtoMember(51)]
        public uint Data10 { get; set; }
    }
}
