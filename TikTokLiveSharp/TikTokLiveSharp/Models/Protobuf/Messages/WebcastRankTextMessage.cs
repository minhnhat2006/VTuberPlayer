using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastRankTextMessage : AProtoBase
    {
        [ProtoMember(1)]
        public WebcastRankTextMessageHeader Header { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(3)]
        public uint Data2 { get; set; }

        [ProtoMember(4)]
        public uint Data3 { get; set; }

        [ProtoMember(5)]
        public RankTextMessageSummary DetailsSmall { get; set; }

        [ProtoMember(6)]
        public RankTextMessage Details { get; set; }

        [ProtoMember(7)]
        public ulong Id1 { get; set; }
    }


    [ProtoContract]
    public partial class RankTextMessageSummary : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Type { get; set; } = "";

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Label { get; set; } = "";

        [ProtoMember(3)]
        public TikTokColor Color { get; set; }

        [ProtoMember(4)]
        public ValueLabel Details { get; set; }
    }
}
