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

namespace Business.Commands.CourseTypes
{
    public class UpdateCourseTypeCommandHandler : ICommand
    {
        public int Id { get; set; }
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public int Active { get; set; }
    }

    public class UpdateCourseTypeCommandValidator : AbstractCommandValidator<UpdateCourseTypeCommandHandler>
    {
        public UpdateCourseTypeCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .Must(e => db.CourseTypes.Any(c => c.Id == e)).WithLocalizedStringMessage(typeof(Core.Resources.Validation), "NotFound")
                ;
            RuleFor(e => e.NameEng)
                .MaximumLength(1000);
            RuleFor(e => e.NameFre)
                .MaximumLength(1000);

        }
    }
    public class CourseTypeCommandHandler : ICommandHandler<UpdateCourseTypeCommandHandler>
    {
        private readonly CollegeDbContext _db;

        public CourseTypeCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateCourseTypeCommandHandler command, CancellationToken cancellationToken = new CancellationToken())
        {
            var coursetype = _db.CourseTypes.First(e => e.Id == command.Id);
            coursetype.NameEng = string.IsNullOrEmpty(command.NameEng) ? string.Empty : command.NameEng;
            coursetype.NameFre = string.IsNullOrEmpty(command.NameFre) ? string.Empty : command.NameFre;
            await _db.SaveChangesAsync(cancellationToken);
        }
    }
}