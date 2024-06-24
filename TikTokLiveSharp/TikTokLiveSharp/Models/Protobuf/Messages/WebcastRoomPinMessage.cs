using ProtoBuf;
using System.Collections.Generic;
using System.ComponentModel;
using TikTokLiveSharp.Models.Protobuf.Messages.Headers;
using TikTokLiveSharp.Models.Protobuf.Objects;
using TikTokLiveSharp.Models.Protobuf.Objects.DataObjects;

namespace TikTokLiveSharp.Models.Protobuf.Messages
{
    /// <summary>
    /// Host Pins comment to stream
    /// </summary>
    [ProtoContract]
    public partial class WebcastRoomPinMessage : AProtoBase
    {
        [ProtoMember(1)]
        public MessageHeader Header { get; set; }

        [ProtoMember(2)]
        public RoomPinMessageData PinData1 { get; set; }

        [ProtoMember(30)]
        [DefaultValue("")]
        public string OriginalMsgType { get; set; } = "";

        [ProtoMember(31)]
        public ulong Timestamp { get; set; }

        [ProtoMember(32)]
        public RoomPinMessageData2 PinData2 { get; set; }

        [ProtoMember(33)]
        public uint Data1 { get; set; }

        [ProtoMember(34)]
        public int Data2 { get; set; }

        [ProtoMember(35)]
        public ulong Data3 { get; set; }
    }

    /// <summary>
    /// Looks a lot like WebcastChatMessage, but with different Header
    /// </summary>
    [ProtoContract]
    public partial class RoomPinMessageData : AProtoBase
    {
        [ProtoMember(1)]
        public RoomPinMessageDataDetails Details { get; set; }

        /// <summary>
        /// User who sent message
        /// </summary>
        [ProtoMember(2)]
        public User Sender { get; set; }

        /// <summary>
        /// Text for Chat-Message
        /// </summary>
        [ProtoMember(3)]
        [DefaultValue("")]
        public string Comment { get; set; } = "";

        /// <summary>
        /// Users Mentioned in Comment
        /// </summary>
        [ProtoMember(12)]
        public List<User> MentionedUsers { get; set; } = new List<User>();

        /// <summary>
        /// Language for sender
        /// </summary>
        [ProtoMember(14)]
        [DefaultValue("")]
        public string Language { get; set; } = "";

        [ProtoMember(18)]
        public DataContainer ChatData { get; set; }

        [ProtoMember(19)]
        public List<ModerationData> ModerationData { get; set; } = new List<ModerationData>();
    }

    /// <summary>
    /// Basically a RoomPinMessageHeader
    /// </summary>
    [ProtoContract]
    public partial class RoomPinMessageDataDetails : AProtoBase
    {
        [ProtoMember(1)]
        [DefaultValue("")]
        public string MessageType { get; set; } = "";

        [ProtoMember(2)]
        public ulong MessageId { get; set; }

        [ProtoMember(3)]
        public ulong RoomId { get; set; }

        [ProtoMember(4)]
        public ulong ServerTime { get; set; }

        [ProtoMember(6)]
        public ulong Data1 { get; set; }

        [ProtoMember(8)]
        public PinMessageStringContainer Data2 { get; set; }

        [ProtoMember(9)]
        public ulong Data3 { get; set; }

        [ProtoMember(10)]
        public ulong Data4 { get; set; }

        [ProtoMember(11)]
        public ulong Data5 { get; set; }

        // Example: 'useast2a'
        [ProtoMember(15)]
        [DefaultValue("")]
        public string ServerDescription { get; set; } = "";

        [ProtoMember(21)]
        public ulong Data6 { get; set; }

        [ProtoMember(22)]
        public ulong Data7 { get; set; }

        [ProtoMember(23)]
        public ulong Data8 { get; set; }

        [ProtoMember(24)]
        public ulong Data9 { get; set; }

        // Some kind of Timestamp?
        [ProtoMember(25)]
        public ulong Data10 { get; set; }
    }

    [ProtoContract]
    public partial class PinMessageStringContainer : AProtoBase
    {
        [ProtoMember(3)]
        [DefaultValue("")]
        public string Data { get; set; } = "";
    }

    [ProtoContract]
    public partial class RoomPinMessageData2 : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Id { get; set; }

        [ProtoMember(32)]
        public RoomPinMessageData2Details Details { get; set; }
    }

    [ProtoContract]
    public partial class RoomPinMessageData2Details : AProtoBase
    {
        [ProtoMember(2)]
        public uint Data { get; set; }
    }
}
