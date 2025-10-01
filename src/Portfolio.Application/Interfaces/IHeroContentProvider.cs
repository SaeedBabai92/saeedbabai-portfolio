// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using System.Threading;
using System.Threading.Tasks;
using Portfolio.Contracts.DTOs;

namespace Portfolio.Application.Interfaces;

/// <summary>
///     Provides hero content tailored for the landing page.
/// </summary>
public interface IHeroContentProvider
{
    /// <summary>
    ///     Retrieves the hero content that should be rendered on the front page.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Hero content DTO.</returns>
    // TODO: Replace with richer hero response once CMS or database is connected.
    ValueTask<SampleDto> GetHeroAsync(CancellationToken cancellationToken = default);
}
