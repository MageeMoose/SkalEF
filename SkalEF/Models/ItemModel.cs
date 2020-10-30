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
}
