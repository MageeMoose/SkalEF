using System;
using System.Collections.Generic;
using System.Linq;
using SkalEF.DB.Entity;

namespace SkalEF.Models
{
    public class ClientItemModel
    {
        public int? ClientId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemCount { get; set; }

        public ClientItemModel() { }

        public ClientItemModel(ItemModel item)
        {
            ItemId = item.ItemId;
            ItemName = item.ItemName;
        }

        public ClientItemModel(IReadOnlyCollection<RentedItem> rentedItems)
        {
            var first = rentedItems.FirstOrDefault();

            if (first == null)
                return;
            
            ClientId = first.Client.ClientId;
            ItemId = first.Item.ItemId;
            ItemName = first.Item.ItemName;
            ItemCount = rentedItems.Count;
        }
    }
}