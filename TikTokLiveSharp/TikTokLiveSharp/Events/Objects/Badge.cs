using System.Collections.Generic;
using System.Linq;

namespace TikTokLiveSharp.Events.MessageData.Objects
{
    public sealed class Badge
    {
        // Typically either Text, Image or Combo-data is populated, but only one at a time.
        public readonly IReadOnlyList<TextBadge> TextBadges;
        public readonly IReadOnlyList<ImageBadge> ImageBadges;
        public readonly ComboBadge ComboBadges;

        internal Badge(Models.Protobuf.Objects.Badge badge)
        {
            TextBadges = badge?.TextBadges == null ? null : new List<TextBadge>(badge.TextBadges.Select(b => new TextBadge(b.Type, b.Name)));
            ImageBadges = badge?.ImageBadges == null ? null : new List<ImageBadge>(badge.ImageBadges.Select(b => new ImageBadge(b.DisplayType, new Picture(b.Image))));
            ComboBadges = badge?.ComplexBadge == null ? null : new ComboBadge(new Picture(new List<string> { badge.ComplexBadge.ImageUrl }), badge.ComplexBadge.Data);
        }
    }

    public sealed class TextBadge
    {
        public readonly string Type;
        public readonly string Name;

        internal TextBadge(string type, string name)
        {
            Type = type;
            Name = name;
        }
    }

    public sealed class ImageBadge
    {
        public readonly uint DisplayType;
        public readonly Picture Image;

        internal ImageBadge(uint displayType, Picture image)
        {
            DisplayType = displayType;
            Image = image;
        }
    }

    public sealed class ComboBadge
    {
        public readonly Picture Image;
        public readonly string Data;

        internal ComboBadge(Picture image, string data)
        {
            Image = image;
            Data = data;
        }
    }
}
