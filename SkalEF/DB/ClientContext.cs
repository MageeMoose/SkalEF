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

        public ClientContext(DbContextOptions<ClientContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentedItem>()
                .HasOne(x => x.Client)
                .WithMany(x => x.RentedItems);

            modelBuilder.Entity<RentedItem>()
                .HasOne(x => x.Item);

            base.OnModelCreating(modelBuilder);
        }
    }
}
