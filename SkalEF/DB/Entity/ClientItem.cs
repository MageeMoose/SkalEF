using SkalEF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkalEF.DB.Entity
{
    [Table("ClientItem")]
    public class ClientItem
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int ItemCount { get; set; }
        public DateTime ItemOutDate { get; set; }
        public DateTime? ItemInDate { get; set; }
       
        public ClientItem() { }

        public ClientItem(int clientId, int itemId, ClientItemModel model)
        {
            ClientId = clientId;
            ItemId = itemId;
            ItemCount = model.ItemCount;
            ItemInDate = model.ItemInDate;
            ItemOutDate = model.ItemOutDate;
        }
    }

}