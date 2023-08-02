using StudentInformationSystem.Web.ViewModels.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Services.Contracts
{
    public interface IUniversityService
    {
        public Task<IEnumerable<UniversityAllViewModel>> ShowAll();
    }
}
