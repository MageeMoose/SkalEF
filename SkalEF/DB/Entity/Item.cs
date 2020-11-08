using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkalEF.DB.Entity
{
    [Table("Item")]
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        public ICollection<ClientItem> ClientItems { get; set; }
    }
}