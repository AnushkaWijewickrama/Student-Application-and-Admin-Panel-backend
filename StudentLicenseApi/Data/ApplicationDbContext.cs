using Microsoft.EntityFrameworkCore;
using StudentLicenseApi.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<StudentApplication> StudentApplications { get; set; }
}
