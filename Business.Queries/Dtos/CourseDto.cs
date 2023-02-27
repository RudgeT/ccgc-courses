using DataModel;
using System;

namespace Business.Queries.Dtos
{
    public class CourseDto
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

        public int Type { get; set; }
        public int Department { get; set; }
        public int Discipline { get; set; }
    }
}