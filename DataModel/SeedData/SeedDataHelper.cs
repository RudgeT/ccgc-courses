using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataModel.SeedData
{
    public partial class SeedDataHelper
    {
        private readonly CollegeDbContext _db;

        public SeedDataHelper(CollegeDbContext db)
        {
            _db = db;
        }

        public async Task Run()
        {
            // base tables
            await AddIfEmpty(Disciplines);
            await AddIfEmpty(Departments);
            await AddIfEmpty(CourseTypes);
            await AddIfEmpty(Programs);
            await AddIfEmpty(YearLevels);
            await AddIfEmpty(Courses);

            // link tables

        }

        private async Task AddIfEmpty<TModel>(List<TModel> models, bool hasIdentityKey = true) where TModel : class
        {
            if (await _db.Set<TModel>().AnyAsync()) return;
            var strategy = _db.Database.CreateExecutionStrategy();
            await strategy.ExecuteAsync(async () =>
            {
                await using var transaction = await _db.Database.BeginTransactionAsync();
                await _db.Set<TModel>().AddRangeAsync(models);
                await Save<TModel>(hasIdentityKey);
                await transaction.CommitAsync();
            });
        }


        private async Task Save<T>(bool hasIdentityKey) where T : class
        {
            var tableName = _db.Model.FindEntityType(typeof(T)).GetTableName();
            try
            {
                if (hasIdentityKey)
                {
                    await _db.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT {tableName} ON;");
                }
                await _db.SaveChangesAsync();
            }
            finally
            {
                if (hasIdentityKey)
                {

                    await _db.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT {tableName} OFF;");
                }
            }

        }
    }
}
