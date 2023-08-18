using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Services.Contracts
{
    public interface IUserService
    {
        Task AddStudentToRoleAsync(string userId);
        Task AddTeacherToRoleAsync(string userId);
    }
}
