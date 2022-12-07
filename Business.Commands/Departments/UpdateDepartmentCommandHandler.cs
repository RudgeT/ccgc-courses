using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business.Commands.Departments
{
    public class UpdateDepartmentCommandHandler : ICommand
    {
        public int Id { get; set; }
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public int Active { get; set; }
    }

    public class UpdateDepartmentCommandValidator : AbstractCommandValidator<UpdateDepartmentCommandHandler>
    {
        public UpdateDepartmentCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .Must(e => db.Departments.Any(c => c.Id == e)).WithLocalizedStringMessage(typeof(Core.Resources.Validation), "NotFound")
                ;

            RuleFor(e => e.NameEng)
                .MaximumLength(1000);

            RuleFor(e => e.NameFre)
                .MaximumLength(1000);
        }
    }
    public class DepartmentCommandHandler : ICommandHandler<UpdateDepartmentCommandHandler>
    {
        private readonly CollegeDbContext _db;

        public DepartmentCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateDepartmentCommandHandler command, CancellationToken cancellationToken = new CancellationToken())
        {
            var department = _db.Departments.First(e => e.Id == command.Id);
            department.NameEng = string.IsNullOrEmpty(command.NameEng) ? string.Empty : command.NameEng;
            department.NameFre = string.IsNullOrEmpty(command.NameFre) ? string.Empty : command.NameFre;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}