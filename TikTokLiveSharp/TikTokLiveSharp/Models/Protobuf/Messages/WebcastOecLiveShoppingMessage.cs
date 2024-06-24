using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastOecLiveShoppingMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(4)]
        public LiveShoppingData ShopData { get; set; }

        /// <summary>
        /// Uses Index 1, 2 & 3
        /// </summary>
        [ProtoMember(4)]
        public TimestampContainer ShopTimings { get; set; }

        [ProtoMember(9)]
        public LiveShoppingDetails Details { get; set; }
    }


    [ProtoContract]
    public partial class LiveShoppingData : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Title { get; set; } = "";

        /// <summary>
        /// $55.99
        /// </summary>
        [ProtoMember(2)]
        [DefaultValue("")]
        public string PriceString { get; set; } = "";

        [ProtoMember(3)]
        [DefaultValue("")]
        public string ImageUrl { get; set; } = "";

        [ProtoMember(4)]
        [DefaultValue("")]
        public string ShopUrl { get; set; } = "";

        [ProtoMember(6)]
        public ulong Data1 { get; set; }

        /// <summary>
        /// Shopify
        /// </summary>
        [ProtoMember(7)]
        [DefaultValue("")]
        public string ShopName { get; set; } = "";

        [ProtoMember(8)]
        public ulong Data2 { get; set; }

        [ProtoMember(9)]
        [DefaultValue("")]
        public string ShopUrl2 { get; set; } = "";

        [ProtoMember(10)]
        public ulong Data3 { get; set; }

        [ProtoMember(11)]
        public ulong Data4 { get; set; }
    }

    [ProtoContract]
    public partial class LiveShoppingDetails : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Id1 { get; set; } = "";

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Data1 { get; set; } = "";

        [ProtoMember(4)]
        public uint Data2 { get; set; }

        [ProtoMember(5)]
        public ulong Timestamp { get; set; }

        [ProtoMember(6)]
        public ValueLabel Data { get; set; }
    }
}
