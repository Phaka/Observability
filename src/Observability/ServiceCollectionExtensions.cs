namespace Observability
{
    using Abstractions;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static void AddObservability(this IServiceCollection services)
        {
            services.AddTransient<ICollector, ProcessCollector>();
            services.AddTransient<IAssemblyProvider, DefaultAssemblyProvider>();
        }
    }
}