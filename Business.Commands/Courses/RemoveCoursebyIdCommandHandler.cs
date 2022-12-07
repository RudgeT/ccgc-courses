using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using CCG.AspNetCore.Business.Validator;
using DataModel;
using FluentValidation;

namespace Business.Commands.Courses
{
    public class RemoveCourseByIdCommand : ICommand
    {
        public int Id { get; set; }
    }
    public class RemoveCourseByIdCommandValidator : AbstractCommandValidator<RemoveCourseByIdCommand>
    {
        public RemoveCourseByIdCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                  .NotEmpty();
        }
    }
    public class RemoveCourseByIdCommandHandler : ICommandHandler<RemoveCourseByIdCommand>
    {
        private readonly CollegeDbContext _db;

        public RemoveCourseByIdCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(RemoveCourseByIdCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var course = await _db.Courses.FindAsync(command.Id);
            course.Active = 0;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}
