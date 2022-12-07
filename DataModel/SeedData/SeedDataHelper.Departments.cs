using System.Collections.Generic;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<Department> Departments = new List<Department>()
            {
                new Department
                {
                    Id = 1,
                    NameEng = "Navigation",
                    NameFre = "Navigation",
                    Active = 1
                },
                new Department
                {
                    Id = 2,
                    NameEng = "Engineering",
                    NameFre = "Ingénierie",
                    Active = 1
                },
                new Department
                {
                    Id = 3,
                    NameEng = "Arts, Sciences and Languages",
                    NameFre = "Arts, Sciences et Langues",
                    Active = 1
                },
                new Department
                {
                    Id = 4,
                    NameEng = "Superintendent of Officer Cadets",
                    NameFre = "Surintendant des élèves-officiers",
                    Active = 1
                },
                new Department
                {
                    Id = 5,
                    NameEng = "Electronics and Informatics Technical Training",
                    NameFre = "Formation technique en électronique et en informatique",
                    Active = 1
                },
                new Department
                {
                    Id = 6,
                    NameEng = "Marine Communications and Traffic Services",
                    NameFre = "Services de communications et de trafic maritimes",
                    Active = 1
                },
                new Department
                {
                    Id = 7,
                    NameEng = "Operational Training",
                    NameFre = "Formation opérationnelle",
                    Active = 1
                },
                new Department
                {
                    Id = 8,
                    NameEng = "Training Development",
                    NameFre = "Formation Développement",
                    Active = 1
                },
            };
    }
}
