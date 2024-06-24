using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.DataObjects
{
    [ProtoContract]
    public partial class TimeData : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data { get; set; }

        [ProtoMember(2)]
        public ulong Timestamp { get; set; }

        [ProtoMember(3)]
        public ulong Timestamp2 { get; set; }
    }
}
