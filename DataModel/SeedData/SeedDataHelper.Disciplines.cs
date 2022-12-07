using System.Collections.Generic;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<Discipline> Disciplines = new List<Discipline>()
            {
                new Discipline
                {
                    Id = 1,
                    NameEng = "Common course",
                    NameFre = "Cours commun",
                    Active = 1
                },
                new Discipline
                {
                    Id = 2,
                    NameEng = "Navigation",
                    NameFre = "Navigation",
                    Active = 1
                },
                new Discipline
                {
                    Id = 3,
                    NameEng = "Engineering",
                    NameFre = "Ingénierie",
                    Active = 1
                },
                new Discipline
                {
                    Id = 4,
                    NameEng = "Electronics and Informatics Technical Training",
                    NameFre = "Formation technique en électronique et en informatique",
                    Active = 1
                },
                new Discipline
                {
                    Id = 5,
                    NameEng = "Marine Communications and Traffic Services",
                    NameFre = "Services de communications et de trafic maritimes",
                    Active = 1
                },
                new Discipline
                {
                    Id = 6,
                    NameEng = "Operational Training",
                    NameFre = "Formation opérationnelle",
                    Active = 1
                },
                new Discipline
                {
                    Id = 7,
                    NameEng = "Navigation & Engineering",
                    NameFre = "Navigation et ingénierie",
                    Active = 1
                },
            };
    }
}
