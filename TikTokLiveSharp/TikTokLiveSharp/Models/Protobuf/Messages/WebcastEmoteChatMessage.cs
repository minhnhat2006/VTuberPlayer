using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Emote sent by User
    /// </summary>
    [ProtoContract]
    public partial class WebcastEmoteChatMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public User Sender { get; set; }

        [ProtoMember(3)]
        public EmoteDetails Details { get; set; }
    }

    [ProtoContract]
    public partial class EmoteDetails : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Id { get; set; } = "";

        [ProtoMember(2)]
        public EmoteImage Image { get; set; }
    }

    [ProtoContract]
    public partial class EmoteImage : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Url { get; set; } = "";
    }
}
