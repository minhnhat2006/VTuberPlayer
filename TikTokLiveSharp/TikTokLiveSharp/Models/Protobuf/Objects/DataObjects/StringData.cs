using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects.DataObjects
{
    [ProtoContract]
    public partial class StringData : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Data1 { get; set; } = "";

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Data2 { get; set; } = "";
    }
}
