using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Panse.Data;
using Panse.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Panse.Controllers
{
    public class HomeController : Controller
    {
        public readonly PanseDbContext db;

        public HomeController(PanseDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index(int? Id)
        {
            IEnumerable<Jewelry> Obj= db.Rings;
            if(Id== 1)
            {
                Obj = db.Necklaces;
            }
            return View(Obj);
        }
        //public IActionResult Ring()
        //{
        //    IEnumerable<Ring> rings = db.Rings;
        //    return View(rings);
        //}

        //public IActionResult Necklace()
        //{
        //    IEnumerable<Necklace> necklaces= db.Necklaces;
        //    return View(necklaces);
        //}
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
