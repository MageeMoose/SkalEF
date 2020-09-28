using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkalEF.Models
{
    public class Client
    {   
        [Key]
        public int ClientID { get; set; }
        [Required]

        [DisplayName("Rum")]
        public int Room { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(250)")]
        [DisplayName("Förnamn")]
        public string FirNamn { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Efternamn")]
        public string LasName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Språk")]
        public string Lang { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Avdelning")]
        public string Section { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Kost")]
        public string Food { get; set; }

        [Required]
        [DisplayName("Doss Nr")]
        public int Dossnr { get; set; }
        [DisplayName("Strumpor")]
        public bool Socks { get; set; }
        [DisplayName("Tofflor")]
        public bool Slippers { get; set; }
        [DisplayName("Underkläder")]
        public bool Underware { get; set; }
        [DisplayName("Mobil")]
        public bool Mobil { get; set; }
        [DisplayName("Hörlurar")]
        public bool Headphones { get; set; }
        [DisplayName("Byxor")]
        public bool Trouser { get; set; }




    }
}
