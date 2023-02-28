using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        List<Program_Year> Program_Years = new List<Program_Year>
        {
            new Program_Year
            {
                Id = 1,
                ProgramID = 6,
                YearLevelID = 1
            },
            new Program_Year
            {
                Id = 2,
                ProgramID = 6,
                YearLevelID = 2
            },
            new Program_Year
            {
                Id= 3,
                ProgramID = 2,
                YearLevelID = 1
            },
            new Program_Year
            {
                Id= 4,
                ProgramID = 4,
                YearLevelID = 1
            },
            new Program_Year
            {
                Id= 5,
                ProgramID = 4,
                YearLevelID = 2
            },
            new Program_Year {
                Id= 6,
            ProgramID = 5,
            YearLevelID = 3
            },
            new Program_Year
            {
                Id= 7,
                ProgramID = 6,
                YearLevelID = 4
            },
            new Program_Year()
            {
                Id= 8,
                ProgramID = 3,
                YearLevelID = 1
            },
            new Program_Year()
            {
                Id= 9,
                ProgramID = 4,
                YearLevelID = 1
            },
            new Program_Year
            {
                Id= 10,
                ProgramID = 5,
                YearLevelID = 2
            },
            new Program_Year
            {
                Id= 11,
                ProgramID = 1,
                YearLevelID = 1
            },
            new Program_Year
            {
                Id= 12,
                ProgramID = 5,
                YearLevelID = 1
            }

        };
    }
}
