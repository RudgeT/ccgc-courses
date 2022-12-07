using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class YearLevel
    {
        public int Id { get; set; }
        public string LevelValue { get; set; } // ex. "1", "2"
        public int Active { get; set; }
    }
}
