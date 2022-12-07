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

namespace Business.Queries.CourseTypes
{
    public class GetCourseTypeByIdQuery : IQuery<CourseTypeDto>
    {
        public int Id { get; set; }
    }

    public class GetCourseTypeByIdQueryHandler : IQueryHandler<GetCourseTypeByIdQuery, CourseTypeDto>
    {
        private readonly CollegeDbContext _db;

        public GetCourseTypeByIdQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<CourseTypeDto> HandleAsync(GetCourseTypeByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.CourseTypes.Where(e => e.Id == query.Id)
                .Select(e => new CourseTypeDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    Active = e.Active
                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}

