using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Common.Configuration;

namespace Core
{
    public class CourseApplicationConfiguration : ApplicationConfiguration
    {
        public bool MigrationsOnStartup { get; set; }
    }
}

