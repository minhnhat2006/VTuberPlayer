using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    [ProtoContract]
    public partial class WebcastLinkMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public uint Data1 { get; set; }

        [ProtoMember(3)]
        public ulong Id { get; set; }

        [ProtoMember(4)]
        public uint Data2 { get; set; }

        [ProtoMember(18)]
        public LinkMessageData Data { get; set; }

        [ProtoMember(20)]
        public LinkMessageUserContainer User { get; set; }

        [ProtoMember(200)]
        [DefaultValue("")]
        public string Token { get; set; } = "";
    }

    [ProtoContract]
    public partial class LinkMessageData : AProtoBase
    {
        /// <summary>
        /// Index 1 is an Id
        /// </summary>
        [ProtoMember(1)]
        public DataContainer Data { get; set; }
    }

    [ProtoContract]
    public partial class LinkMessageUserContainer : AProtoBase
    {
        [ProtoMember(1)]
        public LinkMessageUser User { get; set; }

        [ProtoMember(2)]
        public List<LinkMessageUser> OtherUsers { get; set; } = new List<LinkMessageUser>();
    }

    [ProtoContract]
    public partial class LinkMessageUser : AProtoBase
    {
        [ProtoMember(1)]
        public User User { get; set; }

        [ProtoMember(2)]
        public ulong Timestamp { get; set; }

        [ProtoMember(4)]
        public uint Data1 { get; set; }

        [ProtoMember(5)]
        [DefaultValue("")]
        public string IdString { get; set; } = "";

        [ProtoMember(7)]
        public uint Data2 { get; set; }
    }
}
