using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFWorkforce.Models.ViewModel
{
    public class DepartmentSummaryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Budget { get; set; }

        [Display(Name = "Employee Count")]
        public int EmployeeCount { get; set; }
    }
}
