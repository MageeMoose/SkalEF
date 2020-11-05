﻿using SkalEF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace SkalEF.DB.Entity
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int? ClientID { get; set; }
        
        [NotNull]
        [Column(TypeName = "nvarchar(8)")]
        public string Room { get; set; }

        [NotNull]
        [Column(TypeName = "nvarchar(250)")]
        public string FirstName { get; set; }

        [NotNull]
        [Column(TypeName = "nvarchar(250)")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Lang { get; set; }

        [NotNull]
        [Column(TypeName = "nvarchar(250)")]
        public string Section { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string FoodChoice { get; set; }

        [NotNull]
        [Column(TypeName = "nvarchar(10)")]
        public string DossNr { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? ImgName { get; set; }
       
        [NotNull]
        public string UpdatedBy { get; set; }
      
        public DateTime UpdatedOn{ get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<ClientItem> ClientItems { get; set; }

        public Client() { }

        public Client(ClientModel model )
        {
            ClientID = model.ClientID;
            Room = model.Room;
            FirstName = model.FirstName;
            LastName = model.LastName;
            Lang = model.Lang;
            Section = model.Section;
            FoodChoice = model.FoodChoice;
            DossNr = model.DossNr;
            ImgName = model.ImgName;
            UpdatedBy = model.UpdatedBy;  

        }
        public Client(ClientModel model, ICollection<ClientItemModel> clientItemModels)
        {
            ClientID = model.ClientID;
            Room = model.Room;
            FirstName = model.FirstName;
            LastName = model.LastName;
            Lang = model.Lang;
            Section = model.Section;
            FoodChoice = model.FoodChoice;
            DossNr = model.DossNr;
            ImgName = model.ImgName;
            UpdatedBy = model.UpdatedBy;
            ClientItems = clientItemModels.Select(x => new ClientItem(x)).ToList();
        }

    }
}
