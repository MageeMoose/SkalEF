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
    public class ClientDb
    {
        private ClientContext _context { get; set; }
        

        public ClientDb(ClientContext context)
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
            var client = await _context.Clients.FirstOrDefaultAsync(x => x.ClientId == model.ClientId);

            _context.Clients.Remove(client);

            await _context.SaveChangesAsync();
        }

        public async Task AddClient(ClientModel model)
        {
            var client = new Client(model) {CreatedOn = DateTime.Now};
            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();

            await _context.AddRangeAsync(await AddClientItems(client, model.ClientItems));
            await _context.SaveChangesAsync();
        }

        public async Task<List<ClientItem>> AddClientItems(Client client, List<ClientItemModel> models)
        {
            var clientItems = new List<ClientItem>();
            var items = await _context.Items.ToListAsync();

            foreach (var clientItemModel in models.Where(x => x.ItemCount > 0))
            {
                var item = items.FirstOrDefault(x => x.ItemId == clientItemModel.ItemId);

                if (item == null)
                    throw new ArgumentException($"The is no item {clientItemModel.ItemId}");

                clientItems.Add(new ClientItem(client.ClientId, item.ItemId, clientItemModel));
            }

            return clientItems;
        }

 
        public async Task EditClient(ClientModel model)
        {
            if (model.ClientId == null)
                throw new Exception($"The client ID is null");

            var items = await _context.Items.ToListAsync();

            // Get current client from DB
            var client = await _context.Clients.Include(x => x.ClientItems).FirstOrDefaultAsync(x => x.ClientId == model.ClientId);

            
          // Create a new client using the models values
            // Set the new client ID to match the current ID
            var newClient = new Client(model) {ClientId = client.ClientId, UpdatedOn = DateTime.Now};
            

            // Update the entity with the new values
            _context.Entry(client).CurrentValues.SetValues(newClient);
            
            newClient.ClientItems = model.ClientItems.Select(x => new ClientItem(x.ClientId.Value, x.ItemId, x)).ToList();
            // Save the changes
            await _context.SaveChangesAsync();
        }

        public async Task<ClientModel> GetClient(int id)
        {
            var client = await _context.Clients
                .Include(x => x.ClientItems)
                .ThenInclude(x => x.Item)
                .FirstOrDefaultAsync(x => x.ClientId == id);
            
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
