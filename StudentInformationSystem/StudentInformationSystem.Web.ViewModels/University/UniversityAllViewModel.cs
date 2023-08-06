using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Web.ViewModels.University
{
    public class UniversityAllViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Adress { get; set; } = null!;
    }
}
