using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Business.Queries.Dtos;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Business.Queries.Program_Year
{
    public class GetAllProgramYearsQueryHandler : IQueryHandler<List<Program_YearDto>>
    {
        private readonly CollegeDbContext _db;

        public GetAllProgramYearsQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }
        public Task<List<Program_YearDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Program_Years.Select(e => new Program_YearDto()
            {
                Id = e.Id,
                ProgramID = e.ProgramID,
                YearLevelID = e.YearLevelID,
            }).ToListAsync(cancellationToken);
        }
    }
}
