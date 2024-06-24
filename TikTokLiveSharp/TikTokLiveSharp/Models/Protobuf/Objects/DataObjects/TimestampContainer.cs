using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.DataObjects
{
    [ProtoContract]
    public partial class TimestampContainer : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Timestamp1 { get; set; }

        [ProtoMember(2)]
        public ulong Timestamp2 { get; set; }

        [ProtoMember(3)]
        public ulong Timestamp3 { get; set; }
    }
}
