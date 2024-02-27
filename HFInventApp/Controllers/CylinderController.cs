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
    public class CylinderController : Controller
    {
        private readonly AppDbContext _db;
        public CylinderController(AppDbContext db)
        {
            _db = db;
        }

        //[Authorize(Roles = RoleSD.Role_Employee)]
        public IActionResult Index()
        {
            List<Cylinder> dbCylinders = _db.Cylinders.ToList();
            List<Customer> dbCustomers = _db.Customers.ToList();

            vmCustomerCylinders customerCylinders = new vmCustomerCylinders
            {
                Cylinders = dbCylinders,
                Customers = dbCustomers
            };

            return View(customerCylinders);
        }

        // Add-Create Cylinder
        public IActionResult Create()
        {
            List<Customer> dbCustomers = _db.Customers.ToList();

            IEnumerable<SelectListItem> customerSelectList = dbCustomers.Select(c => new SelectListItem
            {
                Value = c.CustomerId.ToString(),
                Text = c.CustomerName
            });

            ViewBag.CustomerSelectList = customerSelectList;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cylinder obj)
        {
            if (obj != null && ModelState.IsValid)
            {
                obj.BatchNumber = Guid.NewGuid();
                _db.Cylinders.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Cylinder created successfully";
                return RedirectToAction("Index", "Cylinder");
            }

            return View();
        }

        //Edit Cylinder
        //[Authorize(Roles = RoleSD.Role_Admin2)]
        [Authorize(Roles = RoleSD.Role_Admin1 + "," + RoleSD.Role_Admin2)]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Cylinder? dbCylinder = _db.Cylinders.Find(id);

            if (dbCylinder == null) return NotFound();

            List<Customer> dbCustomers = _db.Customers.ToList();

            IEnumerable<SelectListItem> CustomerSelectList = dbCustomers.Select(c => new SelectListItem
            {
                Value = c.CustomerId.ToString(),
                Text = c.CustomerName
            });

            ViewBag.CustomerSelectList = CustomerSelectList;
            return View(dbCylinder);
        }

        // Update Cylinder
        [HttpPost]
        public IActionResult Edit(Cylinder obj)
        {
            Cylinder dbCylinder = _db.Cylinders.Find(obj.CylinderId);

            if (ModelState.IsValid)
            {
                dbCylinder.CylinderName = obj.CylinderName;
                dbCylinder.CustomerId = obj.CustomerId;

                _db.Cylinders.Update(dbCylinder);
                _db.SaveChanges();
                TempData["success"] = "Cylinder updated successfully";
                return RedirectToAction("Index", "Cylinder");
            }

            return View();
        }

        //Delete Cylinder
        [Authorize(Roles = RoleSD.Role_Admin1)]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Cylinder? dbCylinder = _db.Cylinders.Find(id);

            if (dbCylinder == null) return NotFound();

            return View(dbCylinder);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Cylinder? dbCylinder = _db.Cylinders.Find(id);
            if (dbCylinder != null)
            {
                _db.Cylinders.Remove(dbCylinder);
                _db.SaveChanges();
                TempData["success"] = "Cylinder deleted successfully";
                return RedirectToAction("Index", "Cylinder");
            }

            return NotFound();
        }

        public IActionResult RentIndex()
        {
            //List<Cylinder> dbCylinders = _db.Cylinders.ToList();
            //List<Customer> dbCustomers = _db.Customers.ToList();

            //vmCustomerCylinders customerCylinders = new vmCustomerCylinders
            //{
            //    Cylinders = dbCylinders,
            //    Customers = dbCustomers
            //};
            List<CylinderRentHistory> dbRentHistories = _db.CylinderRentHistories.ToList();

            return View(dbRentHistories);
            //return NotFound();
        }

        // Add-Create Cylinder
        public IActionResult RentCreate()
        {
            List<Customer> dbCustomers = _db.Customers.ToList();

            IEnumerable<SelectListItem> customerSelectList = dbCustomers.Select(c => new SelectListItem
            {
                Value = c.CustomerId.ToString(),
                Text = c.CustomerName
            });

            ViewBag.CustomerSelectList = customerSelectList;
            return View();
        }

        [HttpPost]
        public IActionResult RentCreate(CylinderRentHistory obj)
        {
            if (obj != null && ModelState.IsValid)
            {
                //obj.BatchNumber = Guid.NewGuid();
                _db.CylinderRentHistories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Cylinder history created successfully";
                return RedirectToAction("RentIndex", "Cylinder");
            }

            return View();
        }
    }
}
