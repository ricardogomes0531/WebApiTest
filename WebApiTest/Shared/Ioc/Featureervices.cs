using Microsoft.Extensions.DependencyInjection;
using Src.Features.GetUserById;
using Src.Features.PostUser;

namespace Src.Shared.Ioc
{
    public static class Featureervices
    {
        public static IServiceCollection AddFeatureServices(this IServiceCollection services)
        {
            services.AddScoped<IGetUserByIdUseCase, GetUserByIdUseCase>()
                .AddScoped<IPostUserUseCase, PostUserUseCase>();
            return services;
        }
    }
}
