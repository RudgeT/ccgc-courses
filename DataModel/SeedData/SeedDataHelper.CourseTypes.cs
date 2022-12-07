using System.Collections.Generic;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<CourseType> CourseTypes = new List<CourseType>()
            {
                new CourseType
                {
                    Id = 1,
                    NameEng = "Engineering",
                    NameFre = "Ingénierie",
                    Active = 1
                },
                new CourseType
                {
                    Id = 2,
                    NameEng = "Instructor Training",
                    NameFre = "Formation d'instructeur",
                    Active = 1
                },
                new CourseType
                {
                    Id = 3,
                    NameEng = "Languages",
                    NameFre = "Langages",
                    Active = 1
                },
                new CourseType
                {
                    Id = 4,
                    NameEng = "Leadership and Training",
                    NameFre = "Direction et formation",
                    Active = 1
                },
                new CourseType
                {
                    Id = 5,
                    NameEng = "Mathematics and Science",
                    NameFre = "Mathématiques et sciences",
                    Active = 1
                },
                new CourseType
                {
                    Id = 6,
                    NameEng = "Navigation",
                    NameFre = "La navigation",
                    Active = 1
                },
                new CourseType
                {
                    Id = 7,
                    NameEng = "Quality Assurance",
                    NameFre = "Assurance qualité",
                    Active = 1
                },
            };
    }
}
