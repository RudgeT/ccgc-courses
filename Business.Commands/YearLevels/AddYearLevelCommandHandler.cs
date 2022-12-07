using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business.Commands.YearLevels
{
    public class AddYearLevelCommand : IQuery<int>
    {
        public string LevelValue { get; set; }
    }
    public class AddYearLevelCommandHandler : IQueryHandler<AddYearLevelCommand, int>
    {
        private readonly CollegeDbContext _db;

        public AddYearLevelCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task<int> HandleAsync(AddYearLevelCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var newYearLevel = new YearLevel()
            {
                LevelValue = command.LevelValue,
                Active = 1
            };
            await _db.YearLevels.AddAsync(newYearLevel, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return newYearLevel.Id;
        }

    }
}
