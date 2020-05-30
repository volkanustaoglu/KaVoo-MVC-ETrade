using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KaVoo.Entity;
using KaVoo.Models;

namespace KaVoo.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Psikologs
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new PsikologModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Info1 = i.Info1,
                    Info2 = i.Info2,
                    Info3 = i.Info3,
                    Info4 = i.Info4,
                    Info5 = i.Info5,
                    Info6 = i.Info6,
                    Info7 = i.Info7,
                    Info8 = i.Info8,
                    Info9 = i.Info9,
                    Info10 = i.Info10,

                    
                  

                    
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId
                }).ToList();

            return View(urunler);
        }

        public ActionResult Details(int id)
        {
            return View(_context.Psikologs.Where(i => i.Id == id).FirstOrDefault());
        }

        public ActionResult List(int? id)
        {
            var urunler = _context.Psikologs
                .Where(i => i.IsApproved)
                .Select(i => new PsikologModel()
                {
                    Id = i.Id,
                    Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "..." : i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Info1 = i.Info1,
                    Info2 = i.Info2,
                    Info3 = i.Info3,
                    Info4 = i.Info4,
                    Info5 = i.Info5,
                    Info6 = i.Info6,
                    Info7 = i.Info7,
                    Info8 = i.Info8,
                    Info9 = i.Info9,
                    Info10 = i.Info10,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image ?? "1.jpg",
                    CategoryId = i.CategoryId
                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
       
    }
}