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

namespace Business.Queries.Disciplines
{
    public class GetDisciplineByIdQuery : IQuery<DisciplineDto>
    {
        public int Id { get; set; }
    }

    public class GetDisciplinesByIdQueryHandler : IQueryHandler<GetDisciplineByIdQuery, DisciplineDto>
    {
        private readonly CollegeDbContext _db;

        public GetDisciplinesByIdQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<DisciplineDto> HandleAsync(GetDisciplineByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Disciplines.Where(e => e.Id == query.Id)
                .Select(e => new DisciplineDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    Active = e.Active
                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}


