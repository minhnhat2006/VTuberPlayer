using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Sent for a variety of events, including Follow & Share
    /// </summary>
    [ProtoContract]
    public partial class WebcastSocialMessage : AProtoBase
    {
        [ProtoMember(1)]
        public SocialMessageHeader Header { get; set; }

        // Can be NULL!!
        [ProtoMember(2)]
        public User Sender { get; set; }

        /// <summary>
        /// Exists on Share-Message
        /// </summary>
        [ProtoMember(3)]
        public ulong Data1 { get; set; }

        [ProtoMember(4)]
        public ulong Data2 { get; set; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Data3 { get; set; } = "";

        /// <summary>
        /// Exists on Follow-Messages
        /// </summary>
        [ProtoMember(6)]
        public ulong TotalFollowers { get; set; }

        /// <summary>
        /// Exists on Share-Message
        /// </summary>
        [ProtoMember(8)]
        public ulong Data4 { get; set; }
    }
}
