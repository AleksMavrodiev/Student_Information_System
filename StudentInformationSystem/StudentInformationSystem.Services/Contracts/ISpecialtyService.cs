using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentInformationSystem.Web.ViewModels.Speacialty;

namespace StudentInformationSystem.Services.Contracts
{
    public interface ISpecialtyService
    {
        public Task<List<SelectListItem>> GetSpecialtiesForListItemAsync();
    }
}
