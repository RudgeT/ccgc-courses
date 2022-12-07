using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using FluentValidation;

namespace Business.Commands.Courses
{
    public class AddCourseCommand : IQuery<int>
    {
        public string Code { get; set; }
        public string TitleEng { get; set; }
        public string TitleFre { get; set; }
        public string DescEng { get; set; }
        public string DescFre { get; set; }
        public string LangEng { get; set; }
        public string LangFre { get; set; }
        public string Hours { get; set; }
    }

    public class AddCourseCommandHandler : IQueryHandler<AddCourseCommand, int>
    {
        private readonly CollegeDbContext _db;

        public AddCourseCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task<int> HandleAsync(AddCourseCommand command, CancellationToken cancellationToken = new CancellationToken())
        {

            var newCourse = new Course()
            {
                Code = command.Code,
                TitleEng = command.TitleEng,
                TitleFre = command.TitleFre,
                DescEng = command.DescEng,
                DescFre = command.DescFre,
                LangEng = command.LangEng,
                LangFre = command.LangFre,
                Hours = command.Hours,
                Active = 1
            };
            await _db.Courses.AddAsync(newCourse, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return newCourse.Id;
        }

    }
}