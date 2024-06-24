using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.DataObjects
{
    [ProtoContract]
    public partial class IdContainer : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Id1 { get; set; }

        [ProtoMember(2)]
        public ulong Id2 { get; set; }
    }
}
