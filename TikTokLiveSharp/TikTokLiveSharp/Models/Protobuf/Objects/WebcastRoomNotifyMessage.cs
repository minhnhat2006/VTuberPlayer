using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    /// <summary>
    /// Is part of WebcastGiftBroadcastMessage. Thus far not seen sent seperately
    /// </summary>
    [ProtoContract]
    public partial class WebcastRoomNotifyMessage : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Type { get; set; } = "";

        [ProtoMember(2)]
        public ulong Id1 { get; set; }

        [ProtoMember(3)]
        public ulong Id2 { get; set; }

        [ProtoMember(4)]
        public ulong Timestamp { get; set; }

        [ProtoMember(6)]
        public uint Data1 { get; set; }

        [ProtoMember(8)]
        public NotifyData Data { get; set; }
    }

    [ProtoContract]
    public partial class NotifyData : AProtoBase
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
        public List<GiftDetailsData> Data { get; set; } = new List<GiftDetailsData>();
    }
}
