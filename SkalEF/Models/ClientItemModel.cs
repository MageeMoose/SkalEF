using System;
using System.Collections.Generic;
using SkalEF.DB.Entity;

namespace SkalEF.Models
{
    public class ClientItemModel
    {
        public int? ClientID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemCount { get; set; }
        public DateTime ItemOutDate { get; set; }
        public DateTime? ItemInDate { get; set; }
        

        public ClientItemModel()
        {
                
        }

        public ClientItemModel(ClientItem clientItem)
        {  
            ItemName = clientItem.Item.ItemName;
            ItemCount = clientItem.ItemCount;
            ItemOutDate = clientItem.ItemOutDate;
            ItemInDate = clientItem.ItemInDate;
        }

        public ClientItemModel(ClientItem clientItem, Item item)
        {
            ItemName = item.ItemName;
            ItemCount = clientItem.ItemCount;
            ItemOutDate = clientItem.ItemOutDate;
            ItemInDate = clientItem.ItemInDate;
        }
    }
}