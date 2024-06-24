using ProtoBuf;
using System.ComponentModel;

namespace TikTokLiveSharp.Models.Protobuf.Messages.Generic
{
    /// <summary>
    /// Acknowledgement-Message for Websocket-Connection
    /// </summary>
    [ProtoContract]
    public partial class WebcastWebsocketAck : AProtoBase
    {
        [ProtoMember(2)]
        public ulong Id { get; set; }

        [ProtoMember(7)]
        [DefaultValue("")]
        public string Type { get; set; } = "";
    }
}
