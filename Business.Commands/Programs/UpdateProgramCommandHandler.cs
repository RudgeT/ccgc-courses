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

namespace Business.Commands.Programs
{
    public class UpdateProgramCommandHandler : ICommand
    {
        public int Id { get; set; }
        public string CodeEng { get; set; }
        public string CodeFre { get; set; }
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public int Active { get; set; }
    }
    public class UpdateProgramCommandValidator : AbstractCommandValidator<UpdateProgramCommandHandler>
    {
        public UpdateProgramCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .Must(e => db.Programs.Any(c => c.Id == e)).WithLocalizedStringMessage(typeof(Core.Resources.Validation), "NotFound")
                ;
            RuleFor(e => e.CodeEng)
                .MaximumLength(50);

            RuleFor(e => e.CodeFre)
                .MaximumLength(50);

            RuleFor(e => e.NameEng)
                .MaximumLength(1000);

            RuleFor(e => e.NameFre)
                .MaximumLength(1000);
        }
    }
    public class ProgramCommandHandler : ICommandHandler<UpdateProgramCommandHandler>
    {
        private readonly CollegeDbContext _db;

        public ProgramCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateProgramCommandHandler command, CancellationToken cancellationToken = new CancellationToken())
        {
            var program = _db.Programs.First(e => e.Id == command.Id);
            program.CodeEng = string.IsNullOrEmpty(command.CodeEng) ? string.Empty : command.CodeEng;
            program.CodeFre = string.IsNullOrEmpty(command.CodeFre) ? string.Empty : command.CodeFre;
            program.NameEng = string.IsNullOrEmpty(command.NameEng) ? string.Empty : command.NameEng;
            program.NameFre = string.IsNullOrEmpty(command.NameFre) ? string.Empty : command.NameFre;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}
