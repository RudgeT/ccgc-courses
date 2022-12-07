using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business.Commands.Programs
{
    public class AddProgramCommand : IQuery<int>
    {
        public string CodeEng { get; set; }
        public string CodeFre { get; set; }
        public string NameEng { get; set; }
        public string NameFre { get; set; }
    }
    public class AddProgramCommandHandler : IQueryHandler<AddProgramCommand, int>
    {
        private readonly CollegeDbContext _db;

        public AddProgramCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task<int> HandleAsync(AddProgramCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var newProgram = new Program()
            {
                CodeEng = command.CodeEng,
                CodeFre = command.CodeFre,
                NameEng = command.NameEng,
                NameFre = command.NameFre,
                Active = 1
            };
            await _db.Programs.AddAsync(newProgram, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return newProgram.Id;
        }

    }
}
