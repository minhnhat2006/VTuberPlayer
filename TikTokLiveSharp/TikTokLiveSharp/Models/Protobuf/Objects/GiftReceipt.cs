using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Objects
{
    [ProtoContract]
    public partial class GiftReceipt : AProtoBase
    {
        [ProtoMember(1)]
        public ulong AnchorId { get; set; }

        /// <summary>
        /// send_gift_profit_api_start_ms
        /// </summary>
        [ProtoMember(3)]
        public ulong ProfitApiStartTimestamp { get; set; }

        /// <summary>
        /// send_gift_profit_core_start_ms
        /// </summary>
        [ProtoMember(4)]
        public ulong ProfitCoreStartTimestamp { get; set; }

        /// <summary>
        /// send_gift_req_start_ms
        /// </summary>
        [ProtoMember(5)]
        public ulong SendGiftRequestTimestamp { get; set; }

        /// <summary>
        /// send_gift_send_message_success_ms
        /// </summary>
        [ProtoMember(6)]
        public ulong Timestamp { get; set; }

        /// <summary>
        /// send_profitapi_dur
        /// </summary>
        [ProtoMember(7)]
        public ulong ProfitApiDuration { get; set; }

        /// <summary>
        /// UserId for receiver
        /// </summary>
        [ProtoMember(8)]
        public ulong ReceiverUserId { get; set; }

        /// <summary>
        /// Unknown timestamp. Earliest in message (Possibly Request-Start?)
        /// </summary>
        [ProtoMember(9)]
        public ulong Timestamp1 { get; set; }

        [ProtoMember(10)]
        [DefaultValue("")]
        public string OperatingSystem { get; set; } = "";

        /// <summary>
        /// 270504 (Id?)
        /// </summary>
        [ProtoMember(11)]
        [DefaultValue("")]
        public string Data1 { get; set; } = "";
    }
}
