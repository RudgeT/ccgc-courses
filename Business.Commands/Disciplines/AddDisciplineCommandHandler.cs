using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business.Commands.Disciplines
{
    public class AddDisciplineCommand : IQuery<int>
    {
        public string NameEng { get; set; }
        public string NameFre { get; set; }
    }
    public class AddDisciplineCommandHandler : IQueryHandler<AddDisciplineCommand, int>
    {
        private readonly CollegeDbContext _db;

        public AddDisciplineCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task<int> HandleAsync(AddDisciplineCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var newDiscipline = new Discipline()
            {
                NameEng = command.NameEng,
                NameFre = command.NameFre,
                Active = 1
            };
            await _db.Disciplines.AddAsync(newDiscipline, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return newDiscipline.Id;
        }

    }
}
