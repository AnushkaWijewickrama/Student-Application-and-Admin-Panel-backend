using StudentLicenseApi.Models;
using System.Threading.Tasks;

public interface IStudentApplicationService
{
    Task<bool> StudentExists(string email);
    Task<int> SaveApplication(StudentApplication application);
    Task<List<StudentApplication>> GetApplications();
}
