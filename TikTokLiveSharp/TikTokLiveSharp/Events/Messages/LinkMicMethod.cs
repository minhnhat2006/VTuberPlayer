using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    /// <summary>
    /// Data about LinkMicBattle
    /// Not really implemented right now
    /// </summary>
    public sealed class LinkMicMethod : AMessageData
    {
        public readonly string JSON;

        internal LinkMicMethod(WebcastLinkMicMethod msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        { }

        internal LinkMicMethod(Models.Protobuf.Messages.LinkMicMethod msg)
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            JSON = msg?.Json;
        }
    }
}
