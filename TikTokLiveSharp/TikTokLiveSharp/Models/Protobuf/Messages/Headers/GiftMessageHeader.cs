using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Headers
{
    [ProtoContract]
    public partial class GiftMessageHeader : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string MessageType { get; set; } = "";

        [ProtoMember(2)]
        public ulong MessageId { get; set; }

        /// <summary>
        /// Does not always match RoomId?
        /// </summary>
        [ProtoMember(3)]
        public ulong RoomId { get; set; }

        [ProtoMember(4)]
        public ulong ServerTime { get; set; }

        [ProtoMember(5)]
        public uint Data1 { get; set; }

        [ProtoMember(6)]
        public uint Data2 { get; set; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string Description { get; set; } = "";

        [ProtoMember(8)]
        public GiftHeaderData HeaderData { get; set; }

        [ProtoMember(9)]
        public ulong Data3 { get; set; }

        [ProtoMember(10)]
        public ulong Data4 { get; set; }

        [ProtoMember(11)]
        public ulong Data5 { get; set; }

        [ProtoMember(15)]
        [DefaultValue("")]
        public string Details { get; set; } = "";

        /// <summary>
        /// "gift_expensive" found in WebcastGiftBroadcastMessage
        /// </summary>
        [ProtoMember(17)]
        [DefaultValue("")]
        public string Description2 { get; set; } = "";

        [ProtoMember(18)]
        public ControlData ControlData { get; set; }

        [ProtoMember(21)]
        public ulong Data6 { get; set; }

        [ProtoMember(22)]
        public ulong Data7 { get; set; }

        [ProtoMember(23)]
        public ulong Data8 { get; set; }

        [ProtoMember(24)]
        public ulong Data9 { get; set; }

        [ProtoMember(25)]
        public ulong Timestamp1 { get; set; }
    }

    [ProtoContract]
    public partial class GiftHeaderData : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string MessageType { get; set; } = "";

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Details { get; set; } = "";

        [ProtoMember(3)]
        public TikTokColor Color { get; set; }

        [ProtoMember(4)]
        public List<GiftHeaderGiftData> GiftData { get; set; } = new List<GiftHeaderGiftData>();
    }

    [ProtoContract]
    public partial class GiftHeaderGiftData : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public TikTokColor Color { get; set; }

        [ProtoMember(11)]
        [DefaultValue("")]
        public string Details { get; set; } = "";

        [ProtoMember(21)]
        public UserContainer User { get; set; }

        [ProtoMember(22)]
        public GiftHeaderGiftDataDetails Data2 { get; set; }
    }


    [ProtoContract]
    public partial class GiftHeaderGiftDataDetails : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Data1 { get; set; }

        /// <summary>
        /// 1 = DataType, 2 = GiftName
        /// </summary>
        [ProtoMember(2)]
        public StringData Details { get; set; }

        [ProtoMember(4)]
        public ulong Data2 { get; set; }
    }
}
