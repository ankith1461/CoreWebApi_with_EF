using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

namespace WebApiCoreEdx.Models
{
    public class WebApiCoreEdxDbContext : DbContext
    {
        public WebApiCoreEdxDbContext(DbContextOptions<WebApiCoreEdxDbContext> options) : base(options)
        {
        }

        public DbSet<Film> Film{get;set;}
    }

    public class WebApiCoreEdxDbContextFactory
    {
        public static WebApiCoreEdxDbContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebApiCoreEdxDbContext>();
            optionsBuilder.UseMySQL(connectionString);
            var webApiCoreEdxDbContext = new WebApiCoreEdxDbContext(optionsBuilder.Options);
            return webApiCoreEdxDbContext;
        }
    }
}