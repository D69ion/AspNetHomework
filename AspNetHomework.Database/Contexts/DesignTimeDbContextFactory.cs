using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace AspNetHomework.Database.Contexts
{
    internal sealed class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AspNetHomeworkContext>
    {
        public AspNetHomeworkContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                               .SetBasePath(Directory.GetCurrentDirectory())
                               .AddJsonFile("appsettings.json", false, true)
                               .AddUserSecrets<DesignTimeDbContextFactory>()
                               .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json",
                                        true, true)
                               .AddEnvironmentVariables()
                               .Build();
            var connectionString = configuration.GetConnectionString(nameof(AspNetHomeworkContext));
            var builder = new DbContextOptionsBuilder<AspNetHomeworkContext>().UseNpgsql(connectionString, _options =>
            {
                _options.MigrationsAssembly(typeof(AspNetHomeworkContext).Assembly.FullName);
            });
            var context = new AspNetHomeworkContext(builder.Options);
            return context;
        }
    }
}
