using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentInformationSystem.Web.ViewModels.Teacher;

namespace StudentInformationSystem.Services.Contracts
{
    public interface ITeacherService
    {
        Task<IEnumerable<TeacherListViewModel>> GetTeachersForListItemAsync();
    }
}
