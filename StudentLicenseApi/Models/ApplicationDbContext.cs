using Microsoft.EntityFrameworkCore;
using StudentLicenseApi.Models;

namespace StudentLicenseApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<StudentApplication> StudentApplications { get; set; }
    }
}
