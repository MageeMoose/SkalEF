using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using SkalEF.DB;
using SkalEF.DB.Entity;
using SkalEF.Models;

namespace SkalEF.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly ClientDB _clientDb;


        public ClientsController(IWebHostEnvironment hostEnvironment, ClientDB clientDB)
        {
            _hostEnvironment = hostEnvironment;
            _clientDb = clientDB;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            return View(await _clientDb.GetAllClients());
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var client = await _clientDb.GetClient(id.Value);

            if (client == null)
                return NotFound();

            return View(client);
        }

        // GET: Clients/Create
        public async Task<IActionResult> AddOrEdit(int? id)
        {
            ClientModel model = null;

            if (id == null)
            {
                var items = await _clientDb.GetAllItems();

                model = new ClientModel
                {
                    Items = items.Select(x => new ClientItemModel
                    {
                        ItemID = x.ItemID,
                        ItemName = x.ItemName
                    }).ToList()
                };
            }
            else
            {
                model = await _clientDb.GetClient(id.Value);
            }

            return View(new AddEditViewModel
            {
                ClientModel = model
            });
        }

        // POST: Clients/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(AddEditViewModel vm)
        {
            var client = vm.ClientModel;

            if (ModelState.IsValid)
            { 
                //check if the user is updating or adding a client
                //Client exist
                if (client.ClientID != null)
                {
                  // Checking if the user has uploaded an image or not 
                    //If no image has been picked and ther is no priveous image, use the default image 
                    if (client.ImageFile == null && client.ImgName == null)
                    {
                        client.ImgName = "defaultImage.jpg";

                        await _clientDb.EditClient(client);
                        return RedirectToAction(nameof(Index));
                    }
                    else if (client.ImageFile != null)
                    {
                        // If the user has picked an image, create a uniqe filename and add the name to the DB
                        //Save profileimage to wwwRoot/img
                        await SaveImageToDB(client);
                        //Update client
                        await _clientDb.EditClient(client); 
                    }
                    else
                    {
                        // If the client already has an image
                        // Set the date when the client recived Items after the initial meeting


                        await _clientDb.EditClient(client);

                        return RedirectToAction(nameof(Index));
                    }
                }
                else
                {
                    if(client.ImageFile ==null)
                    {
                        client.ImgName = "defaultImage.jpg";
                    }
                    else
                    {
                        await SaveImageToDB(client);
                    }
                    // Set the date when the client recived Items

                    await _clientDb.AddClient(client);
                    
                    return RedirectToAction(nameof(Index));
                } 
           
            }

            return View(vm);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _clientDb.GetClient(id.Value);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _clientDb.GetClient(id);

            if (client.ImgName != "defaultImage.jpg")
            {
                var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "img", client.ImgName);
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);
            }
            // Delete the client info
            await _clientDb.DeleteClient(client);

            return RedirectToAction(nameof(Index));
        }

        //private bool ClientExists(int id)
        //{
        //    return _context.Clients.Any(e => e.ClientID == id);
        //}

        public async Task SaveImageToDB(ClientModel client)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(client.ImageFile.FileName);
            string extension = Path.GetExtension(client.ImageFile.FileName);
            client.ImgName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine(wwwRootPath + "/img/", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await client.ImageFile.CopyToAsync(fileStream);
            }
        }
        public async Task<IActionResult> HeadCount()
        {
            return View(await _clientDb.GetAllClients());
        }

        
    }
}
