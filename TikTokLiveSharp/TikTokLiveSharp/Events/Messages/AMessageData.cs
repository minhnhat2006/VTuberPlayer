namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public abstract class AMessageData
    {
        public readonly ulong MessageId;
        public readonly ulong RoomId;
        public readonly ulong TimeStamp;

        public AMessageData(ulong roomId, ulong messageId, ulong timeStamp)
        {
            RoomId = roomId;
            MessageId = messageId;
            TimeStamp = timeStamp;
        }
    }
}
