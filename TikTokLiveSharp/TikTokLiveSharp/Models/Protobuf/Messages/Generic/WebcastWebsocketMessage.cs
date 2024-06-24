using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Generic
{
    /// <summary>
    /// Websocket-Message as sent by TikTok-Server (outer structure)
    /// </summary>
    [ProtoContract]
    public partial class WebcastWebsocketMessage : AProtoBase
    {
        [ProtoMember(1)]
        public uint Data1 { get; set; }

        [ProtoMember(2)]
        public ulong Id { get; set; }

        [ProtoMember(3)]
        public uint Data2 { get; set; }

        [ProtoMember(4)]
        public uint Data3 { get; set; }

        /// <summary>
        /// CompressionType, ServerTime, etc
        /// </summary>
        [ProtoMember(5)]
        public List<MessageData> ConnectionData { get; set; } = new List<MessageData>();

        /// <summary>
        /// Unknown additional details
        /// </summary>
        [ProtoMember(6)]
        public WebsocketMessageDetails Data4 { get; set; }

        /// <summary>
        /// "hb" for heartbeat, "msg" for messages
        /// </summary>
        [ProtoMember(7)]
        [DefaultValue("")]
        public string Type { get; set; } = "";

        /// <summary>
        /// WebcastResponse as Binary
        /// </summary>
        [ProtoMember(8)]
        public byte[] Binary { get; set; }
    }

    [ProtoContract]
    public partial class MessageData : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string DataType { get; set; } = "";

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Value { get; set; } = "";
    }

    [ProtoContract]
    public partial class WebsocketMessageDetails : AProtoBase
    {
        [ProtoMember(14)]
        public uint Data1 { get; set; }
    }
}
