using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class GiftMessage : AMessageData
    {
        public readonly Objects.Gift Gift;
        public readonly Objects.User Sender;

        public readonly string PurchaseId;
        public readonly string Receipt;

        public readonly uint Amount;
        public readonly bool StreakFinished;
        public readonly uint StreakIndex;

        internal GiftMessage(WebcastGiftMessage msg) : 
            base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            Gift = new Objects.Gift(msg?.GiftDetails);
            if (msg?.Sender != null)
                Sender = new Objects.User(msg.Sender);
            PurchaseId = msg?.LogId;
            Receipt = msg?.ReceiptJson;
            Amount = msg?.Amount ?? 0;
            StreakFinished = msg?.RepeatEnd ?? true;
            StreakIndex = msg?.RepeatCount ?? 0;
        }
    }
}
