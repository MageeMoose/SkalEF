using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SkalEF.Models;

namespace SkalEF.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ClientContex _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ClientsController(ClientContex context, IWebHostEnvironment hostEnvironment )
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clients.ToListAsync());
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .FirstOrDefaultAsync(m => m.ClientID == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult AddOrEdit(int id)
        {

            if (id == 0)
                return View(new Client());
            else
                
            return View(_context.Clients.Find(id));
        }

        // POST: Clients/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("ClientID,Room,FirNamn,LasName,Lang,Section,Food,Dossnr,Socks,Slippers,Underware,Mobil,Headphones,Trouser,ImageFile,ImgName,AmountSocks,AmountTrousers,AmountUnderware,AmountHeadphones,AmountMobile,AmountSlippers,CaseOfficer,Date,,SocksGiveDate,SocksRetrunDate,TrouserGiveDate,TrouserReturnDate,UnderwareGiveDate,UnderwareReturn,Date,HeadphoneGiveDate,MobileGiveDate,MobileReturnDate,SlippersGiveDate,SlippersRetrunDate")] Client client)
        {
            if (ModelState.IsValid)
            {
                string defaultImage = "terry.jpg";
               
             //check if the user is updating or adding a client
                //Client exist
                if (client.ClientID!=0)
                {
                  // Checking if the user has uploaded an image or not 
                    //If no image has been picked and ther is no priveous image, use the default image 
                    if (client.ImageFile == null && client.ImgName == null)
                    {
                        client.ImgName = defaultImage;
                    } // If the user has picked an image, create a uniqe filename and add the name to the DB
                    else if (client.ImageFile != null)
                    {
                        //Save profileimage to wwwRoot/img
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
                    else
                    {
                        // If the client already has an image

                        // set the date when the client profile was last updated
                        client.Date = DateTime.Now;

                        // Set the date when the client recived Items after the initial meeting
                        if (client.Headphones == true & client.HeadphoneGiveDate == null)
                        {
                            client.HeadphoneGiveDate = DateTime.Now;
                        }

                        if (client.Mobil == true & client.MobileGiveDate == null)
                        {
                            client.MobileGiveDate = DateTime.Now;
                        }

                        if (client.Socks == true & client.SocksGiveDate == null)
                        {
                            client.SocksGiveDate = DateTime.Now;
                        }

                        if (client.Trouser == true & client.TrouserGiveDate == null)
                        {
                            client.TrouserGiveDate = DateTime.Now;
                        }

                        if (client.Slippers == true & client.SlippersGiveDate == null)
                        {
                            client.SlippersGiveDate = DateTime.Now;
                        }

                        if (client.Underware == true & client.UnderwareGiveDate == null)
                        {
                            client.UnderwareGiveDate = DateTime.Now;
                        }

                        _context.Update(client);
                       
                        await _context.SaveChangesAsync();

                        return RedirectToAction(nameof(Index));

                    }
                }
                else
                {
                    // 
                    if(client.ImageFile==null)
                    {
                        client.ImgName = defaultImage;
                    }
                    else
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
                    // Set the date when the client recived Items
                    if (client.Headphones == true)
                    {
                        client.HeadphoneGiveDate = DateTime.Now;
                    }

                    if (client.Mobil == true)
                    {
                        client.MobileGiveDate = DateTime.Now;
                    }

                    if (client.Socks == true)
                    {
                        client.SocksGiveDate = DateTime.Now;
                    }

                    if (client.Trouser == true)
                    {
                        client.TrouserGiveDate = DateTime.Now;
                    }

                    if (client.Slippers == true)
                    {
                        client.SlippersGiveDate = DateTime.Now;
                    }

                    if (client.Underware == true)
                    {
                        client.UnderwareGiveDate = DateTime.Now;
                    }

                    client.Date = DateTime.Now;
                    _context.Add(client);
                    

                }

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

    
      

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients
                .FirstOrDefaultAsync(m => m.ClientID == id);
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


            var client = await _context.Clients.FindAsync(id);
            
            // Delete image from folder
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "img", client.ImgName);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            // Delete the client info
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.ClientID == id);
        }

        public async Task<IActionResult> HeadCount()
        {
            return View(await _context.Clients.ToListAsync());
        }

        
    }
}
