using HFInventApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HFInventApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
