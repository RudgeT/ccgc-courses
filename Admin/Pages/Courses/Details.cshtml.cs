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
    public class DetailsModel : PageModel
    {
        private readonly DataModel.CollegeDbContext _context;
        private readonly CourseService _courseService;
        private readonly CourseTypeService _courseTypeService;
        private readonly DepartmentService _departmentService;
        private readonly DisciplineService _disciplineService;

        public DetailsModel(
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
        public CourseType CourseType { get; set; }
        public Department Department { get; set; }
        public Discipline Discipline { get; set; }
        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course = await _context.Courses.FindAsync(id);
            CourseType = await _courseTypeService.GetCourseType(Course.TypeID);
            Department = await _departmentService.GetDepartment(Course.DepartmentID);
            Discipline = await _disciplineService.GetDiscipline(Course.DisciplineID);
            return Page();
        }

       
        public Task<IActionResult> OnPostAsync()
        {
            throw new NotImplementedException();            
        }
    }
}