using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects.DataObjects
{
    [ProtoContract]
    public partial class TypeValue : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Type { get; set; } = "";

        [ProtoMember(2)]
        public uint Data { get; set; }
    }
}
