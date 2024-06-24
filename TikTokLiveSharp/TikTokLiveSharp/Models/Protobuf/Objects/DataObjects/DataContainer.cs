using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf.Objects.DataObjects
{
    [ProtoContract]
    public partial class DataContainer : AProtoBase
    {
        [ProtoMember(1)]
        public ulong Data1 { get; set; }

        [ProtoMember(2)]
        public uint Data2 { get; set; }

        [ProtoMember(3)]
        public uint Data3 { get; set; }

        [ProtoMember(4)]
        public uint Data4 { get; set; }

        [ProtoMember(5)]
        public uint Data5 { get; set; }

        [ProtoMember(6)]
        public uint Data6 { get; set; }

        [ProtoMember(7)]
        public uint Data7 { get; set; }

        [ProtoMember(8)]
        public uint Data8 { get; set; }

        [ProtoMember(9)]
        public uint Data9 { get; set; }
    }
}
