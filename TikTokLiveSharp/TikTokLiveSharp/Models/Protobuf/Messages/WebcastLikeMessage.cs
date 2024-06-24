using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// User sent one or multiple likes to Stream. Maxes at 15 likes per message
    /// </summary>
    [ProtoContract]
    public partial class WebcastLikeMessage : AProtoBase
    {
        [ProtoMember(1)]
        public LikeMessageHeader Header { get; set; }

        /// <summary>
        /// Number of Likes for this message. Maxes at 15
        /// </summary>
        [ProtoMember(2)]
        public uint Count { get; set; }

        [ProtoMember(3)]
        public ulong TotalLikes { get; set; }

        /// <summary>
        /// Sender of Like(s)
        /// </summary>
        [ProtoMember(5)]
        public User Sender { get; set; }

        /// <summary>
        /// Not always filled. The Data in Header IS always filled.
        /// </summary>
        [ProtoMember(8)]
        public LikeDataContainer LikeData { get; set; }

        [ProtoMember(9)]
        public uint Data1 { get; set; }
    }

    [ProtoContract]
    public partial class LikeDataContainer : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Data1 { get; set; }

        [ProtoMember(2)]
        public LikeData LikeData { get; set; }
    }
}
