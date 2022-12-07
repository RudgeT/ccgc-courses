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

namespace Business.Queries.Programs
{
    public class GetAllProgramsQueryHandler : IQueryHandler<List<ProgramDto>>
    {
        private readonly CollegeDbContext _db;

        public GetAllProgramsQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<List<ProgramDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Programs
                .Select(e => new ProgramDto()
                {
                    Id = e.Id,
                    CodeEng = e.CodeEng,
                    CodeFre = e.CodeFre,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    Active = e.Active,

                }).ToListAsync(cancellationToken);
        }
    }
}
