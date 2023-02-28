using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Program_Year
    {
        public int Id { get; set; }
        public int ProgramID { get; set; }
        public Program Program { get; set; }
        public int YearLevelID { get; set; }
        public YearLevel YearLevel { get; set; }

    }
}
