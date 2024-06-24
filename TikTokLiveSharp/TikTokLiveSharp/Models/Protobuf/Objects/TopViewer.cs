using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TopViewer : AProtoBase
    {
        /// <summary>
        /// Coins given to Room
        /// </summary>
        [ProtoMember(1)]
        public uint CoinsGiven { get; set; }

        [ProtoMember(2)]
        public User User { get; set; }

        /// <summary>
        /// Index in List
        /// </summary>
        [ProtoMember(3)]
        public uint Rank { get; set; }
    }
}
