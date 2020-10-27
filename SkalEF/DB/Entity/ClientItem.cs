using SkalEF.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkalEF.DB.Entity
{
    [Table("ClientItem")]
    public class ClientItem
    {
        [Key]
        public int ClientID { get; set; }
        [Key]
        public int ItemID { get; set; }
        public Client Client { get; set; }
        public Item Item { get; set; }
        public int ItemCount { get; set; }
        public DateTime ItemOutDate { get; set; }
        public DateTime? ItemInDate { get; set; }

        public ClientItem()
        {

        }

        public ClientItem(ClientItemModel model)
        {
            Item.ItemName = model.ItemName;
            ItemCount = model.ItemCount;
            ItemInDate = model.ItemInDate;
            ItemOutDate = model.ItemOutDate;
        }
    }

}