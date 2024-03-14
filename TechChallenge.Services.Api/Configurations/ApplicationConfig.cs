using Microsoft.Extensions.DependencyInjection;
using TechChallenge.Application.Interfaces;
using TechChallenge.Application.Services;

namespace TechChallenge.Services.Api.Configurations
{
    public static class ApplicationConfig
    {
        public static void AddApplicationConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ICursoAppService, CursoAppService>();
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
        }
    }
}
