
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TechChallenge.Domain.Interfaces;
using TechChallenge.Infra.Data.SqlServer.Contexts;
using TechChallenge.Infra.Data.SqlServer.Repositories;


namespace TechChallenge.Services.Api.Configurations
{
    public static class RepositoryConfig
    {
        public static void AddRepositoryConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

            var connectionString = builder.Configuration.GetConnectionString("BDTechChallenge");
            builder.Services.AddDbContext<SqlServerContext>
                (options => options.UseSqlServer(connectionString));
        }
    }
}
