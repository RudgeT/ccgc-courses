using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Queries.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DataModel;

namespace Admin.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly DataModel.CollegeDbContext _context;
        private readonly DepartmentService _departmentService;
        public IndexModel(DataModel.CollegeDbContext context, DepartmentService departmentService)
        {
            _context = context;
            _departmentService = departmentService;
        }

        [BindProperty(SupportsGet = true)]
        public bool DisplayTopOfPage { get; set; }
        public double LastTableContainerHeight { get; set; } = 500;
        public IList<Department> Departs { get; set; }
        public async Task OnGetAsync()
        {
            Departs = await _departmentService.GetAllDepartments();

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
                    if (num > 500)
                    {
                        LastTableContainerHeight = num;
                    }
                }
            }
        }
    }
}