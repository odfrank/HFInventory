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
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserController(AppDbContext db, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
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

        
        // Add-Create New User By Admin1
        [Authorize(Roles = RoleSD.Role_Admin1)]
        public IActionResult Create()
        {
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

            return View();
        }
        
        [HttpPost]
        [Authorize(Roles = RoleSD.Role_Admin1)]
        public async Task<IActionResult> CreateAsync(vmUsers obj)
        {
            // Add to ApplicationUsers table
            if (obj.UserInfo != null && ModelState.IsValid)
            {
                //// Set UserName = Email
                //obj.UserInfo.UserName = obj.UserInfo.Email;
                //obj.UserInfo.NormalizedUserName = obj.UserInfo.Email.ToUpper();
                //obj.UserInfo.NormalizedEmail = obj.UserInfo.Email.ToUpper();
                ////obj.UserInfo.Discriminator = "ApplicationUser";

                //// Get and set the passwordhash
                //obj.UserInfo.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(obj.UserInfo, obj.Password);

                //// Create the user
                //_db.ApplicationUsers.Add(obj.UserInfo);
                //_db.SaveChanges();

                // create the user as ApplicationUser
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = obj.UserInfo.Email,
                    Email = obj.UserInfo.Email,
                    FullName = obj.UserInfo.FullName,
                    JobTitle = obj.UserInfo.JobTitle
                }, obj.Password).GetAwaiter().GetResult();

                //_db.SaveChanges();


                // Assign created adminUser to Admin1 Role
                ApplicationUser newUser = _db.ApplicationUsers.FirstOrDefault(u => u.Email == obj.UserInfo.Email);
                //_userManager.AddToRoleAsync(user, RoleSD.Role_Employee).GetAwaiter().GetResult();
                
                //Now Add newly created user to UserRoles table
                if (obj.RoleId != null && obj.RoleId.ToString() != "--Choose Role--")
                {
                    _db.UserRoles.Add(new IdentityUserRole<string>
                    {
                        UserId = newUser.Id,
                        RoleId = obj.RoleId
                    });
                    _db.SaveChanges();
                }

                // Now Add newly created user to UserFacilities table
                if (obj.FacilityId != null && obj.FacilityId.ToString() != "--Choose Facility--")
                {
                    _db.UserFacilities.Add(new UserFacility
                    {
                        UserId = newUser.Id,
                        FacilityId = (int)obj.FacilityId
                    });
                    _db.SaveChanges();
                }

                //    //Return to Index page               
                TempData["success"] = "New user created successfully";
                return RedirectToAction("Index", "User");
            }

            return View();
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
            //var testUserRole = _db.UserRoles.FirstOrDefault(u => u.UserId == obj.UserInfo.Id);
            IdentityUserRole<string> testUserRole = _db.UserRoles.FirstOrDefault(u => u.UserId == obj.UserInfo.Id);


            //Update Changes to UserFacilities table
            UserFacility? testUserFac = _db.UserFacilities.FirstOrDefault(u => u.UserId == obj.UserInfo.Id);
            if (testUserFac != null && testUserFac.FacilityId != obj.FacilityId)
            {
                //Update Scenario
                _db.UserFacilities.Remove(testUserFac);
                _db.SaveChanges();

                testUserFac.FacilityId = (int)obj.FacilityId;
                _db.UserFacilities.Add(testUserFac);
                _db.SaveChanges();
            }
            else if(testUserFac == null && obj.FacilityId != null)
            {
                //New Addition Scenario
                _db.UserFacilities.Add(new UserFacility
                {
                    UserId = obj.UserInfo.Id,
                    FacilityId = (int)obj.FacilityId
                });
                _db.SaveChanges();
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
            }

            //Update changes to UserRoles table
            if (testUserRole != null && testUserRole.RoleId != obj.RoleId)
            {
                //Update Scenario
                _db.UserRoles.Remove(testUserRole);
                _db.SaveChanges();

                testUserRole.RoleId = obj.RoleId;
                _db.UserRoles.Add(testUserRole);
                _db.SaveChanges();


            }
            else if (testUserRole == null && obj.RoleId != null)
            {
                //New Addition Scenario - Logically, this should never happen actually
                _db.UserRoles.Add(new IdentityUserRole<string>
                {
                    UserId = obj.UserInfo.Id,
                    RoleId = obj.RoleId
                });
                _db.SaveChanges();               
            }

            _db.SaveChanges();
            TempData["success"] = "User updated successfully";
            return RedirectToAction("Index", "User");                 
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
            // Delete user from ApplicationUsers table
            ApplicationUser? dbUser = _db.ApplicationUsers.Find(id);
            if (dbUser != null)
            {
                _db.ApplicationUsers.Remove(dbUser);
                _db.SaveChanges();

                // Delete User from UserRoles table
                IdentityUserRole<string> dbUserRole = _db.UserRoles.FirstOrDefault(u => u.UserId == id);
                if (dbUserRole != null)
                {
                    _db.UserRoles.Remove(dbUserRole);
                    _db.SaveChanges();
                }              
                
                // Delete dbUser from UserFacilities table
                UserFacility? dbUserFac = _db.UserFacilities.FirstOrDefault(u => u.UserId == id);
                if (dbUserFac != null)
                {
                    _db.UserFacilities.Remove(dbUserFac);
                    _db.SaveChanges();
                }

                // Show successful delete status
                TempData["success"] = "User deleted successfully";
                return RedirectToAction("Index", "User");
            }

            return NotFound();
        }
    }
}
