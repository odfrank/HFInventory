using HFInventApp.Data;
using HFInventApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace HFInventApp.Controllers
{
    //[Authorize(Roles = RoleSD.Role_Admin1)]
    public class BinlookupController : Controller
    {
        private readonly AppDbContext _db;
        public BinlookupController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<BinLookup> dbBinLookups = _db.BinLookups.ToList();
            return View(dbBinLookups);
        }

        // Add-Create BinLookup
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BinLookup obj)
        {
            if (obj != null && ModelState.IsValid)
            {
                _db.BinLookups.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "BinLookup created successfully";
                return RedirectToAction("Index", "Binlookup");
            }

            return View();
        }

        //Edit BinLookup
        [Authorize(Roles = RoleSD.Role_Admin1 + "," + RoleSD.Role_Admin2)]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();

            BinLookup? dbBinLookup = _db.BinLookups.Find(id);

            if (dbBinLookup == null) return NotFound();

            return View(dbBinLookup);
        }

        // Update BinLookup
        [HttpPost]
        [Authorize(Roles = RoleSD.Role_Admin1 + "," + RoleSD.Role_Admin2)]
        public IActionResult Edit(BinLookup obj)
        {
            if (ModelState.IsValid)
            {
                _db.BinLookups.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "BinLookup updated successfully";
                return RedirectToAction("Index", "Binlookup");
            }

            return View();
        }

        //Delete BinLookup
        [Authorize(Roles = RoleSD.Role_Admin1)]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            BinLookup? dbBinLookup = _db.BinLookups.Find(id);

            if (dbBinLookup == null) return NotFound();

            return View(dbBinLookup);
        }
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = RoleSD.Role_Admin1)]
        public IActionResult DeletePOST(int? id)
        {
            BinLookup? dbBinLookup = _db.BinLookups.Find(id);
            if (dbBinLookup != null)
            {
                _db.BinLookups.Remove(dbBinLookup);
                _db.SaveChanges();
                TempData["success"] = "BinLookup deleted successfully";
                return RedirectToAction("Index", "Binlookup");
            }

            return NotFound();
        }
    }
}