using System.Collections.Generic;

namespace SkalEF.Models.ViewModels
{
    public class DetailsVewModel
    {
        public ClientModel ClientModel { get; set; }
        public List<ItemModel> Items { get; set; }

        public ClientItemModel ClientItemModel { get; set; }
    }
}
