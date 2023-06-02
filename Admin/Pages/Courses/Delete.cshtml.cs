using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DataModel;
using Admin.Data;
using System.Threading;

namespace Admin.Pages.Courses
{
    public class DeleteModel : PageModel
    {
        private readonly DataModel.CollegeDbContext _context;
        private readonly CourseService _courseService;

        public DeleteModel(DataModel.CollegeDbContext context,
            ILogger<DeleteModel> logger, CourseService courseService)
        {
            _context = context;
            _courseService = courseService;
        }

        [BindProperty]
        public Course Course { get; set; }

        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Courses
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Course == null)
            {
                return NotFound();
            }
            if (Course.Active != 1)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ErrorMessage = String.Format("Delete {ID} failed. Try again", id);
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Course = await _context.Courses.FindAsync(id);

            if (Course == null)
            {
                return NotFound();
            }
            if (Course.Active != 1)
            {
                return NotFound();
            }

            await _courseService.DeleteCourse(Course);

            return RedirectToPage("./Index");
        }
    }
}
