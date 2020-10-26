using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SkalEF.Enums
{
    public enum Items
    {
        Strumpor,
        Mobil,
        Hörlurar,
        Undedrkläder,
        Byxor,
        Tofflor,
        [Display(Name = "T-Shirt")]
        Tshirt
    }
}
