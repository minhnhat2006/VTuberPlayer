using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class Badge : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public uint Data2 { get; set; }

        [ProtoMember(3)]
        public uint Data3 { get; set; }

        [ProtoMember(4)]
        public uint Data4 { get; set; }

        [ProtoMember(10)]
        [DefaultValue("")]
        public string ShortUrl { get; set; } = "";

        [ProtoMember(11)]
        public uint Data5 { get; set; }

        [ProtoMember(12)]
        public IdData BadgeId { get; set; }

        /*
            Typically either 20, 21 or 23 is populated.
            More than one is not populated at once.
        */
        /// <summary>
        /// Seems to hold images (top gifter, sub) with no extra data
        /// </summary>
        [ProtoMember(20)]
        public List<BadgeImage> ImageBadges { get; set; } = new List<BadgeImage>();

        /// <summary>
        /// Holds badge info (moderator)
        /// </summary>
        [ProtoMember(21)]
        public List<BadgeText> TextBadges { get; set; } = new List<BadgeText>();

        /// <summary>
        /// Seems to hold image badges but with data (Level badge, sub level w/ name, etc)
        /// </summary>
        [ProtoMember(23)]
        public BadgeComplex ComplexBadge { get; set; }
    }

    [ProtoContract]
    public partial class BadgeText : AProtoBase
    {
        [ProtoMember(2)]
        [DefaultValue("")]
        public string Type { get; set; } = "";

        [ProtoMember(3)]
        [DefaultValue("")]
        public string Name { get; set; } = "";
    }

    [ProtoContract]
    public partial class BadgeImage : AProtoBase
    {
        /// <summary>
        /// TODO: IS AN ENUM
        /// </summary>
        [ProtoMember(1)]
        public uint DisplayType { get; set; }

        [ProtoMember(2)]
        public Picture Image { get; set; }
    }

    [ProtoContract]
    public partial class BadgeComplex : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string ImageUrl { get; set; } = "";

        [ProtoMember(4)]
        [DefaultValue("")]
        public string Data { get; set; } = "";

        [ProtoMember(5)]
        public DataContainer Detail1 { get; set; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string Data2 { get; set; } = "";

        [ProtoMember(11)]
        public BadgeText Detail2 { get; set; }

        [ProtoMember(12)]
        public BadgeText Detail3 { get; set; }

        [ProtoMember(15)]
        public uint Data3 { get; set; }

        [ProtoMember(16)]
        public uint Data4 { get; set; }
    }
}
