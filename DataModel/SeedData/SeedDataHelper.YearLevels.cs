using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<YearLevel> YearLevels = new List<YearLevel>()
            {
                new YearLevel
                {
                    Id = 1,
                    LevelValue = "1",
                    Active = 1
                },
                new YearLevel
                {
                    Id = 2,
                    LevelValue = "2",
                    Active = 1
                },
                new YearLevel
                {
                    Id = 3,
                    LevelValue = "3",
                    Active = 1
                },
                new YearLevel
                {
                    Id = 4,
                    LevelValue = "4",
                    Active = 1
                },
                new YearLevel
                {
                    Id = 5,
                    LevelValue = "5",
                    Active = 1
                },
        };
    }
}
