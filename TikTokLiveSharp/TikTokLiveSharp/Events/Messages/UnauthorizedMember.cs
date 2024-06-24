using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class UnauthorizedMember : AMessageData
    {
        public readonly string Data;

        public readonly (string, string) Event;

        public readonly (string, string) Underlying;

        internal UnauthorizedMember(WebcastUnauthorizedMemberMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            Data = msg?.Data2;
            Event = (msg?.Details1?.Type, msg?.Details1?.Label);
            Underlying = (msg?.Details2?.Type, msg?.Details2?.Label);
        }
    }
}
