using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        public List<Program> Programs = new List<Program>()
            {
                new Program
                {
                    Id = 1,
                    CodeEng = "EIIT",
                    CodeFre = "FTEI",
                    NameEng = "Electronics and Informatics Technical Training",
                    NameFre = "Formation technique électronique et informatique",
                    Active = 1
                },
                new Program
                {
                    Id = 2,
                    CodeEng = "OT",
                    CodeFre ="FO",
                    NameEng = "Operational Training",
                    NameFre = "Formation opérationnelle",
                    Active = 1
                },
                new Program
                {
                    Id = 3,
                    CodeEng = "MCTS",
                    CodeFre = "SCTM",
                    NameEng = "Marine Communicaton and Traffic Services",
                    NameFre = "Services de communications et de trafic maritimes",
                    Active = 1
                },
                new Program
                {
                    Id = 4,
                    CodeEng = "OTP-MENG",
                    CodeFre = "PFO-INGN",
                    NameEng = "Officer Training Program - Marine Engineering",
                    NameFre = "Programme de formation des officiers - Ingénierie navale",
                    Active = 1
                },
                new Program
                {
                    Id = 5,
                    CodeEng = "OTP-MNAV",
                    CodeFre = "PFO-NAVM",
                    NameEng = "Officer Training Program - Marine Navigation",
                    NameFre = "Programme de formation des officiers - Navigation maritime",
                    Active = 1
                },
                new Program
                {
                    Id = 6,
                    CodeEng = "PD",
                    CodeFre = "PP",
                    NameEng = "Professional Development",
                    NameFre = "Perfectionnement professionnel",
                    Active = 1
                },
            };
    }
}
