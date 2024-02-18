using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileService.Infrastructure
{
    class MyDesignTimeDbContextFactory : IDesignTimeDbContextFactory<FSDbContext>
    {
        
        public FSDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<FSDbContext> builder = new();
            string connStr = Environment.GetEnvironmentVariable("DefaultDB:ConnStr");
            builder.UseMySql(connStr, new MySqlServerVersion(new Version(8, 0, 31)));
            return new FSDbContext(builder.Options, null);
        }
    }
}
