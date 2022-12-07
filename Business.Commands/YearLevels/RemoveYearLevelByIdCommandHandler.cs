using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.YearLevels
{
    public class RemoveYearLevelByIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class RemoveYearLevelByIdCommandValidator : AbstractCommandValidator<RemoveYearLevelByIdCommand>
    {
        public RemoveYearLevelByIdCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                  .NotEmpty();
        }
    }
    public class RemoveYearLevelByIdCommandHandler : ICommandHandler<RemoveYearLevelByIdCommand>
    {
        private readonly CollegeDbContext _db;

        public RemoveYearLevelByIdCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(RemoveYearLevelByIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var yearlevel = await _db.YearLevels.FindAsync(command.Id);
            yearlevel.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}

