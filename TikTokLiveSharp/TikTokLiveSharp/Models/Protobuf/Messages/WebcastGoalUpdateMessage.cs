using ProtoBuf;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Gift sent by user
    /// </summary>
    [ProtoContract]
    public partial class WebcastGoalUpdateMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public TypeValue Data { get; set; }

        [ProtoMember(3)]
        public GoalUpdateData UpdateData { get; set; }

        [ProtoMember(4)]
        public ulong Id { get; set; }

        [ProtoMember(5)]
        public Picture Picture { get; set; }

        [ProtoMember(6)]
        [DefaultValue("")]
        public string UserId { get; set; }

        [ProtoMember(7)]
        public GoalUpdateDetails Details { get; set; }

        [ProtoMember(9)]
        public uint Data2 { get; set; }

        [ProtoMember(10)]
        public uint Data3 { get; set; }

        [ProtoMember(11)]
        public uint Data4 { get; set; }

        [ProtoMember(12)]
        [DefaultValue("")]
        public string IdString { get; set; }

        [ProtoMember(15)]
        public TimeData TimeData { get; set; }
    }
}
