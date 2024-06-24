using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastInRoomBannerMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        /// <summary>
        /// Json-Data for BannerMessage
        /// </summary>
        [ProtoMember(2)]
        [DefaultValue("")]
        public string Json { get; set; } = "";
    }
}
