using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Gift : AProtoBase
    {
        [ProtoMember(1)]
        public Picture Image { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Description { get; set; } = "";

        [ProtoMember(4)]
        public int Data1 { get; set; }

        /// <summary>
        /// Gift-Id
        /// </summary>
        [ProtoMember(5)]
        public ulong Id { get; set; }

        [ProtoMember(7)]
        public int Data2 { get; set; }

        [ProtoMember(10)]
        public int Data3 { get; set; }

        /// <summary>
        /// TODO: SHOULD BE AN ENUM?
        /// </summary>
        [ProtoMember(11)]
        public uint GiftType { get; set; }

        /// <summary>
        /// Value of Gift
        /// </summary>
        [ProtoMember(12)]
        public uint CoinCount { get; set; }

        [ProtoMember(13)]
        public int Data4 { get; set; }

        [ProtoMember(14)]
        public uint Data5 { get; set; }

        /// <summary>
        /// Additional Image
        /// </summary>
        [ProtoMember(15)]
        public Picture Picture { get; set; }

        /// <summary>
        /// Name of Gift
        /// </summary>
        [ProtoMember(16)]
        [DefaultValue("")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Same Url as Image, but with different Color
        /// </summary>
        [ProtoMember(21)]
        public Picture ColoredImage { get; set; }

        [ProtoMember(38)]
        public uint Data7 { get; set; }

        [ProtoMember(42)]
        public uint Data8 { get; set; }

        [ProtoMember(51)]
        public uint Data9 { get; set; }

        [ProtoMember(102)]
        public List<GiftDetails> Details { get; set; } = new List<GiftDetails>();

        [ProtoMember(104)]
        public GiftMasks Masks { get; set; }

        [ProtoMember(105)]
        public uint Data10 { get; set; }

        [ProtoMember(106)]
        [DefaultValue("")]
        public string Data11 { get; set; } = "";
    }

    [ProtoContract]
    public partial class GiftDetails : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Name { get; set; } = "";

        [ProtoMember(3)]
        public List<string> Colors { get; set; } = new List<string>();

        [ProtoMember(4)]
        public Picture Image { get; set; }

        [ProtoMember(5)]
        public Picture Icon { get; set; }

        [ProtoMember(6)]
        public uint Data2 { get; set; }

        [ProtoMember(7)]
        public uint Data3 { get; set; }
    }

    [ProtoContract]
    public partial class GiftMasks : AProtoBase
    {
        [ProtoMember(3)]
        public GiftMask Mask1 { get; set; }

        [ProtoMember(4)]
        public GiftMask Mask2 { get; set; }
    }

    [ProtoContract]
    public partial class GiftMask : AProtoBase
    {
        /// <summary>
        /// BitMask (EnumFlags?)
        /// </summary>
        [ProtoMember(13)]
        public uint Mask { get; set; }
    }

    [ProtoContract]
    public partial class GiftDetailsData : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public TikTokColor Color { get; set; }

        [ProtoMember(11)]
        [DefaultValue("")]
        public string Data2 { get; set; } = "";

        [ProtoMember(21)]
        public UserContainer User { get; set; }

        [ProtoMember(22)]
        public GiftDataDetailed Details { get; set; }
    }


    [ProtoContract]
    public partial class GiftDataDetailed : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public StringData Strings { get; set; }

        [ProtoMember(3)]
        public uint Data2 { get; set; }

        [ProtoMember(4)]
        public int Data3 { get; set; }
    }
}
