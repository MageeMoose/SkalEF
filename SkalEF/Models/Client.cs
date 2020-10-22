using Microsoft.AspNetCore.Http;
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
        [Column(TypeName = "nvarchar(8)")]
        public string Room { get; set; }

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
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Doss Nr")]
        public string Dossnr { get; set; }
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
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Foto")]
        public string ImgName { get; set; }
        [NotMapped]
        [DisplayName("Ladda upp foto")]
        public IFormFile ImageFile { get; set; }

        [Required]
        public int AmountSocks { get; set; }
        [Required]
        public int AmountTrousers { get; set; }
        [Required]
        public int AmountUnderware { get; set; }
        [Required]
        public int AmountHeadphones { get; set; }
        [Required]
        public int AmountMobile { get; set; }
        [Required]
        public int AmountSlippers { get; set; }
        [Required]
        public int AmountSocksReturned { get; set; }
        [Required]
        public int AmountTrousersReturned { get; set; }
        [Required]
        public int AmountUnderwareReturned { get; set; }
        [Required]
        public int AmountHeadphonesReturned { get; set; }
        [Required]
        public int AmountMobileReturned { get; set; }
        [Required]
        public int AmountSlippersReturned { get; set; }

        [Required]
        [DisplayName("Ansvarig Personal")]
        public string CaseOfficer { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:yyyy-MM-dd}")]
        [DisplayName("Datum")]
        public DateTime? Date { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? SocksGiveDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime? SocksRetrunDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? TrouserGiveDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? TrouserReturnDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? UnderwareGiveDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? UnderwareReturnDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? HeadphoneGiveDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? HeadphoneRetrunDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? MobileGiveDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? MobileReturnDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? SlippersGiveDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? SlippersRetrunDate { get; set; }










    }
}
