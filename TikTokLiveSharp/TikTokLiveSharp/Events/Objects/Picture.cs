using System.Collections.Generic;

namespace TikTokLiveSharp.Events.MessageData.Objects
{
    public sealed class Picture
    {
        public readonly IReadOnlyList<string> URLs;

        internal Picture(Models.Protobuf.Objects.Picture profilePicture)
        {
            URLs = profilePicture?.Urls ?? new List<string>(0);
        }

        public Picture(List<string> urls)
        {
            URLs = urls;
        }
    }
}
