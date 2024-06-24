using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class Envelope : AMessageData
    {
        public readonly Objects.User User;

        internal Envelope(WebcastEnvelopeMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            User = new Objects.User(0, msg?.User?.Id, msg?.User?.Username, null, null, null, null, null, 0, 0, 0, null);
        }
    }
}
