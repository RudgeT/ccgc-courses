using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.Programs
{
    public class RemoveProgramByIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class RemoveProgramByIdCommandValidator : AbstractCommandValidator<RemoveProgramByIdCommand>
    {
        public RemoveProgramByIdCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                  .NotEmpty();
        }
    }
    public class RemoveProgramByIdCommandHandler : ICommandHandler<RemoveProgramByIdCommand>
    {
        private readonly CollegeDbContext _db;

        public RemoveProgramByIdCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(RemoveProgramByIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var program = await _db.Programs.FindAsync(command.Id);
            program.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}

