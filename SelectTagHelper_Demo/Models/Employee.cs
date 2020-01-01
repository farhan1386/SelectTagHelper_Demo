using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SelectTagHelper_Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Gender { get; set; }

        public string Department { get; set; }

        public List<SelectListItem> Departments { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Account" },
            new SelectListItem { Value = "2", Text = "Finance" },
            new SelectListItem { Value = "3", Text = "HR"  },
            new SelectListItem { Value = "4", Text = "IT"  },
            new SelectListItem { Value = "5", Text = "Marketing"  },
            new SelectListItem { Value = "6", Text = "Sales"  },
        };
    }
}
