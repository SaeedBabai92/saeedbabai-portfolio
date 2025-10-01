// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser
using Portfolio.Application;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Interfaces;
using Portfolio.Application.Services;
using Portfolio.DAL;

namespace Portfolio.Application;

/// <summary>
///     Extension methods for wiring the application layer.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    ///     Registers application services and forwards dependencies to the DAL.
    /// </summary>
    /// <param name="services">Service collection.</param>
    /// <param name="configuration">Application configuration.</param>
    /// <returns>The same service collection to allow chaining.</returns>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        // TODO: Register MediatR, caching, and pipeline behaviors when they exist.
        services.AddScoped<IHeroContentProvider, HeroContentProvider>();

        services.AddDataAccessServices(configuration);

        return services;
    }
}
