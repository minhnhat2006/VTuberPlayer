using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastQuestionNewMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public QuestionDetails Details { get; set; }
    }


    [ProtoContract]
    public partial class QuestionDetails : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Id { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Text { get; set; } = "";

        [ProtoMember(4)]
        public ulong Timestamp { get; set; }

        [ProtoMember(5)]
        public User User { get; set; }

        [ProtoMember(20)]
        public uint Data1 { get; set; }
    }
}
