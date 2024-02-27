using HFInventApp.Data;
using HFInventApp.Models;
using HFInventApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using System.Threading.Tasks;

namespace HFInventApp.Controllers
{
    [Authorize(Roles = RoleSD.Role_Admin1 + "," + RoleSD.Role_Admin2)]
    public class UserController : Controller
    {
        private readonly AppDbContext _db;
        //private readonly UserManager<ApplicationUser> _userManager;
        public UserController(AppDbContext db)
        {
            _db = db;
            //_userManager = userManager;
            //https://localhost:7084/User
        }
        public IActionResult Index()
        {
            var dbUsers = _db.ApplicationUsers.ToList();
            var dbUserRoles = _db.UserRoles.ToList();
            var dbRoles = _db.Roles.ToList();
            var dbUserFacilities = _db.UserFacilities.ToList();
            var dbFacilities = _db.Facilities.ToList();


            List<vmUsers> objUsers = new List<vmUsers>();
            //dbTotalSales.Add(new vmSales{

            foreach (var user in dbUsers)
            {
                var roleId = dbUserRoles.FirstOrDefault(u => u.UserId == user.Id).RoleId;

                //int? facilityId  = null;
                //if (dbUserFacilities.FirstOrDefault(u => u.UserId == user.Id).FacilityId != null)
                //{
                //    facilityId = dbUserFacilities.FirstOrDefault(u => u.UserId == user.Id).FacilityId;
                //}

                //var userFacility = dbUserFacilities.FirstOrDefault(u => u.UserId == user.Id);
                int? facilityId = null;

                var testUserFac = dbUserFacilities.FirstOrDefault(u => u.UserId == user.Id);
                //Get assigned user facility, if existing
                if (testUserFac != null)
                {
                    facilityId = testUserFac.FacilityId;
                }

                //Get assigned user role
                var userRole = dbRoles.FirstOrDefault(r => r.Id == roleId).Name;

                //Show Admin1 assigned to all facilities, else, show only facility assigned to each user
                var userFacility = "";

                if (userRole == "Admin1") userFacility = "All";
                else if (facilityId == null) userFacility = "None"; 
                else userFacility = dbFacilities.FirstOrDefault(f => f.FacilityId == facilityId).FacilityName;

                objUsers.Add(new vmUsers{ 
                    UserInfo = user,
                    FacilityId = facilityId,
                    FacilityName = userFacility,
                    //RoleId = roleId,
                    Role = userRole
                });
            }
            return View(objUsers);
        }

        //Edit User
        public IActionResult Edit(string? id)
        {
            if (id == null) return NotFound();

            ApplicationUser? dbUser = _db.ApplicationUsers.Find(id);
            if (dbUser == null) return NotFound();                                   

            var testUserFac = _db.UserFacilities.FirstOrDefault(u => u.UserId == id);       

            vmUsers editUser = new vmUsers
            {
                UserInfo = dbUser,
                FacilityId = testUserFac?.FacilityId,            
                RoleId = _db.UserRoles.ToList().FirstOrDefault(u => u.UserId == dbUser.Id).RoleId
            };

            //Create ViewBag for Facilities
            var dbFacilities = _db.Facilities.ToList();
            IEnumerable<SelectListItem> facilitySelectList = dbFacilities.Select(f => new SelectListItem
            {
                Value = f.FacilityId.ToString(),
                Text = f.FacilityName
            });
            ViewBag.FacilitySelectList = facilitySelectList;

            //Create ViewBag for Roles
            var dbRoles = _db.Roles.ToList();
            IEnumerable<SelectListItem> roleSelectList = dbRoles.Select(r => new SelectListItem
            {
                Value = r.Id.ToString(),
                Text = r.Name
            });
            ViewBag.RoleSelectList = roleSelectList;

            return View(editUser);

        }

        // Update Facility
        [HttpPost]
        public async Task<IActionResult> Edit(vmUsers obj)
        {
            ApplicationUser? dbUser = _db.ApplicationUsers.Find(obj.UserInfo.Id);

            //Update Changes to UserFacility table
            UserFacility? testUserFac = _db.UserFacilities.FirstOrDefault(u => u.UserId == obj.UserInfo.Id);
            if (testUserFac != null && testUserFac.FacilityId != obj.FacilityId)
            {
                //Update Scenario
                _db.UserFacilities.Remove(testUserFac);
                _db.SaveChanges();

                testUserFac.FacilityId = (int)obj.FacilityId;
                _db.UserFacilities.Add(testUserFac);
            }
            else if(testUserFac == null && obj.FacilityId != null)
            {
                //New Addition Scenario
                _db.UserFacilities.Add(new UserFacility
                {
                    UserId = obj.UserInfo.Id,
                    FacilityId = (int)obj.FacilityId
                });
            }            


            //Update changes to Users table
            if (dbUser != null)
            {
                dbUser.FullName = obj.UserInfo.FullName;
                dbUser.JobTitle = obj.UserInfo.JobTitle;
                dbUser.Email = obj.UserInfo.Email;
                dbUser.PhoneNumber = obj.UserInfo.PhoneNumber;

                _db.Users.Update(dbUser);
                _db.SaveChanges();
                TempData["success"] = "User updated successfully";
                return RedirectToAction("Index", "User");
            }
            
            return View();
        }

        //Delete User
        public IActionResult Delete(string? id)
        {
            if (id == null) return NotFound();

            ApplicationUser? dbUser = _db.ApplicationUsers.Find(id);

            if (dbUser == null) return NotFound();

            return View(dbUser);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(string? id)
        {
            ApplicationUser? dbUser = _db.ApplicationUsers.Find(id);
            if (dbUser != null)
            {
                _db.ApplicationUsers.Remove(dbUser);
                _db.SaveChanges();
                TempData["success"] = "User deleted successfully";
                return RedirectToAction("Index", "User");
            }

            return NotFound();
        }
    }
}
