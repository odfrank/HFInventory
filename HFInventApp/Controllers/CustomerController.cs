using HFInventApp.Data;
using HFInventApp.Models;
using HFInventApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using System.Diagnostics;

namespace HFInventApp.Controllers
{
   // [Authorize(Roles = RoleSD.Role_Admin1)]
    public class CustomerController : Controller
    {
        private readonly AppDbContext _db;
        public CustomerController(AppDbContext db)
        {
            _db = db;
        }

        //[Authorize(Roles = RoleSD.Role_Employee)]
        public IActionResult Index()
        {
            List<Customer> dbCustomers = _db.Customers.ToList();
            List<Facility> dbFacilities = _db.Facilities.ToList();

            vmFacilityCustomers facilityCustomers = new vmFacilityCustomers
            {
                Customers = dbCustomers,
                Facilities = dbFacilities
            };

            return View(facilityCustomers);
        }

        // Add-Create Customer
        public IActionResult Create()
        {
            List<Facility> dbFacilities = _db.Facilities.ToList();

            IEnumerable<SelectListItem> facilitySelectList = dbFacilities.Select(f => new SelectListItem
            {
                Value = f.FacilityId.ToString(),
                Text = f.FacilityName
            });

            ViewBag.FacilitySelectList = facilitySelectList;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer obj)
        {
            if (obj != null && ModelState.IsValid)
            {
                _db.Customers.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Customer created successfully";
                return RedirectToAction("Index", "Customer");
            }

            return View();
        }

        //Edit Customer
        //[Authorize(Roles = RoleSD.Role_Admin2)]
        [Authorize(Roles = RoleSD.Role_Admin1 + "," + RoleSD.Role_Admin2)]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Customer? dbCustomer = _db.Customers.Find(id);

            if (dbCustomer == null) return NotFound();

            List<Facility> dbFacilities = _db.Facilities.ToList();

            IEnumerable<SelectListItem> facilitySelectList = dbFacilities.Select(f => new SelectListItem
            {
                Value = f.FacilityId.ToString(),
                Text = f.FacilityName
            });

            ViewBag.FacilitySelectList = facilitySelectList;
            return View(dbCustomer);
        }

        // Update Customer
        [HttpPost]
        public IActionResult Edit(Customer obj)
        {
            if (ModelState.IsValid)
            {
                _db.Customers.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Customer updated successfully";
                return RedirectToAction("Index", "Customer");
            }

            return View();
        }

        //Delete Customer
        [Authorize(Roles = RoleSD.Role_Admin1)]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Customer? dbCustomer = _db.Customers.Find(id);

            if (dbCustomer == null) return NotFound();

            return View(dbCustomer);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Customer? dbCustomer = _db.Customers.Find(id);
            if (dbCustomer != null)
            {
                _db.Customers.Remove(dbCustomer);
                _db.SaveChanges();
                TempData["success"] = "Customer deleted successfully";
                return RedirectToAction("Index", "Customer");
            }

            return NotFound();
        }
    }
}