using Microsoft.Extensions.DependencyInjection;
using Src.Features.GetUserById;

namespace Src.Shared.Ioc
{
    public static class Featureervices
    {
        public static IServiceCollection AddFeatureServices(this IServiceCollection services)
        {
            services.AddScoped<IGetUserByIdUseCase, GetUserByIdUseCase>();
            return services;
        }
    }
}
