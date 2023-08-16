using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Web.ViewModels.Student
{
    public class StudentProfileViewModel
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FacultyNumber { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string EGN { get; set; } = null!;
        public string Email { get; set; } = null!;
        public byte[]? ProfilePicture { get; set; }
    }
}
