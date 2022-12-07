using System;
using System.Collections.Generic;
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
    public class GetProgramByIdQuery : IQuery<ProgramDto>
    {
        public int Id { get; set; }
    }

    public class GetProgramsByIdQueryHandler : IQueryHandler<GetProgramByIdQuery, ProgramDto>
    {
        private readonly CollegeDbContext _db;

        public GetProgramsByIdQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<ProgramDto> HandleAsync(GetProgramByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Programs.Where(e => e.Id == query.Id)
                .Select(e => new ProgramDto()
                {
                    Id = e.Id,
                    CodeEng = e.CodeEng,
                    CodeFre = e.CodeFre,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    Active = e.Active
                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}

