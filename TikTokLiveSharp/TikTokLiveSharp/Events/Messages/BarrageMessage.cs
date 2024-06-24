using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class BarrageMessage : AMessageData
    {
        public readonly Objects.Picture Picture;
        public readonly Objects.Picture Picture2;
        public readonly Objects.Picture Picture3;

        public readonly Objects.User User;

        public readonly Objects.BarrageData BarrageData;

        internal BarrageMessage(WebcastBarrageMessage msg) :
            base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            Picture = new Objects.Picture(msg?.Picture);
            Picture2 = new Objects.Picture(msg?.Picture2);
            Picture3 = new Objects.Picture(msg?.Picture3);
            User = new Objects.User(msg?.UserData?.User);
            BarrageData = new Objects.BarrageData(msg?.Message?.EventType, msg?.Message?.Label, msg?.Message?.Data1?.Select(d =>
            {
                if (d?.User?.User != null)
                    return (new Objects.User(d?.User?.User), d?.Data2);
                return (null, d?.Data2);
            })?.ToList());
        }
    }
}
