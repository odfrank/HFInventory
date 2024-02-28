using HFInventApp.Data;
using HFInventApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HFInventApp.Controllers
{
    //[Authorize(Roles = RoleSD.Role_Admin1)]
    public class FacilityController : Controller
    {
        private readonly AppDbContext _db;
        public FacilityController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Facility> dbFacilities = _db.Facilities.ToList();
            return View(dbFacilities);
        }

        // Add-Create Facility
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Facility obj)
        {
            if (obj != null && ModelState.IsValid)
            {
                _db.Facilities.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Facility created successfully";
                return RedirectToAction("Index", "Facility");
            }

            return View();
        }

        //Edit Facility
        [Authorize(Roles = RoleSD.Role_Admin1 + "," + RoleSD.Role_Admin2)]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Facility? dbFacility = _db.Facilities.Find(id);

            if (dbFacility == null) return NotFound();

            return View(dbFacility);
        }

        // Update Facility
        [HttpPost]
        [Authorize(Roles = RoleSD.Role_Admin1 + "," + RoleSD.Role_Admin2)]
        public IActionResult Edit(Facility obj)
        {
            if (ModelState.IsValid)
            {
                _db.Facilities.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Facility updated successfully";
                return RedirectToAction("Index", "Facility");
            }

            return View();
        }

        //Delete Facility
        [Authorize(Roles = RoleSD.Role_Admin1)]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Facility? dbFacility = _db.Facilities.Find(id);

            if (dbFacility == null) return NotFound();

            return View(dbFacility);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Facility? dbFacility = _db.Facilities.Find(id);
            if (dbFacility != null)
            {
                _db.Facilities.Remove(dbFacility);
                _db.SaveChanges();
                TempData["success"] = "Facility deleted successfully";
                return RedirectToAction("Index", "Facility");
            }

            return NotFound();
        }
    }
}