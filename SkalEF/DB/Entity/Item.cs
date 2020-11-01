using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkalEF.DB.Entity
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }

        public ICollection<ClientItem> ClientItems { get; set; }

    }
}