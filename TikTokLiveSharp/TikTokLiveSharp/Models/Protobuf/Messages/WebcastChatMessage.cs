using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Comment sent by User
    /// </summary>
    [ProtoContract]
    public partial class WebcastChatMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        /// <summary>
        /// User who sent message
        /// </summary>
        [ProtoMember(2)]
        public User Sender { get; set; }

        /// <summary>
        /// Text for Chat-Message
        /// </summary>
        [ProtoMember(3)]
        [DefaultValue("")]
        public string Comment { get; set; } = "";

        [ProtoMember(11)]
        public ulong Data1 { get; set; }

        /// <summary>
        /// Users Mentioned in Comment
        /// </summary>
        [ProtoMember(12)]
        public List<User> MentionedUsers { get; set; } = new List<User>();

        [ProtoMember(13)]
        public List<ChatImage> Images { get; set; } = new List<ChatImage>();

        /// <summary>
        /// Language for sender
        /// </summary>
        [ProtoMember(14)]
        [DefaultValue("")]
        public string Language { get; set; } = "";

        [ProtoMember(18)]
        public DataContainer ChatData { get; set; }

        [ProtoMember(19)]
        public List<ModerationData> ModerationData { get; set; } = new List<ModerationData>();
    }


    [ProtoContract]
    public partial class ChatImage : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Data1 { get; set; }

        [ProtoMember(2)]
        public Picture Picture { get; set; }
    }

    [ProtoContract]
    public partial class ModerationData : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Type { get; set; } = "";

        [ProtoMember(2)]
        public ulong Value { get; set; }
    }
}
