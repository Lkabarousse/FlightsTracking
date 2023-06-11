using FlightsTracking.Web.Services;

namespace FlightsTracking.Web
{
    public static class UIContainer
    {
        public static IServiceCollection AddUIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IHttpClientWrapper<>), typeof(HttpClientWrapper<>));
            return services;
        }
    }
}
