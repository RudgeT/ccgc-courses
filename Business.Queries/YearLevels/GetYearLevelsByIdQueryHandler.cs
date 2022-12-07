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

namespace Business.Queries.YearLevels
{
    public class GetYearLevelByIdQuery : IQuery<YearLevelDto>
    {
        public int Id { get; set; }
    }
    public class GetYearLevelsByIdQueryHandler : IQueryHandler<GetYearLevelByIdQuery, YearLevelDto>
    {
        private readonly CollegeDbContext _db;

        public GetYearLevelsByIdQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<YearLevelDto> HandleAsync(GetYearLevelByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.YearLevels.Where(e => e.Id == query.Id)
                .Select(e => new YearLevelDto()
                {
                    Id = e.Id,
                    LevelValue = e.LevelValue,
                    Active = e.Active
                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}