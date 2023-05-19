using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using Web.Data;

namespace Web.Pages.Courses
{
    public class CourseModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly CourseService _courseService;
        private readonly DepartmentService _departmentService;
        private readonly CourseTypeService _courseTypeService;
        private readonly DisciplineService _disciplineService;


        public Course Course { get; set; }
        public Department Department { get; set; }

        public CourseType CourseType { get; set; }

        public Discipline Discipline { get; set; }


        public CourseModel(ILogger<IndexModel> logger, CourseService courseService, DepartmentService departmentService, CourseTypeService courseTypeService, DisciplineService disciplineService)
        {
            _logger = logger;
            _courseService = courseService;
            _departmentService = departmentService;
            _courseTypeService = courseTypeService;
            _disciplineService = disciplineService;
        }

        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course = await _courseService.GetCourseById(id.Value);
            Department = await _departmentService.GetDepartmentById(Course.department);
            CourseType = await _courseTypeService.GetCourseTypeById(Course.type);
            Discipline = await _disciplineService.GetDisciplineById(Course.discipline);
            return Page();
        }
    }
}
