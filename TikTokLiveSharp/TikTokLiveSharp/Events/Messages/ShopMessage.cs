using System.Collections.Generic;
using TikTokLiveSharp.Models.Protobuf.Messages;

namespace TikTokLiveSharp.Events.MessageData.Messages
{
    public sealed class ShopMessage : AMessageData
    {
        public readonly string Title;
        public readonly string Price;
        public readonly Objects.Picture Picture;
        public readonly string ShopUrl;
        public readonly string ShopName;

        internal ShopMessage(WebcastOecLiveShoppingMessage msg) 
            : base(msg?.Header?.RoomId ?? 0, msg?.Header?.MessageId ?? 0, msg?.Header?.ServerTime ?? 0)
        {
            var data = msg?.ShopData;
            Title = data?.Title;
            Price = data?.PriceString;
            Picture = new Objects.Picture(new List<string> { data?.ImageUrl });
            ShopUrl = data?.ShopUrl;
            ShopName = data?.ShopName;
        }
    }
}
