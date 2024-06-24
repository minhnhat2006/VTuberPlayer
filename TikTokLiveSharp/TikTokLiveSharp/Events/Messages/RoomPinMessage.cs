using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class RoomPinMessage : AMessageData
    {
        public readonly ulong PinTimeStamp;

        public Comment Comment;

        internal RoomPinMessage(WebcastRoomPinMessage msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            PinTimeStamp = msg?.Timestamp ?? 0;
            Comment = new Comment(msg?.PinData1);
        }
    }
}
