﻿using System;
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
            #region ViewData
            List<SelectListItem> sectionNumbers = new List<SelectListItem>() {
                new SelectListItem {
                    Text = "Avdeling 1", Value = "Avdelning 1"
                },
                new SelectListItem {
                    Text = "Avdeling 2", Value = "Avdelning 2"
                },
            };
            ViewData["SectionNumbers"] = sectionNumbers;
            #endregion

            #region ViewData
            List<SelectListItem> roomNumbers = new List<SelectListItem>() {
                new SelectListItem {
                    Text = "2073:1", Value = "2073:1"
                },
                new SelectListItem {
                    Text = "2073:2", Value = "2073:2"
                },
                new SelectListItem {
                    Text = "2073:3", Value = "2073:3"
                },
                new SelectListItem {
                    Text = "2073:4", Value = "2073:4"
                },
                new SelectListItem {
                    Text = "2073:5", Value = "2073:5"
                },
                new SelectListItem {
                    Text = "2073:6", Value = "2073:6"
                },
                new SelectListItem {
                    Text = "2077:1", Value = "2077:1"
                },
                new SelectListItem {
                    Text = "2077:2", Value = "2077:2"
                },
                new SelectListItem {
                    Text = "2077:3", Value = "2077:3"
                },
                new SelectListItem {
                    Text = "2077:4", Value = "2077:4"
                },  
                new SelectListItem {
                    Text = "2077:5", Value = "2077:5"
                },
                new SelectListItem {
                    Text = "2077:6", Value = "2077:6"
                },
                new SelectListItem {
                    Text = "2077:7", Value = "2077:7"
                },
                new SelectListItem {
                    Text = "2105:1", Value = "2105:1"
                },
                new SelectListItem {
                    Text = "2105:2", Value = "2105:2"
                },
                new SelectListItem {
                    Text = "2105:3", Value = "2105:3"
                },
                new SelectListItem {
                    Text = "2105:4", Value = "2105:4"
                },
                new SelectListItem {
                    Text = "2105:5", Value = "2105:5"
                },
                new SelectListItem {
                    Text = "2105:6", Value = "2105:6"
                },
                new SelectListItem {
                    Text = "2105:7", Value = "2105:7"
                },
                 new SelectListItem {
                    Text = "2106:1", Value = "2106:1"
                },
                new SelectListItem {
                    Text = "2106:2", Value = "2106:2"
                },
                new SelectListItem {
                    Text = "2106:3", Value = "2106:3"
                },
                new SelectListItem {
                    Text = "2106:4", Value = "2106:4"
                },
                new SelectListItem {
                    Text = "2107:1", Value = "2107:1"
                },
                new SelectListItem {
                    Text = "2107:2", Value = "2107:2"
                },
                new SelectListItem {
                    Text = "2107:3", Value = "2107:3"
                },
                new SelectListItem {
                    Text = "2108:1", Value = "2108:1"
                },
                new SelectListItem {
                    Text = "2108:2", Value = "2108:2"
                },
                new SelectListItem {
                    Text = "2108:3", Value = "2108:3"
                }, 
                new SelectListItem {
                    Text = "2108:4", Value = "2108:4"
                },
                new SelectListItem {
                    Text = "2110:1", Value = "2110:1"
                },
                new SelectListItem {
                    Text = "2110:2", Value = "2110:2"
                },
                new SelectListItem {
                    Text = "2111:1", Value = "2111:1"
                },
                new SelectListItem {
                    Text = "2111:2", Value = "2111:2"
                },
                new SelectListItem {
                    Text = "2111:3", Value = "2111:3"
                },
                new SelectListItem {
                    Text = "2111:4", Value = "2111:4"
                },
                new SelectListItem {
                    Text = "2111:5", Value = "2111:5"
                },
                new SelectListItem {
                    Text = "2111:6", Value = "2111:6"
                },
                new SelectListItem {
                    Text = "2113:1", Value = "2113:1"
                }, 
                new SelectListItem {
                    Text = "2113:2", Value = "2113:2"
                },
                new SelectListItem {
                    Text = "2113:3", Value = "2113:3"
                },
                new SelectListItem {
                    Text = "2113:4", Value = "2113:4"
                },
                new SelectListItem {
                    Text = "2114:1:", Value = "2114:1"
                },
                new SelectListItem {
                    Text = "2114:2",  Value = "2114:2"
                },
                new SelectListItem {
                    Text = "2114:3", Value = "2114:3"
                },
                new SelectListItem {
                    Text = "2114:4", Value = "2114:4"
                },
                new SelectListItem {
                    Text = "2115:1", Value = "2115:1"
                },
                new SelectListItem {
                    Text = "2115:2", Value = "2115:2"
                },
                new SelectListItem {
                    Text = "2115:3", Value = "2115:3"
                }, 
                new SelectListItem {
                    Text = "2115:4", Value = "2115:4"
                },
                new SelectListItem {
                    Text = "2115:5", Value = "2115:5"
                },
                new SelectListItem {
                    Text = "2115:6", Value = "2115:6"
                },
                new SelectListItem {
                    Text = "2115:7", Value = "2115:7"
                },
                new SelectListItem
                {
                    Text = "2115:8", Value = "2115:8"
                },
            };
            ViewData["RoomNumbers"] = roomNumbers;
                #endregion
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
     
                //Insert
                if (client.ClientID!=0)
                {
                    if(client.ImageFile == null && client.ImgName == null)
                    {
                        client.ImgName = defaultImage;
                    }
                    else if (client.ImgName != null)
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
                    
                    _context.Update(client);
                }
                else
                {
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
