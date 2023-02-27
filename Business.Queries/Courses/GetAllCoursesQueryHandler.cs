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

namespace Business.Queries.Courses
{
    public class GetAllCoursesQueryHandler : IQueryHandler<List<CourseDto>>
    {
        private readonly CollegeDbContext _db;

        public GetAllCoursesQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<List<CourseDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Courses
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
                    Active = e.Active,
                    Type = e.TypeID,
                    Discipline = e.DisciplineID,
                    Department = e.DepartmentID


                }).ToListAsync(cancellationToken);
        }
    }
}
