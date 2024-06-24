using ProtoBuf;

namespace TikTokLiveSharp.Models.Protobuf
{
    public abstract class AProtoBase : IExtensible
    {
        public IExtension _extension;

        public IExtension GetExtensionObject(bool createIfMissing) => Extensible.GetExtensionObject(ref _extension, createIfMissing);
    }
}
