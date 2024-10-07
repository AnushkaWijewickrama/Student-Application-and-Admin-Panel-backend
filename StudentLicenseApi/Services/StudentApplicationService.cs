using Microsoft.EntityFrameworkCore;
using StudentLicenseApi.Models;

public class StudentApplicationService : IStudentApplicationService
{
    private readonly ApplicationDbContext _context;

    public StudentApplicationService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> StudentExists(string email)
    {
        return await _context.StudentApplications.AnyAsync(a => a.Email == email);
    }

    public async Task<int> SaveApplication(StudentApplication application)
    {
        _context.StudentApplications.Add(application);
        return await _context.SaveChangesAsync();
    }

    public async Task<List<StudentApplication>> GetApplications()
    {
        return await _context.StudentApplications.ToListAsync();
    }
}
