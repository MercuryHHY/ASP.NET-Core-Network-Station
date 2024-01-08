using Microsoft.EntityFrameworkCore;

namespace CommonInitializer
{
    public static class DbContextOptionsBuilderFactory
    {
        public static DbContextOptionsBuilder<TDbContext> Create<TDbContext>()
            where TDbContext : DbContext
        {
            var connStr = Environment.GetEnvironmentVariable("DefaultDB:ConnStr");
            var optionsBuilder = new DbContextOptionsBuilder<TDbContext>();
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=YouzackVNextDB;User ID=sa;Password=dLLikhQWy5TBz1uM;");
            
            //改用MySQL
            //optionsBuilder.UseSqlServer(connStr);
            optionsBuilder.UseMySql(connStr, new MySqlServerVersion(new Version(8, 6, 26)));
            return optionsBuilder;
        }
    }
}
