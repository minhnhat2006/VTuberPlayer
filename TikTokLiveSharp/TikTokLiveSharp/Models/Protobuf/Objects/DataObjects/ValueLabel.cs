using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class ValueLabel : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Label { get; set; } = "";

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Label2 { get; set; } = "";


        [ProtoMember(11)]
        [DefaultValue("")]
        public string Label3 { get; set; } = "";
    }
}
