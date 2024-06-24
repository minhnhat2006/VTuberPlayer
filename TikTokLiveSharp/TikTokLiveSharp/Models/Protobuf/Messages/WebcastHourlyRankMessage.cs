using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastHourlyRankMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public RankContainer Data { get; set; }

        [ProtoMember(3)]
        public uint Data1 { get; set; }
    }

    [ProtoContract]
    public partial class RankContainer : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public RankingData RankingData { get; set; }

        [ProtoMember(3)]
        public uint Data2 { get; set; }

        [ProtoMember(4)]
        public Ranking Rankings { get; set; }

        [ProtoMember(5)]
        public RankingData2 RankingData2 { get; set; }

        [ProtoMember(6)]
        public uint Data3 { get; set; }

        [ProtoMember(7)]
        public uint Data4 { get; set; }
    }

    [ProtoContract]
    public partial class RankingData : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public Ranking RankData { get; set; }

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Data2 { get; set; } = "";
    }

    [ProtoContract]
    public partial class RankingData2 : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public uint Data2 { get; set; }

        [ProtoMember(3)]
        public Ranking RankData { get; set; }

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Data3 { get; set; } = "";

        [ProtoMember(5)]
        public uint Data4 { get; set; }

        [ProtoMember(6)]
        public uint Data5 { get; set; }
    }
}
