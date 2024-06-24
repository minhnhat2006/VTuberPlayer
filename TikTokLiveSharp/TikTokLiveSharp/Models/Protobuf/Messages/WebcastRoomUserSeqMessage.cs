using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Status of Room (ViewerCount + Top Viewers)
    /// </summary>
    [ProtoContract]
    public partial class WebcastRoomUserSeqMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        /// <summary>
        /// Top 4 or less
        /// </summary>
        [ProtoMember(2)]
        public List<TopViewer> TopViewers { get; set; } = new List<TopViewer>();

        /// <summary>
        /// Number of Viewers in Room
        /// </summary>
        [ProtoMember(3)]
        public uint ViewerCount { get; set; }

        [ProtoMember(7)]
        public ulong Data1 { get; set; }

        [ProtoMember(8)]
        public uint Data2 { get; set; }
    }
}
