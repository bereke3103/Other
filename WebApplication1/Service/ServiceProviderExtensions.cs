namespace WebApplication1.Service
{
    public static class ServiceProviderExtensions
    {
        public static void AddTimeServices(this IServiceCollection services)
        {
            services.AddTransient<TimeService>();
        }
    }
}
