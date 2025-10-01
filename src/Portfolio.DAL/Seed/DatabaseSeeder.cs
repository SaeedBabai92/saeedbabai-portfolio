// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.DAL.Seed;

/// <summary>
///     Seeds the database with preview data when required.
/// </summary>
public static class DatabaseSeeder
{
    /// <summary>
    ///     Executes seeding logic for the portfolio database.
    /// </summary>
    /// <param name="context">Database context.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A task representing the seeding workflow.</returns>
    public static async Task SeedAsync(PortfolioDbContext context, CancellationToken cancellationToken = default)
    {
        // TODO: Seed reference data when schema is locked.
        await Task.CompletedTask;
    }
}
