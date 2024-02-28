using HFInventApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HFInventApp.Data
{
    public class DbInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _db;

        public DbInitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            AppDbContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }
        public void Initialize()
        {
            // Push migrations if they are not applied
            try
            {
                if(_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch(Exception ex)
            {

            }


            // Create roles if they are not created
            if (!_roleManager.RoleExistsAsync(RoleSD.Role_Admin1).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(RoleSD.Role_Admin1)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(RoleSD.Role_Admin2)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(RoleSD.Role_Employee)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(RoleSD.Role_Guest)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(RoleSD.Role_Customer)).GetAwaiter().GetResult();

                // create the first Admin1 user if not existing
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "admin1@hfenergy.com",
                    Email = "admin1@hfenergy.com",
                    FullName = "HF Admin",
                    JobTitle = "Super Admin"
                }, "MasterAdmin1**").GetAwaiter().GetResult();

                // Assign created adminUser to Admin1 Role
                ApplicationUser user = _db.ApplicationUsers.FirstOrDefault(u => u.Email == "admin1@hfenergy.com");
                _userManager.AddToRoleAsync(user, RoleSD.Role_Admin1).GetAwaiter().GetResult();
            }

            return;
            
        }
    }
}
