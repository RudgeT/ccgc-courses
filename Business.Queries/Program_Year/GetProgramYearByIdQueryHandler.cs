using Business.Queries.Dtos;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business.Queries.Program_Year
{
    public class GetProgramYearByIdQuery: IQuery<Program_YearDto>
    {
        public int Id { get; set; }
    }
    public class GetProgramYearByIdQueryHandler : IQueryHandler<GetProgramYearByIdQuery, Program_YearDto>
    {
        private readonly CollegeDbContext _db;

        public GetProgramYearByIdQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<Program_YearDto> HandleAsync(GetProgramYearByIdQuery query,CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Program_Years.Where(e => e.Id == query.Id)
                .Select(e => new Program_YearDto()
                {
                    Id = e.Id,
                    ProgramID = e.ProgramID,
                    YearLevelID = e.YearLevelID
                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}
