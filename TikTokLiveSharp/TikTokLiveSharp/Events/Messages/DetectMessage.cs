using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class DetectMessage : AMessageData
    {
        public readonly string Language;

        public readonly IReadOnlyList<uint> Data;
        public readonly IReadOnlyList<ulong> Timings;

        internal DetectMessage(WebcastMsgDetectMessage msg) : 
            base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            Language = msg?.Language;
            Data = new List<uint>{ (uint)(msg?.Data2?.Data1 ?? 0), (uint)(msg?.Data2?.Data2 ?? 0), (uint)(msg?.Data2?.Data3 ?? 0) };
            Timings = new List<ulong> { msg?.Timestamps?.Timestamp1 ?? 0, msg?.Timestamps?.Timestamp2 ?? 0, msg?.Timestamps?.Timestamp3 ?? 0 };
        }
    }
}
