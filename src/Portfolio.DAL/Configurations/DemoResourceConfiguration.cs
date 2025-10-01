// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.DAL.Entities;

namespace Portfolio.DAL.Configurations;

/// <summary>
///     Configures the <see cref="DemoResource"/> entity for EF Core.
/// </summary>
public sealed class DemoResourceConfiguration : IEntityTypeConfiguration<DemoResource>
{
    /// <summary>
    ///     Applies basic keys and constraints for <see cref="DemoResource"/> until the schema stabilises.
    /// </summary>
    /// <param name="builder">Entity builder.</param>
    public void Configure(EntityTypeBuilder<DemoResource> builder)
    {
        // TODO: Tune configuration (indexes, constraints, seed data).
        builder.HasKey(resource => resource.Id);
        builder.Property(resource => resource.Name).HasMaxLength(200);
    }
}
