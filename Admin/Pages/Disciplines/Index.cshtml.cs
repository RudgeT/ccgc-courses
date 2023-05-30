using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Admin.Data;
using Business.Queries.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DataModel;

namespace Admin.Pages.Disciplines
{
    public class IndexModel : PageModel
    {
        private readonly DataModel.CollegeDbContext _context;
        private readonly DisciplineService _disciplineService;
        public IndexModel(DataModel.CollegeDbContext context, DisciplineService disciplineService)
        {
            _context = context;
            _disciplineService = disciplineService;
        }

        [BindProperty(SupportsGet = true)]
        public bool DisplayTopOfPage { get; set; }
        public double LastTableContainerHeight { get; set; } = 500;
        public IList<Discipline> Discs { get; set; }
        public async Task OnGetAsync()
        {
            Discs = await _disciplineService.GetAllDisciplines();

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
