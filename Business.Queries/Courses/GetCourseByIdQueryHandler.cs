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

namespace Business.Queries.Courses
{
    public class GetCourseByIdQuery : IQuery<CourseDto>
    {
        public int Id { get; set; }
    }

    public class GetCourseByIdQueryHandler : IQueryHandler<GetCourseByIdQuery, CourseDto>
    {
        private readonly CollegeDbContext _db;

        public GetCourseByIdQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<CourseDto> HandleAsync(GetCourseByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Courses.Where(e => e.Id == query.Id)
                .Select(e => new CourseDto()
                {
                    Id = e.Id,
                    Code = e.Code,
                    TitleEng = e.TitleEng,
                    TitleFre = e.TitleFre,
                    DescEng = e.DescEng,
                    DescFre = e.DescFre,
                    LangEng = e.LangEng,
                    LangFre = e.LangFre,
                    Hours = e.Hours,
                    Active = e.Active
                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}
