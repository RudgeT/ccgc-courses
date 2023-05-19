using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Admin.Data;
using Audit.Core.ConfigurationApi;
using DataModel;
using Business.Queries.Dtos;

namespace Admin.Pages.Courses
{
    public class EditModel : PageModel
    {
        private readonly DataModel.CollegeDbContext _context;
        private readonly CourseService _courseService;
        private readonly CourseTypeService _courseTypeService;
        private readonly DepartmentService _departmentService;
        private readonly DisciplineService _disciplineService;

        public EditModel(
            CollegeDbContext context,
            CourseService courseService,
            CourseTypeService courseTypeService,
            DepartmentService departmentService,
            DisciplineService disciplineService)
        {
            _context = context;
            _courseService = courseService;
            _courseTypeService = courseTypeService;
            _departmentService = departmentService;
            _disciplineService = disciplineService;
        }

        public DataModel.Course Course { get; set; }
        public IList<CourseType> CourseTypes { get; set; }
        public IList<Department> Departments { get; set; }
        public IList<Discipline> Disciplines { get; set; }
        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course = await _context.Courses.FindAsync(id);
            if (Course == null)
            {
                return NotFound();
            }
            CourseTypes = await _courseTypeService.GetAllCourseTypes();
            Departments = await _departmentService.GetAllDepartments();
            Disciplines = await _disciplineService.GetAllDisciplines();

            return Page();
        }

        [BindProperty]
        public CourseDto CourseDto { get; set; }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _courseService.UpdateCourse(CourseDto);

            return RedirectToPage("Details", new { id });
        }
    }
}