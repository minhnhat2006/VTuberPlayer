using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Message related to Chat-moderation?
    /// </summary>
    [ProtoContract]
    public partial class WebcastImDeleteMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Data1 { get; set; } = "";

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Data2 { get; set; } = "";
    }
}
