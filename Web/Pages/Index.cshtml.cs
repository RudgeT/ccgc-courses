using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Web.Data;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CourseService _courseService;
        private readonly DepartmentService _departmentService;


        public Course[] Courses { get; set; }
        public Department[] Departments { get; set; }

        public IndexModel(ILogger<IndexModel> logger, CourseService courseService, DepartmentService departmentService)
        {
            _logger = logger;
            _courseService = courseService;
            _departmentService = departmentService;
        }

        public async Task OnGet()
        {
            Courses = await _courseService.GetCourses();
            Departments = await _departmentService.GetDepartments();
        }
    }
}
