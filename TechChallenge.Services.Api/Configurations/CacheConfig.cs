using Microsoft.Extensions.Options;
using Projeto01.Infra.Cache.MongoDb.Cotexts;
using TechChallenge.Infra.Cache.MongoDb.Cotexts;
using TechChallenge.Infra.Cache.MongoDb.Interfaces;
using TechChallenge.Infra.Cache.MongoDb.Persistence;

namespace TechChallenge.Services.Api.Configurations
{
    public static class CacheConfig
    {
        public static void AddCacheConfig(WebApplicationBuilder builder)
        {
            var mondoDBSettings = new MongoDBSettings();

            new ConfigureFromConfigurationOptions<MongoDBSettings>
                (builder.Configuration.GetSection("MongoDBSettings"))
                .Configure(mondoDBSettings);

            builder.Services.AddSingleton(mondoDBSettings);
            builder.Services.AddSingleton<MongoDBContext>();

            builder.Services.AddTransient<ICursoPersistence, CursoPersistence>();
        }
    }
}
