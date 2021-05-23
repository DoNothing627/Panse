using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panse.Data;
using Panse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panse.Controllers
{
    public class ManagerController : Controller
    {
        public readonly PanseDbContext db;

        public ManagerController(PanseDbContext _db)
        {
            db = _db;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Necklace()
        {
            IEnumerable<Necklace> Obj = db.Necklaces;
            return View(Obj);
        }

        public IActionResult CreateNecklace()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateNecklace(Necklace Obj)
        {
            if (Obj == null) return NotFound();
            db.Necklaces.Add(Obj);
            db.SaveChanges();
            return Redirect("Necklace");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateNecklace(Necklace Obj)
        {
            if (Obj == null) return NotFound();
            db.Necklaces.Update(Obj);
            db.SaveChanges();
            return RedirectToAction("Necklace");
        }
        public IActionResult UpdateNecklace(int? Id)
        {

            var Obj = db.Necklaces.Find(Id);
            if (Obj == null)
                return NotFound();
            return View(Obj);
        }
        public IActionResult DeleteNecklace(int? Id)
        {
            var Obj = db.Necklaces.Find(Id);
            if (Obj == null)
                return NotFound();
            db.Necklaces.Remove(Obj);
            db.SaveChanges();
            return RedirectToAction("Necklace");
        }

        public IActionResult Ring()
        {
            IEnumerable<Ring> Obj = db.Rings;
            return View(Obj);
        }

        public IActionResult CreateRing()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRing(Ring Obj)
        {
            if (Obj == null) return NotFound();
            db.Rings.Add(Obj);
            db.SaveChanges();
            return Redirect("Ring");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateRing(Ring Obj)
        {
            if (Obj == null) return NotFound();
            db.Rings.Update(Obj);
            db.SaveChanges();
            return RedirectToAction("Ring");
        }
        public IActionResult UpdateRing(int? Id)
        {

            var Obj = db.Rings.Find(Id);
            if (Obj == null)
                return NotFound();
            return View(Obj);
        }
        public IActionResult DeleteRing(int? Id)
        {
            var Obj= db.Rings.Find(Id);
            if (Obj == null)
                return NotFound();
            db.Rings.Remove(Obj);
            db.SaveChanges();
            return RedirectToAction("Ring");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckPass(RePassword password)
        {

            var Obj = db.RePasswords.Find(password.pass);
            if (Obj == null) return NotFound();
            return RedirectToAction("Ring");
        }
    }
}
