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

namespace Business.Queries.YearLevels
{
    public class GetAllYearLevelsQueryHandler : IQueryHandler<List<YearLevelDto>>
    {
        private readonly CollegeDbContext _db;

        public GetAllYearLevelsQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<List<YearLevelDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.YearLevels
                .Select(e => new YearLevelDto()
                {
                    Id = e.Id,
                    LevelValue = e.LevelValue,
                    Active = e.Active,
                }).ToListAsync(cancellationToken);
        }
    }
}
