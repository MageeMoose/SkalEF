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
        public async Task<IActionResult> AddOrEdit([Bind("ClientID,Room,FirNamn,LasName,Lang,Section,Food,Dossnr,Socks,Slippers,Underware,Mobil,Headphones,Trouser,ImageFile")] Client client)
        {
            if (ModelState.IsValid)
            {
                string defaultImage = "terry.jpg";
                //Save profileimage to wwwRoot/img
                
                    
                
                //Insert
                if (client.ClientID!=0)
                {
                    if(client.ImageFile == null)
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
                    
                    _context.Update(client);
                }
                else
                {
                    if(client.ImageFile==null)
                    {
                        
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
                   
                    _context.Add(client);
                    

                }

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClientID,Room,FirNamn,LasName,Lang,Section,Food,Dossnr,Socks,Slippers,Underware,Mobil,Headphones,Trouser")] Client client)
        {
            if (id != client.ClientID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.ClientID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
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
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.ClientID == id);
        }
    }
}
