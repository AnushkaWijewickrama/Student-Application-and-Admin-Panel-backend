using Microsoft.AspNetCore.Http;

public class StudentApplicationDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Country { get; set; }
    public string Institute { get; set; }
    public string Intake { get; set; }
    public string CourseTitle { get; set; }
    public IFormFile StudentIdCard { get; set; }
}
