using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using LeanTask.Application.Interfaces.Repositories;
using LeanTask.Application.Interfaces.Services.Storage;
using LeanTask.Application.Interfaces.Services.Storage.Provider;
using LeanTask.Application.Interfaces.Serialization.Serializers;
using LeanTask.Application.Serialization.JsonConverters;
using LeanTask.Infrastructure.Repositories;
using LeanTask.Infrastructure.Services.Storage;
using LeanTask.Application.Serialization.Options;
using LeanTask.Infrastructure.Services.Storage.Provider;
using LeanTask.Application.Serialization.Serializers;

namespace LeanTask.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructureMappings(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddTransient(typeof(IRepositoryAsync<,>), typeof(RepositoryAsync<,>))
                .AddTransient<IProductRepository, ProductRepository>()
                .AddTransient<IBrandRepository, BrandRepository>()
                .AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }

        public static IServiceCollection AddServerStorage(this IServiceCollection services)
            => AddServerStorage(services, null);

        public static IServiceCollection AddServerStorage(this IServiceCollection services, Action<SystemTextJsonOptions> configure)
        {
            return services
                .AddScoped<IJsonSerializer, SystemTextJsonSerializer>()
                .AddScoped<IStorageProvider, ServerStorageProvider>()
                .AddScoped<IServerStorageService, ServerStorageService>()
                .AddScoped<ISyncServerStorageService, ServerStorageService>()
                .Configure<SystemTextJsonOptions>(configureOptions =>
                {
                    configure?.Invoke(configureOptions);
                    if (!configureOptions.JsonSerializerOptions.Converters.Any(c => c.GetType() == typeof(TimespanJsonConverter)))
                        configureOptions.JsonSerializerOptions.Converters.Add(new TimespanJsonConverter());
                });
        }
    }
}