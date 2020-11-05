using SkalEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using SkalEF.Enums;
using SkalEF.DB.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace SkalEF.DB
{
    public class ClientDB
    {
        private ClientContext _context { get; set; }
        

        public ClientDB(ClientContext context)
        {
            _context = context;
        }

        public async Task Create()
        {
            await _context.Database.EnsureCreatedAsync();

            await AddItems();
        }

        public async Task AddItems()
        {
            var items = Enum.GetNames(typeof(Items));

            foreach (var itemName in items)
            {
                var item = await _context.Items.FirstOrDefaultAsync(x => x.ItemName == itemName);

                if (item == null)
                {
                    await _context.Items.AddAsync(new Item { ItemName = itemName });
                }
            }

            await _context.SaveChangesAsync();
        }

        public async Task DeleteClient(ClientModel model)
        {
            var client = await _context.Clients.FirstOrDefaultAsync(x => x.ClientID == model.ClientID);

            _context.Clients.Remove(client);

            await _context.SaveChangesAsync();
        }

      
       
        public async Task AddClient(ClientModel model)
        {
            var items = model.Items;
            var client = new Client(model, items);
            
            client.CreatedOn = DateTime.Now;
            
            await _context.Clients.AddAsync(client);
           
            await _context.SaveChangesAsync();
        }

        public async Task EditClient(ClientModel model)
        {
            if (model.ClientID == null)
                throw new Exception($"The client ID is null");

            // Get current client from DB
            var client = await _context.Clients.FirstOrDefaultAsync(x => x.ClientID == model.ClientID);
            
            // Create a new client using the models values
            var newClient = new Client(model);

            // Set the new client ID to match the current ID
            newClient.ClientID = client.ClientID;

            newClient.UpdatedOn = DateTime.Now;

            client.UpdatedOn = newClient.UpdatedOn;

            // Update the entity with the new values
            _context.Entry(client).CurrentValues.SetValues(newClient);
            
            // Save the changes
            await _context.SaveChangesAsync();
        }

        public async Task<ClientModel> GetClient(int id)
        {
            var client = await _context.Clients
                .Include(x => x.ClientItems )
                .ThenInclude(x => x.Item)
                .FirstOrDefaultAsync(x => x.ClientID == id);
            
            if (client == null)
                return null;

            return new ClientModel(client);
        }

        public async Task<List<ItemModel>> GetAllItems()
        {
            return await _context.Items.Select(x => new ItemModel(x)).ToListAsync();
        
        }

        public async Task<List<ClientModel>> GetAllClients()
        {
            return await _context.Clients.Select(x => new ClientModel(x)).ToListAsync();
        }
    }
}
