using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkalEF.DB.Entity;

namespace SkalEF.Models
{
    public class ItemModel
    {
        public string ItemName { get; set; }

        public int ItemCount { get; set; }
        public DateTime ItemOutDate { get; set; }
        public DateTime? ItemInDate { get; set; }

        public ItemModel()
        {
                
        }

        public ItemModel(ClientItem item)
        {
            ItemName = item.Item.ItemName;
            ItemCount = item.ItemCount;
            ItemOutDate = item.ItemOutDate;
            ItemInDate = item.ItemInDate;
        }
    }

    
}
