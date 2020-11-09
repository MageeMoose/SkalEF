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
    public class ClientModel
    {
        public int? ClientId { get; set; }
       
        [Required]
        [DisplayName("Rum")]
        public string Room { get; set; }

        [Required]
        [DisplayName("Förnamn")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Efternamn")]
        public string LastName { get; set; }

        [DisplayName("Språk")]
        public string Lang { get; set; }

        [Required]
        [DisplayName("Avdelning")]
        public string Section { get; set; }

        [DisplayName("Kost")]
        public string FoodChoice { get; set; }

        [Required]
        [DisplayName("Doss Nr")]
        public string DossNr { get; set; }
        
        [DisplayName("Foto")]
        public string ImgName { get; set; }
       
        [NotMapped]
        [DisplayName("Ladda upp foto")]
        public IFormFile ImageFile { get; set; }

        [Required]
        [DisplayName("Ansvarig Personal")]
        public string UpdatedBy { get; set; }

        public List<ClientItemModel> ClientItems { get; set; }

        public ClientModel() { }

        public ClientModel(Client client)
        {
            ClientId = client.ClientId;
            Room = client.Room;
            FirstName = client.FirstName;
            LastName = client.LastName;
            Lang = client.Lang;
            Section = client.Section;
            FoodChoice = client.FoodChoice;
            DossNr = client.DossNr;
            ImgName = client.ImgName;
            UpdatedBy = client.UpdatedBy;
            ClientItems = client.RentedItems?
                .GroupBy(x => x.Item.ItemId)
                .Select(x => new ClientItemModel(x.ToList()))
                .ToList();
        }
    }
}
