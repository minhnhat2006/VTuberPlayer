using System.Linq;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class RoomViewerData : AMessageData
    {
        public readonly uint ViewerCount;
        public readonly Objects.TopViewer[] TopViewers;        

        internal RoomViewerData(WebcastRoomUserSeqMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            ViewerCount = msg?.ViewerCount ?? 0;
            TopViewers = msg?.TopViewers?.Select(t => new Objects.TopViewer(t))?.OrderBy(t => t.Rank)?.ToArray();
        }
    }
}