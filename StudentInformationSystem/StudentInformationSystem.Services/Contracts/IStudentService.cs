using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using StudentInformationSystem.Data.Models;
using StudentInformationSystem.Web.ViewModels.Student;

namespace StudentInformationSystem.Services.Contracts
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentAllViewModel>> GetStudentsAsync();
        Task<Student> GetStudentAsync(string id);
        Task CreateStudentAsync(StudentAddViewModel student);
        Task RemoveStudentProfilePictureAsync(string userId);
        Task SaveStudentProfilePictureAsync(string userId, IFormFile profilePicture);
        Task<StudentProfileViewModel> GetStudentProfileAsync(string userId);
        Task<Student> UpdateStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
    }
}
