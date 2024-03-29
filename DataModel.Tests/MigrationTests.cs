﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Xunit;
using Xunit.Extensions.AssertExtensions;

namespace DataModel.Tests
{
    public class MigrationTests
    {

        [Fact]
        public async Task CanCreate()
        {
            var dbHelper = new DbHelper<CollegeDbContext>();
            await using var db = dbHelper.GetDbContext();
            await db.Database.EnsureCreatedAsync();
        }
    }
}
