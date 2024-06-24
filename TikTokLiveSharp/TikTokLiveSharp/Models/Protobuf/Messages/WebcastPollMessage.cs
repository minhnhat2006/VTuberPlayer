using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastPollMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(3)]
        public ulong Id { get; set; }

        [ProtoMember(4)]
        public PollMessageData PollData { get; set; }

        [ProtoMember(5)]
        public PollMessageOptionsContainer Options1 { get; set; }

        [ProtoMember(6)]
        public PollMessageOptionsContainer Options2 { get; set; }
    }


    [ProtoContract]
    public partial class PollMessageData : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Timestamp1 { get; set; }

        [ProtoMember(2)]
        public ulong Timestamp2 { get; set; }

        [ProtoMember(3)]
        public List<PollMessageOption> Options { get; set; }

        [ProtoMember(5)]
        public User User { get; set; }
    }

    [ProtoContract]
    public partial class PollMessageOptionsContainer : AProtoBase
    {
        [ProtoMember(2)]
        public List<PollMessageOption> Options { get; set; } = new List<PollMessageOption>();

        [ProtoMember(3)]
        public User User { get; set; }
    }



    [ProtoContract]
    public partial class PollMessageOption : AProtoBase
    {
        [ProtoMember(1)]
        public uint CurrentTotal { get; set; }

        [ProtoMember(2)]
        [DefaultValue("")]
        public string Label { get; set; } = "";

        [ProtoMember(3)]
        public uint Data1 { get; set; }
    }
}
