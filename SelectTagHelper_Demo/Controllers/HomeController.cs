using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SelectTagHelper_Demo.Data;
using SelectTagHelper_Demo.Models;

namespace SelectTagHelper_Demo.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            ViewData["Id"] = new SelectList(dbContext.Departments, "Id", "DepartmentName");
            return View();
        }

        public IActionResult GenderAndDepartment()
        {
            var model = new Employee();
            model.Departments.ToList();
            return View(model);

        }

    }
}
