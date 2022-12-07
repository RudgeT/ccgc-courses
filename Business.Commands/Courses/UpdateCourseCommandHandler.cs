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

namespace Business.Commands.Courses
{
    public class UpdateCourseCommandHandler : ICommand
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string TitleEng { get; set; }
        public string TitleFre { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
        public string LangEng { get; set; }
        public string LangFre { get; set; }
        public string Hours { get; set; }
        public int Active { get; set; }
    }

    public class UpdateCourseCommandValidator : AbstractCommandValidator<UpdateCourseCommandHandler>
    {
        public UpdateCourseCommandValidator(CollegeDbContext db)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .Must(e => db.Courses.Any(c => c.Id == e)).WithLocalizedStringMessage(typeof(Core.Resources.Validation), "NotFound")
                ;

            RuleFor(e => e.Code)
                .MaximumLength(50); ;

            RuleFor(e => e.TitleEng)
                .MaximumLength(1000);

            RuleFor(e => e.TitleFre)
                .MaximumLength(1000);

            RuleFor(e => e.DescEng)
                .MaximumLength(4000);

            RuleFor(e => e.DescFre)
                .MaximumLength(4000);
            
            RuleFor(e => e.LangEng)
                .MaximumLength(100);

            RuleFor(e => e.LangFre)
                .MaximumLength(100);

            RuleFor(e => e.Hours)
                .MaximumLength(30);

        }
    }
    public class CourseCommandHandler : ICommandHandler<UpdateCourseCommandHandler>
    {
        private readonly CollegeDbContext _db;

        public CourseCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task ExecuteAsync(UpdateCourseCommandHandler command, CancellationToken cancellationToken = new CancellationToken())
        {
            var course = _db.Courses.First(e => e.Id == command.Id);
            course.Code = string.IsNullOrEmpty(command.Code) ? string.Empty : command.Code;
            course.TitleEng = string.IsNullOrEmpty(command.TitleEng) ? string.Empty : command.TitleEng;
            course.TitleFre = string.IsNullOrEmpty(command.TitleFre) ? string.Empty : command.TitleFre;
            course.DescEng = string.IsNullOrEmpty(command.DescEng) ? string.Empty : command.DescEng;
            course.DescFre = string.IsNullOrEmpty(command.DescFre) ? string.Empty : command.DescFre;
            course.LangEng = string.IsNullOrEmpty(command.LangEng) ? string.Empty : command.LangEng;
            course.LangFre = string.IsNullOrEmpty(command.LangFre) ? string.Empty : command.LangFre;
            course.Hours = string.IsNullOrEmpty(command.Hours) ? string.Empty : command.Hours;
            await _db.SaveChangesAsync(cancellationToken);
        }

    }
}