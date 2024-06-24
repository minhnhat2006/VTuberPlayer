using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastLinkLayerMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(3)]
        public ulong Id { get; set; }

        [ProtoMember(4)]
        public uint Data2 { get; set; }

        [ProtoMember(100)]
        public LinkLayerDetails Details { get; set; }

        [ProtoMember(102)]
        public LinkLayerData DataContainer { get; set; }

        [ProtoMember(110)]
        public LinkLayerIdContainer IdContainer1 { get; set; }

        [ProtoMember(111)]
        public LinkLayerIdContainer IdContainer2 { get; set; }
    }

    [ProtoContract]
    public partial class LinkLayerDetails : AProtoBase
    {
        [ProtoMember(1)]
        public IdContainer Ids { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string IdString { get; set; } = "";

        [ProtoMember(3)]
        public StringData Data { get; set; } // Only Data2 is Filled

        [ProtoMember(4)]
        public ulong Id2 { get; set; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string Data2 { get; set; } = "";
    }

    [ProtoContract]
    public partial class LinkLayerData : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public LinkLayerDetailsContainer Details { get; set; }
    }

    [ProtoContract]
    public partial class LinkLayerDetailsContainer : AProtoBase
    {
        [ProtoMember(2)]
        public LinkLayerDetails Data1 { get; set; }

        [ProtoMember(3)]
        public List<LinkLayerDetails> Data2 { get; set; } = new List<LinkLayerDetails>();
    }

    [ProtoContract]
    public partial class LinkLayerIdContainer : AProtoBase
    {
        [ProtoMember(1)]
        public IdContainer Ids { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }
    }
}
