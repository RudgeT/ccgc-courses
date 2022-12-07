using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCG.AspNetCore.Business.Interface;
using DataModel;
using FluentValidation;

namespace Business.Commands.CourseTypes
{
    public class AddCourseTypeCommand : IQuery<int>
    {
        public string NameEng { get; set; }
        public string NameFre { get; set; }
    }

    public class AddCourseTypeCommandHandler : IQueryHandler<AddCourseTypeCommand, int>
    {
        private readonly CollegeDbContext _db;

        public AddCourseTypeCommandHandler(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task<int> HandleAsync(AddCourseTypeCommand command, CancellationToken cancellationToken = new CancellationToken())
        {

            var newCourseType = new CourseType()
            {
                NameEng = command.NameEng,
                NameFre = command.NameFre,
                Active = 1
            };
            await _db.CourseTypes.AddAsync(newCourseType, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return newCourseType.Id;
        }

    }
}