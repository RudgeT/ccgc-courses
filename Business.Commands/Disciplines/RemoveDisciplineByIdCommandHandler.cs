using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.Disciplines
{
    public class RemoveDisciplineByIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class RemoveDisciplineByIdCommandValidator : AbstractCommandValidator<RemoveDisciplineByIdCommand>
    {
        public RemoveDisciplineByIdCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                  .NotEmpty();
        }
    }
    public class RemoveDisciplineByIdCommandHandler : ICommandHandler<RemoveDisciplineByIdCommand>
    {
        private readonly CollegeDbContext _db;

        public RemoveDisciplineByIdCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(RemoveDisciplineByIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var discipline = await _db.Disciplines.FindAsync(command.Id);
            discipline.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
