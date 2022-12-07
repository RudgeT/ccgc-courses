using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.Departments
{
    public class RemoveDepartmentbyIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class RemoveDepartmentbyIdCommandValidator : AbstractCommandValidator<RemoveDepartmentbyIdCommand>
    {
        public RemoveDepartmentbyIdCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                  .NotEmpty();
        }
    }
    public class RemoveDepartmentbyIdCommandHandler : ICommandHandler<RemoveDepartmentbyIdCommand>
    {
        private readonly CollegeDbContext _db;

        public RemoveDepartmentbyIdCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(RemoveDepartmentbyIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var department = await _db.Departments.FindAsync(command.Id);
            department.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}

