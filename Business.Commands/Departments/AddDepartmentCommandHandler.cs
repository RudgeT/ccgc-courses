using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using FluentValidation;

namespace Business.Commands.Departments
{
    public class AddDepartmentCommand : IQuery<int>
    {
        public string NameEng { get; set; }
        public string NameFre { get; set; }
    }
    public class AddDepartmentCommandHandler : IQueryHandler<AddDepartmentCommand, int>
    {
        private readonly CollegeDbContext _db;

        public AddDepartmentCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task<int> HandleAsync(AddDepartmentCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var newDepartment = new Department()
            {
                NameEng = command.NameEng,
                NameFre = command.NameFre,
                Active = 1
            };
            await _db.Departments.AddAsync(newDepartment, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return newDepartment.Id;
        }

    }
}
