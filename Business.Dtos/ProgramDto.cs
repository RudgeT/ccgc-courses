using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Queries.Dtos
{
    public class ProgramDto
    {
        public int Id { get; set; }
        public string CodeEng { get; set; }
        public string CodeFre { get; set; }
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public int Active { get; set; }
    }
}
