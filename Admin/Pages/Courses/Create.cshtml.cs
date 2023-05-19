using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Audit.Core.ConfigurationApi;
using DataModel;
using Business.Queries.Dtos;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Admin.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly DataModel.CollegeDbContext _context;
        private readonly ILogger<CreateModel> _logger;
        private readonly CourseService _courseService;
        private readonly CourseTypeService _courseTypeService;
        private readonly DepartmentService _departmentService;
        private readonly DisciplineService _disciplineService;

        public CreateModel(
            CollegeDbContext context,
            ILogger<CreateModel>  logger,
            CourseService courseService,
            CourseTypeService courseTypeService,
            DepartmentService departmentService,
            DisciplineService disciplineService)
        {
            _context = context;
            _courseService = courseService;
            _logger = logger;
            _courseTypeService = courseTypeService;
            _departmentService = departmentService;
            _disciplineService = disciplineService;
        }

        public IList<CourseType> Types { get; set; }
        public IList<Department> Departments { get; set; }
        public IList<Discipline> Disciplines { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Types = await _courseTypeService.GetAllCourseTypes();
            Departments = await _departmentService.GetAllDepartments();
            Disciplines = await _disciplineService.GetAllDisciplines();
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var id = await _courseService.PostCourse(Course);
            return RedirectToPage("Details", new { id });
        }
    }
}