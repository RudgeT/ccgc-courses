using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataModel
{
    public class CollegeDbContextFactory : IDesignTimeDbContextFactory<CollegeDbContext>
    {
        public CollegeDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CollegeDbContext> builder = new DbContextOptionsBuilder<CollegeDbContext>();

            var accessor = new HttpContextAccessor { HttpContext = new DefaultHttpContext() };

            return new CollegeDbContext(builder.Options, accessor);
        }
    }
}