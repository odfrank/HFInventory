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
    [Authorize(Roles = RoleSD.Role_Admin1)]
    public class ProductInventoryController : Controller
    {
        private readonly AppDbContext _db;
        public ProductInventoryController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            List<ProductInventory> dbInventories = _db.ProductInventories.ToList();
            List<Facility> dbFacilities = _db.Facilities.ToList();
            List<Product> dbProducts = _db.Products.ToList();
            List<BinLookup> dbBinLookups = _db.BinLookups.ToList();

            vmProductInventories productInventories = new vmProductInventories
            {
                ProductInventories = dbInventories,
                Facilities = dbFacilities,
                Products = dbProducts,
                BinLookups = dbBinLookups
            };

            return View(productInventories);
        }

        // Add-Create Product Inventory
        public IActionResult Create()
        {
            //-------- Make up SelectItems ------------//
            //Select Items for Facilities
            List<Facility> dbFacilities = _db.Facilities.ToList();

            IEnumerable<SelectListItem> facilitySelectList = dbFacilities.Select(f => new SelectListItem
            {
                Value = f.FacilityId.ToString(),
                Text = f.FacilityName
            });

            //Select Items for Products
            List<Product> dbProducts = _db.Products.ToList();

            IEnumerable<SelectListItem> productSelectList = dbProducts.Select(f => new SelectListItem
            {
                Value = f.ProductId.ToString(),
                Text = f.ProductName
            });

            //Select Items for BinLookups
            List<BinLookup> dbBinLookups = _db.BinLookups.ToList();

            IEnumerable<SelectListItem> binLookupSelectList = dbBinLookups.Select(f => new SelectListItem
            {
                Value = f.BinLookupId.ToString(),
                Text = f.BinNumber + " - " + f.Description
            });

            ViewBag.FacilitySelectList = facilitySelectList;
            ViewBag.ProductSelectList = productSelectList;
            ViewBag.BinLookupSelectList = binLookupSelectList;
            //-------- End of SelectItems ------------//

            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductInventory obj)
        {
            if (obj != null && ModelState.IsValid)
            {
                _db.ProductInventories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Product Inventory created successfully";
                return RedirectToAction("Index", "ProductInventory");
            }

            return View();
        }

        //Edit Product Inventory
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();

            ProductInventory? dbProductInventory = _db.ProductInventories.Find(id);

            if (dbProductInventory == null) return NotFound();

            //-------- Make up SelectItems ------------//
            //Select Items for Facilities
            List<Facility> dbFacilities = _db.Facilities.ToList();

            IEnumerable<SelectListItem> facilitySelectList = dbFacilities.Select(f => new SelectListItem
            {
                Value = f.FacilityId.ToString(),
                Text = f.FacilityName
            });

            //Select Items for Products
            List<Product> dbProducts = _db.Products.ToList();

            IEnumerable<SelectListItem> productSelectList = dbProducts.Select(f => new SelectListItem
            {
                Value = f.ProductId.ToString(),
                Text = f.ProductName
            });

            //Select Items for BinLookups
            List<BinLookup> dbBinLookups = _db.BinLookups.ToList();

            IEnumerable<SelectListItem> binLookupSelectList = dbBinLookups.Select(f => new SelectListItem
            {
                Value = f.BinLookupId.ToString(),
                Text = f.BinNumber + " - " + f.Description
            });

            ViewBag.FacilitySelectList = facilitySelectList;
            ViewBag.ProductSelectList = productSelectList;
            ViewBag.BinLookupSelectList = binLookupSelectList;
            //-------- End of SelectItems ------------//


            return View(dbProductInventory);
        }

        // Update Customer
        [HttpPost]
        public IActionResult Edit(ProductInventory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ProductInventories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Product Inventory updated successfully";
                return RedirectToAction("Index", "ProductInventory");
            }

            return View();
        }

        //Delete ProductInventory
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            ProductInventory? dbProductInventory = _db.ProductInventories.Find(id);

            if (dbProductInventory == null) return NotFound();

            return View(dbProductInventory);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            ProductInventory? dbProductInventory = _db.ProductInventories.Find(id);
            if (dbProductInventory != null)
            {
                _db.ProductInventories.Remove(dbProductInventory);
                _db.SaveChanges();
                TempData["success"] = "Product Inventory deleted successfully";
                return RedirectToAction("Index", "ProductInventory");
            }

            return NotFound();
        }
    }
}