using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using SkalEF.DB.Entity;
using SkalEF.Models;

namespace SkalEF.DB
{
    public class ClientContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ClientItem> ClientItems { get; set; }

        
        public ClientContext(DbContextOptions<ClientContext>options):base(options)
        {

        }

 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientItem>().HasKey(x => new {x.ClientID, x.ItemID});
            modelBuilder.Entity<ClientItem>().HasOne(x => x.Client).WithMany(x => x.ClientItems);
           
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
