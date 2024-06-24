using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Generic
{
    /// <summary>
    /// Response from TikTokServer. Container for Messages
    /// </summary>
    [ProtoContract]
    public partial class WebcastResponse : AProtoBase
    {
        [ProtoMember(1)]
        public List<Message> Messages { get; set; } = new List<Message>();

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Cursor { get; set; } = "";

        [ProtoMember(3)]
        public int FetchInterval { get; set; }

        [ProtoMember(4)]
        public ulong ServerTimestamp { get; set; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string AckIds { get; set; } = "";

        /// <summary>
        /// TODO: IS AN ENUM (1 = Websocket, 2 = Long-Polling
        /// </summary>
        [ProtoMember(6)]
        public int FetchType { get; set; }

        [ProtoMember(7)]
        public List<WebsocketRouteParam> SocketParams { get; set; } = new List<WebsocketRouteParam>();

        [ProtoMember(8)]
        public int HeartBeatDuration { get; set; }

        [ProtoMember(9)]
        public bool NeedsAck { get; set; }

        [ProtoMember(10)]
        [DefaultValue("")]
        public string SocketUrl { get; set; } = "";
    }

    /// <summary>
    /// Server-Message. Binary will deserialize into specific message
    /// </summary>
    [ProtoContract]
    public partial class Message : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Type { get; set; } = "";

        [ProtoMember(2)]
        public byte[] Binary { get; set; }
    }

    [ProtoContract]
    public partial class WebsocketRouteParam : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string Name { get; set; } = "";

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Value { get; set; } = "";
    }
}
