using TechChallenge.Application.Services;
using TechChallenge.Domain.Interfaces;
using TechChallenge.Domain.Services;

namespace TechChallenge.Services.Api.Configurations
{
   public static class DomainConfig
   {
        public static void AddDomainConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<ICursoDomainService, CursoDomainService>();
   
        }
   }
}
