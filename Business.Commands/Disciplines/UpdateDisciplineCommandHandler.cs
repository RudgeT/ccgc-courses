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

namespace Business.Commands.Disciplines
{
    public class UpdateDisciplineCommandHandler : ICommand
    {
        public int Id { get; set; }
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public int Active { get; set; }
    }

    public class UpdateDisciplineCommandValidator : AbstractCommandValidator<UpdateDisciplineCommandHandler>
    {
        public UpdateDisciplineCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .Must(e => db.Disciplines.Any(c => c.Id == e)).WithLocalizedStringMessage(typeof(Core.Resources.Validation), "NotFound")
                ;

            RuleFor(e => e.NameEng)
                .MaximumLength(1000);

            RuleFor(e => e.NameFre)
                .MaximumLength(1000);
        }
    }
    public class DisciplineCommandHandler : ICommandHandler<UpdateDisciplineCommandHandler>
    {
        private readonly CollegeDbContext _db;

        public DisciplineCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateDisciplineCommandHandler command, CancellationToken cancellationToken = new CancellationToken())
        {
            var discipline = _db.Disciplines.First(e => e.Id == command.Id);
            discipline.NameEng = string.IsNullOrEmpty(command.NameEng) ? string.Empty : command.NameEng;
            discipline.NameFre = string.IsNullOrEmpty(command.NameFre) ? string.Empty : command.NameFre;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}