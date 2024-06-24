using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class TikTokColor : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Color { get; set; } = "";

        [ProtoMember(4)]
        public ulong Id { get; set; }

        [ProtoMember(6)]
        public uint Data1 { get; set; }
    }
}
