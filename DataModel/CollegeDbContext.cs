using Audit.EntityFramework;
using CCG.AspNetCore.Data;
using CCG.AspNetCore.Data.Audit;
using CCG.AspNetCore.Data.Auth.Model;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using DataModel.Configurations;

namespace DataModel
{
    public class CollegeDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CollegeDbContext(DbContextOptions<CollegeDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<YearLevel> YearLevels { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(CollegeDbContext).Assembly);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CCGCcourses;Trusted_Connection=True;");
            optionsBuilder.EnableSensitiveDataLogging();
        }
        
    }
}
