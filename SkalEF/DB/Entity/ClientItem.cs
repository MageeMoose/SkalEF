using SkalEF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkalEF.DB.Entity
{
    [Table("RentedItem")]
    public class RentedItem
    {
        [Key]
        public int RentedItemId { get; set; }

        public Client Client { get; set; }
        public Item Item { get; set; }
        public DateTime ItemOutDate { get; set; }
        public DateTime? ItemInDate { get; set; }

        public RentedItem() { }

        public RentedItem(Client client, Item item)
        {
            Client = client;
            Item = item;
            ItemOutDate = DateTime.Now;
        }
    }
}