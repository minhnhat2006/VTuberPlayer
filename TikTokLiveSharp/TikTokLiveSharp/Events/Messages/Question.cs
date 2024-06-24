using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class Question : AMessageData
    {
        public readonly ulong QuestionId;
        public readonly string Text;
        public readonly ulong Time;
        public readonly Objects.User User;

        internal Question(WebcastQuestionNewMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            var data = msg?.Details;
            QuestionId = data?.Id ?? 0;
            Text = data?.Text;
            Time = data?.Timestamp ?? 0;
            if (data?.User != null)
                User = new Objects.User(data.User);
        }
    }
}
