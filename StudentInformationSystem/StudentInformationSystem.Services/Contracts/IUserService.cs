using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInfromationSystem.Data.Models;

namespace StudentInformationSystem.Services.Contracts
{
    public interface IUserService
    {
        Task AddStudentToRoleAsync(string userId);
        Task AddTeacherToRoleAsync(string userId);
        Task RemoveUserAsync(string id);
        Task<ApplicationUser> GetUserByIdAsync(string id);
        Task ChangeUserStatus(ApplicationUser user);
    }
}
