using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.DataObjects
{
    [ProtoContract]
    public partial class UserContainer : AProtoBase
    {
        [ProtoMember(1)]
        public User User { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }
    }
}
