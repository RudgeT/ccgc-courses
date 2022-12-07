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

namespace Business.Queries.Departments
{
    public class GetAllDepartmentsQueryHandler : IQueryHandler<List<DepartmentDto>>
    {
        private readonly CollegeDbContext _db;

        public GetAllDepartmentsQueryHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public Task<List<DepartmentDto>> HandleAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return _db.Departments
                .Select(e => new DepartmentDto()
                {
                    Id = e.Id,
                    NameEng = e.NameEng,
                    NameFre = e.NameFre,
                    Active = e.Active,

                }).ToListAsync(cancellationToken);
        }
    }
}

