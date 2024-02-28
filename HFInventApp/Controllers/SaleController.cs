using HFInventApp.Data;
using HFInventApp.Models;
using HFInventApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.Data;
using System.Diagnostics;
using System.Drawing.Text;
using System.Security.Claims;

namespace HFInventApp.Controllers
{
    public class SaleController : Controller
    {
        private readonly AppDbContext _db;
        //private readonly UserManager<ApplicationUser> _userManager;
        private static vmSaleCart SalesCart = new vmSaleCart();
        private static List<vmSaleProduct> saleProducts = new List<vmSaleProduct>();
        public SaleController(AppDbContext db)
        {
            _db = db;
            //_userManager = userManager;
        }

        //[Authorize(Roles = RoleSD.Role_Employee)]
        public  IActionResult Index()
        {
            List<Sale> dbSales = _db.Sales.ToList();
            List<Customer> dbCustomers = _db.Customers.ToList();
            List<Facility> dbFacilities = _db.Facilities.ToList();

            List<vmSales> dbTotalSales = new List<vmSales>();

            //Get the UserId
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;


            foreach (Sale sale in dbSales)
            {
                //Get user info for each sale
                var user = _db.ApplicationUsers.FirstOrDefault(u => u.Id == sale.UserId);

                //Add a section here later to filter for only sales made by current user i.e. sale.UserId == userId
                dbTotalSales.Add(new vmSales{
                    SaleId = sale.SaleId,
                    SaleFacility = dbFacilities.FirstOrDefault(f => f.FacilityId == sale.FacilityId),
                    SaleCustomer = dbCustomers.FirstOrDefault(c => c.CustomerId == sale.CustomerId),
                    SaleUser =user.FullName,
                    SaleDate = sale.SaleDate,
                    TotalSalePrice = (double)sale.TotalPrice
                });
            }
            return View(dbTotalSales);
        }

        // Add-Create Sale
        public IActionResult Create()
        {
            ////------------------Make Customers ViewBag
            List<Customer> dbCustomers = _db.Customers.ToList();

            IEnumerable<SelectListItem> saleCustomerList = dbCustomers.Select(c => new SelectListItem
            {
                Value = c.CustomerId.ToString(),
                Text = c.CustomerName + " - " + c.CompanyName
            });
            ViewBag.CustomerSelectList = saleCustomerList;
            // -------------------------------------

            //------------------Make Facilities ViewBag
            List<Facility> dbFacilities = _db.Facilities.ToList();

            IEnumerable<SelectListItem> saleFacilityList = dbFacilities.Select(c => new SelectListItem
            {
                Value = c.FacilityId.ToString(),
                Text = c.FacilityName + " - " + c.Location
            });
            ViewBag.FacilitySelectList = saleFacilityList;
            // -------------------------------------

            //Create blank new SalesCart
            //vmSaleCart SalesCart = new vmSaleCart
            //{
            //    SaleProducts = tempSaleProducts
            //};

            vmSaleCart salesCart = new vmSaleCart();
            salesCart.SaleProducts = saleProducts;
            //salesCart = SalesCart;
            //SalesCart.SaleProducts.Add(new vmSaleProduct());
            return View(salesCart);
        }

        [HttpPost]
        public IActionResult Create(vmSaleCart obj)
        {
            //Get the UserId
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;

            var saleDate = DateTime.Now;

            if (obj != null)
            {                
                // Add(new vmSales{
                _db.Sales.Add(new Sale
                {
                    FacilityId = (int)obj.FacilityId,
                    UserId = userId,
                    CustomerId = (int)obj.CustomerId,
                    SaleDate = saleDate,
                    TotalPrice = (decimal)obj.TotalSalePrice
                });
                _db.SaveChanges();
            }

            //Get the SaleId using some criteria (filter by userId and exact SaleDateTime
            var saleId = _db.Sales.FirstOrDefault(s => s.UserId == userId && s.SaleDate == saleDate).SaleId;


            if (saleId != null)
            {
                foreach(var s in saleProducts)
                {
                    _db.SaleDetails.Add(new SaleDetail { 
                        SaleId = saleId,
                        ProductId = s.Product.ProductId,
                        QuantitySold = s.Quantity,
                        ProductPrice = s.Product.Price                            
                    });
                }

                _db.SaveChanges();
            }

            SalesCart = new vmSaleCart();
            saleProducts = new List<vmSaleProduct>();

            TempData["success"] = "Sale created successfully";
            return RedirectToAction("Index", "Sale");
            
            //Console.WriteLine(obj.CustomerId.ToString() + " Fac: " + obj.FacilityId.ToString() + obj.TotalSalePrice.ToString());

            //Console.WriteLine(SalesCart.SaleProducts.Count);
            //Console.WriteLine(saleProducts.Count);

            return RedirectToAction("Create", "Sale");
        }

        public IActionResult CancelSale()
        {
            SalesCart = new vmSaleCart();
            saleProducts = new List<vmSaleProduct>();
            
            return RedirectToAction("Index", "Sale");
        }


        //Add-Create SaleDetail

        public IActionResult CreateDetail()
        {
            List<Product> dbProducts = _db.Products.ToList();

            IEnumerable<SelectListItem> saleProductList = dbProducts.Select(p => new SelectListItem
            {
                Value = p.ProductId.ToString(),
                Text = p.ProductName + " - " + p.ProductDescription +  " - Price: " + p.Price
            });

            ViewBag.ProductSelectList = saleProductList;

            vmSaleProductSelect tempProduct = new vmSaleProductSelect();
            return View(tempProduct);
        }
            
        [HttpPost]
        public IActionResult CreateDetail(vmSaleProductSelect obj)
        {
            if (obj != null && ModelState.IsValid)
            {
                Product curProduct = _db.Products.FirstOrDefault(p => p.ProductId == obj.ProductId);

                vmSaleProduct saleProduct = new vmSaleProduct
                {
                    Product = curProduct,
                    Quantity = obj.Quantity,
                    SalePrice = (double)curProduct.Price * obj.Quantity
                };

                //vmProductSale productSale = new vmProductSale
                //{
                //    ProductId = obj.ProductId,
                //    ProductName = curProduct.ProductName,
                //    ProductDescription = curProduct.ProductDescription,
                //    QuantitySold = obj.QuantitySold,
                //    ProductPrice = curProduct.Price,
                //    SalePrice = curProduct.Price * obj.QuantitySold
                //};
                //obj.SalePrice = _db.Products.FirstOrDefault(p => p.ProductId == obj.ProductId).Price;
                //private SaleDetail tempSaleDetail;
                saleProducts.Add(saleProduct);
                //SalesCart.SaleProducts.Add(saleProduct);
                //_db.SaveChanges();
                TempData["success"] = "Product successfully added to Cart";
                return RedirectToAction("Create", "Sale");
            }

            return View();
        }

        //Edit Sale
        //[Authorize(Roles = RoleSD.Role_Admin2)]
        [Authorize(Roles = RoleSD.Role_Admin1 + "," + RoleSD.Role_Admin2)]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Sale? dbSale = _db.Sales.Find(id);

            if (dbSale == null) return NotFound();

            List<Facility> dbFacilities = _db.Facilities.ToList();

            IEnumerable<SelectListItem> facilitySelectList = dbFacilities.Select(f => new SelectListItem
            {
                Value = f.FacilityId.ToString(),
                Text = f.FacilityName
            });

            ViewBag.FacilitySelectList = facilitySelectList;
            return View(dbSale);
        }

        // Update Sale
        [HttpPost]
        [Authorize(Roles = RoleSD.Role_Admin1 + "," + RoleSD.Role_Admin2)]
        public IActionResult Edit(Sale obj)
        {
            if (ModelState.IsValid)
            {
                _db.Sales.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Sale updated successfully";
                return RedirectToAction("Index", "Sale");
            }

            return View();
        }

        //Delete Sale
        [Authorize(Roles = RoleSD.Role_Admin1)]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();

            Sale? dbSale = _db.Sales.Find(id);

            if (dbSale == null) return NotFound();

            return View(dbSale);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = RoleSD.Role_Admin1)]
        public IActionResult DeletePOST(int? id)
        {
            Sale? dbSale = _db.Sales.Find(id);
            if (dbSale != null)
            {
                _db.Sales.Remove(dbSale);
                _db.SaveChanges();
                TempData["success"] = "Sale deleted successfully";
                return RedirectToAction("Index", "Sale");
            }

            return NotFound();
        }
    }
}