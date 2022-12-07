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

namespace Business.Commands.YearLevels
{
    public class UpdateYearLevelCommandHandler : ICommand
    {
        public int Id { get; set; }
        public string LevelValue { get; set; }
        public int Active { get; set; }
    }
    public class UpdateYearLevelCommandValidator : AbstractCommandValidator<UpdateYearLevelCommandHandler>
    {
        public UpdateYearLevelCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .Must(e => db.Programs.Any(c => c.Id == e)).WithLocalizedStringMessage(typeof(Core.Resources.Validation), "NotFound")
                ;
            RuleFor(e => e.LevelValue)
                .MaximumLength(50)
                .NotEmpty();
        }
    }
    public class YearLevelCommandHandler : ICommandHandler<UpdateYearLevelCommandHandler>
    {
        private readonly CollegeDbContext _db;

        public YearLevelCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateYearLevelCommandHandler command, CancellationToken cancellationToken = new CancellationToken())
        {
            var yearlevel = _db.YearLevels.First(e => e.Id == command.Id);
            yearlevel.LevelValue = string.IsNullOrEmpty(command.LevelValue) ? string.Empty : command.LevelValue;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}
