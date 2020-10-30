using System;
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

        public ClientItemModel(ClientItem item)
        {
            ClientID = item.ClientID;
            ItemID = item.ItemID;    
            ItemName = item.Item.ItemName;
            ItemCount = item.ItemCount;
            ItemOutDate = item.ItemOutDate;
            ItemInDate = item.ItemInDate;
        }
    }
}