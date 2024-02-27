using HFInventApp.Models;
using HFInventApp.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace HFInventApp.Controllers
{
    [Authorize(Roles = RoleSD.Role_Admin1)]
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Product> dbProducts = _db.Products.ToList();
            return View(dbProducts);
        }

        // Add-Create Product
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("ProductId,ProductName,ProductDescription,Price")] Product obj)
        {
            if (obj != null && ModelState.IsValid)
            {
                obj.BatchNumber = Guid.NewGuid();
                _db.Products.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Product created successfully";
                return RedirectToAction("Index", "Product");
            }

            return View();
        }

        //Edit Product
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Product? dbProduct = _db.Products.Find(id);

            if (dbProduct == null) return NotFound();

            return View(dbProduct);
        }

        // Update Product
        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Product updated successfully";
                return RedirectToAction("Index", "Product");
            }

            return View();
        }

        //Delete Product
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Product? dbProduct = _db.Products.Find(id);

            if (dbProduct == null) return NotFound();

            return View(dbProduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Product? dbProduct = _db.Products.Find(id);
            if (dbProduct != null)
            {
                _db.Products.Remove(dbProduct);
                _db.SaveChanges();
                TempData["success"] = "Product deleted successfully";
                return RedirectToAction("Index", "Product");
            }

            return NotFound();
        }
    }
}