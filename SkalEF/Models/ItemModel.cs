using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkalEF.DB.Entity;

namespace SkalEF.Models
{
    public class ItemModel
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }

        public ItemModel()
        {

        }

        public ItemModel(Item item)
        {
            ItemID = item.ItemID;
            ItemName = item.ItemName;
        }
    }

    public class ClientItemModel
    {
        public string ItemName { get; set; }

        public int ItemCount { get; set; }
        public DateTime ItemOutDate { get; set; }
        public DateTime? ItemInDate { get; set; }

        public ClientItemModel()
        {
                
        }

        public ClientItemModel(ClientItem item)
        {
            ItemName = item.Item.ItemName;
            ItemCount = item.ItemCount;
            ItemOutDate = item.ItemOutDate;
            ItemInDate = item.ItemInDate;
        }
    }

    
}
