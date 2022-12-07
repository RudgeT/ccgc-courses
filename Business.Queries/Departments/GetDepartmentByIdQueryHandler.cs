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

namespace Business.Queries.Departments
{
    public class GetDepartmentByIdQuery : IQuery<DepartmentDto>
    {
        public int Id { get; set; }
    }

    public class GetDepartmentByIdQueryHandler : IQueryHandler<GetDepartmentByIdQuery, DepartmentDto>
    {
        private readonly CollegeDbContext _db;

        public GetDepartmentByIdQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<DepartmentDto> HandleAsync(GetDepartmentByIdQuery query, CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Departments.Where(e => e.Id == query.Id)
                .Select(e => new DepartmentDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    Active = e.Active
                }).SingleOrDefaultAsync(cancellationToken);
        }
    }
}

