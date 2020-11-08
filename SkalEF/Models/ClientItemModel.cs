using System;
using SkalEF.DB.Entity;

namespace SkalEF.Models
{
    public class ClientItemModel
    {
        public int? ClientId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemCount { get; set; }
        public DateTime ItemOutDate { get; set; }
        public DateTime? ItemInDate { get; set; }

        public ClientItemModel() { }

        public ClientItemModel(ItemModel item)
        {
            ItemId = item.ItemId;
            ItemName = item.ItemName;
        }

        public ClientItemModel(ClientItem clientItem)
        {
            ClientId = clientItem.Client.ClientId;
            ItemId = clientItem.Item.ItemId;
            ItemName = clientItem.Item.ItemName;
            ItemCount = clientItem.ItemCount;
            ItemOutDate = clientItem.ItemOutDate;
            ItemInDate = clientItem.ItemInDate;
        }
    }
}