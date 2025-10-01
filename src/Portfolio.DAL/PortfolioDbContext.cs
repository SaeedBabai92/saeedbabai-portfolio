// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using Microsoft.EntityFrameworkCore;
using Portfolio.DAL.Configurations;
using Portfolio.DAL.Entities;

namespace Portfolio.DAL;

/// <summary>
///     EF Core database context placeholder for the portfolio.
/// </summary>
public class PortfolioDbContext : DbContext
{
    /// <summary>
    ///     Initialises a new instance of the <see cref="PortfolioDbContext"/> class.
    /// </summary>
    /// <param name="options">The options to be used by the base <see cref="DbContext"/>.</param>
    public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
        : base(options)
    {
    }

    /// <summary>
    ///     Gets the demo resources set.
    /// </summary>
    public DbSet<DemoResource> DemoResources => Set<DemoResource>();

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // TODO: Apply configurations once additional entities exist.
        modelBuilder.ApplyConfiguration(new DemoResourceConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}
