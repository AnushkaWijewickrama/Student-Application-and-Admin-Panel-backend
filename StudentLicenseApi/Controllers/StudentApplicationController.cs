using Microsoft.AspNetCore.Mvc;
using StudentLicenseApi.Models;
using System.IO;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class StudentApplicationController : ControllerBase
{
    private readonly IStudentApplicationService _applicationService;
    private readonly IWebHostEnvironment _env;

    public StudentApplicationController(IStudentApplicationService applicationService, IWebHostEnvironment env)
    {
        _applicationService = applicationService;
        _env = env;
    }

    [HttpPost]
    public async Task<IActionResult> SubmitApplication([FromForm] StudentApplicationDto dto)
    {
        if (await _applicationService.StudentExists(dto.Email))
        {
            return BadRequest("Student with the same email already exists.");
        }

        var filePath = Path.Combine(_env.WebRootPath, "uploads", dto.StudentIdCard.FileName);
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await dto.StudentIdCard.CopyToAsync(stream);
        }

        var application = new StudentApplication
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Email = dto.Email,
            Phone = dto.PhoneNumber,
            Address = dto.Address,
            Country = dto.Country,
            Institute = dto.Institute,
            Intake = dto.Intake,
            CourseTitle = dto.CourseTitle,
            StudentIdCardPath = filePath
        };

        await _applicationService.SaveApplication(application);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetApplications()
    {
        var applications = await _applicationService.GetApplications();
        return Ok(applications);
    }
}
