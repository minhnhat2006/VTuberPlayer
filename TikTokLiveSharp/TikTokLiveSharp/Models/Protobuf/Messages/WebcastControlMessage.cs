using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// System-Control Message from Room (e.g. Host ended Stream)
    /// </summary>
    [ProtoContract]
    public partial class WebcastControlMessage : AProtoBase
    {
        [ProtoContract]
        [System.Serializable]
        public enum ControlAction
        {
            Unknown = 0,
            /// <summary>
            /// Stream Paused by Host
            /// </summary>
            Stream_Paused = 1,
            /// <summary>
            /// Stream Ended by Host
            /// </summary>
            Stream_Ended = 3
        };

        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public ControlAction Action { get; set; } = ControlAction.Unknown;

        [ProtoMember(4)]
        public ControlDetails Details { get; set; }
    }

    [ProtoContract]
    public partial class ControlDetails : AProtoBase
    {
        [ProtoMember(8)]
        [DefaultValue("")]
        public string Type { get; set; } = "";
    }
}
