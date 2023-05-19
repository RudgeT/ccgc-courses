using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Queries.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DataModel;

namespace Admin.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly DataModel.CollegeDbContext _context;
        private readonly CourseService _courseService;
        private readonly CourseTypeService _courseTypeService;
        private readonly DepartmentService _departmentService;
        private readonly DisciplineService _disciplineService;
        public IndexModel(
            DataModel.CollegeDbContext context,
            CourseService courseService,
            CourseTypeService courseTypeService,
            DepartmentService departmentService,
            DisciplineService disciplineService
        )
        {
            _context = context;
            _courseService = courseService;
            _courseTypeService = courseTypeService;
            _departmentService = departmentService;
            _disciplineService = disciplineService;
        }

        public bool DisplayTopOfPage { get; set; }

        public double LastTableContainerHeight { get; set; } = 300;

        public IList<CourseDto> CourseList { get; set; }
        public IList<CourseType> CourseTypeList { get; set; }
        public IList<Department> DepartmentList { get; set; }
        
        public IList<Discipline> DisciplineList { get; set;}

 
        [BindProperty(SupportsGet = true)]
        public string Filter { get; set; }

        public async Task OnGetAsync()
        {
            CourseList = await _courseService.GetAllCourses();
            CourseTypeList = await _courseTypeService.GetAllCourseTypes();
            DepartmentList = await _departmentService.GetAllDepartments();
            DisciplineList = await _disciplineService.GetAllDisciplines();

            DisplayTopOfPage = true;
            var sessionStr = HttpContext.Session.GetString("displayTopOfPage");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (sessionStr.ToLower() == "false")
                {
                    DisplayTopOfPage = false;
                }
            }
            sessionStr = HttpContext.Session.GetString("lastTableContainerHeight");
            if (!string.IsNullOrEmpty(sessionStr))
            {
                if (double.TryParse(sessionStr, out double num))
                {
                    if (num > 300)
                    {
                        LastTableContainerHeight = num;
                    }
                }
            }
        }
    }
}

