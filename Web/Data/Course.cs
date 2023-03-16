using System;

namespace Web.Data
{
    public class Course
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

        public int type { get; set; }
        public int department { get; set; }
        public int discipline { get; set; }
    }
}
