using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkalEF.Models
{
    public class DetailsVewModel
    {
        public ClientModel ClientModel { get; set; }
        public List<ItemModel> Items { get; set; }

        public ClientItemModel ClientItemModel { get; set; }
    }
}
