using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Gift Broadcast (Unsure of exact event)
    /// </summary>
    [ProtoContract]
    public partial class WebcastGiftBroadcastMessage : AProtoBase
    {
        [ProtoMember(1)]
        public GiftMessageHeader Header { get; set; }

        [ProtoMember(2)]
        public ulong Data1 { get; set; }

        [ProtoMember(3)]
        public Picture Picture { get; set; }

        [ProtoMember(4)]
        public GiftBroadcastData Data { get; set; }
    }

    [ProtoContract]
    public partial class GiftBroadcastData : AProtoBase
    {
        [ProtoMember(1)]
        public WebcastRoomNotifyMessage RoomNotifyMessage { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string uri { get; set; } = "";

        [ProtoMember(3)]
        public uint Data1 { get; set; }

        [ProtoMember(6)]
        public GiftBroadCastImageDataContainer ImageData { get; set; }

        [ProtoMember(9)]
        [DefaultValue("")]
        public string NotifyType { get; set; } = "";

        [ProtoMember(10)]
        public ulong Data2 { get; set; }

        [ProtoMember(11)]
        public StringData Data3 { get; set; }
    }

    [ProtoContract]
    public partial class GiftBroadCastImageDataContainer : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public GiftBroadcastImageData ImageData { get; set; }

    }

    [ProtoContract]
    public partial class GiftBroadcastImageData : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public uint Data2 { get; set; }

        [ProtoMember(3)]
        public List<string> Urls { get; set; } = new List<string>();

        [ProtoMember(4)]
        [DefaultValue("")]
        public string uri { get; set; } = "";
    }
}
