using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SkalEF.DB.Entity;

namespace SkalEF.Models
{
    public class AddEditViewModel
    {
        public ClientModel ClientModel { get; set; }
        public List<ItemModel> Items { get; set; }

        public ClientItemModel ClientItemModel { get; set; }
    }
}