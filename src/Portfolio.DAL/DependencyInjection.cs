// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.DAL.Repositories;

namespace Portfolio.DAL;

/// <summary>
///     Extension methods for registering data access services.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    ///     Registers the EF Core context and repository placeholders.
    /// </summary>
    /// <param name="services">Service collection being built.</param>
    /// <param name="configuration">Application configuration (reserved for future use).</param>
    /// <returns>The same service collection for chaining.</returns>
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        // TODO: Move to persistent storage once connection strings are defined.
        services.AddDbContext<PortfolioDbContext>(options =>
            options.UseInMemoryDatabase("PortfolioPreview"));

        services.AddScoped<IDemoResourceRepository, DemoResourceRepository>();

        return services;
    }
}
