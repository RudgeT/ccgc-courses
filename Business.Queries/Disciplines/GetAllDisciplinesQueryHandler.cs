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

namespace Business.Queries.Disciplines
{
    public class GetAllDisciplinesQueryHandler : IQueryHandler<List<DisciplineDto>>
    {
        private readonly CollegeDbContext _db;

        public GetAllDisciplinesQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<List<DisciplineDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Disciplines
                .Select(e => new DisciplineDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    Active = e.Active,

                }).ToListAsync(cancellationToken);
        }
    }
}

