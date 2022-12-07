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

namespace Business.Queries.CourseTypes
{
    public class GetAllCourseTypesQueryHandler : IQueryHandler<List<CourseTypeDto>>
    {
        private readonly CollegeDbContext _db;

        public GetAllCourseTypesQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<List<CourseTypeDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CourseTypes
                .Select(e => new CourseTypeDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    Active = e.Active,

                }).ToListAsync(cancellationToken);
        }
    }
}
