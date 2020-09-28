using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkalEF.Models
{
    public class ClientContex : DbContext
    {
        public ClientContex(DbContextOptions<ClientContex>options):base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

    }
}
