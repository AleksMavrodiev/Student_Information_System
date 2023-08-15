using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Data.Models;
using StudentInformationSystem.Web.ViewModels.Student;

namespace StudentInformationSystem.Services.Contracts
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentAllViewModel>> GetStudentsAsync();
        Task<Student> GetStudentAsync(int id);
        Task CreateStudentAsync(StudentAddViewModel student);
        Task<Student> UpdateStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
    }
}
