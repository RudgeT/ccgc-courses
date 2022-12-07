using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.CourseTypes
{
    public class RemoveCourseTypeByIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class RemoveCourseTypeByIdCommandValidator : AbstractCommandValidator<RemoveCourseTypeByIdCommand>
    {
        public RemoveCourseTypeByIdCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                  .NotEmpty();
        }
    }
    public class RemoveCourseTypeByIdCommandHandler : ICommandHandler<RemoveCourseTypeByIdCommand>
    {
        private readonly CollegeDbContext _db;

        public RemoveCourseTypeByIdCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(RemoveCourseTypeByIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var coursetype = await _db.CourseTypes.FindAsync(command.Id);
            coursetype.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}

