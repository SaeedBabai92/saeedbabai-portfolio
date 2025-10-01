// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Portfolio.DAL.Entities;

namespace Portfolio.DAL.Repositories;

/// <summary>
///     Abstraction over demo resource data access.
/// </summary>
public interface IDemoResourceRepository
{
    /// <summary>
    ///     Retrieves the available demo resources.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Resources found in the store.</returns>
    // TODO: Expand with filters after schema is finalized.
    Task<IReadOnlyList<DemoResource>> GetAllAsync(CancellationToken cancellationToken = default);
}
