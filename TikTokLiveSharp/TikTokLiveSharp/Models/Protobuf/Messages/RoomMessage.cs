using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class RoomMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Message { get; set; } = "";

        [ProtoMember(7)]
        public uint Data1 { get; set; }
    }
}
