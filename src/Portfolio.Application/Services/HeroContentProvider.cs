// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using System.Threading;
using System.Threading.Tasks;
using Portfolio.Application.Interfaces;
using Portfolio.Contracts.DTOs;

namespace Portfolio.Application.Services;

/// <summary>
///     Temporary hero content provider returning placeholder data.
/// </summary>
public sealed class HeroContentProvider : IHeroContentProvider
{
    /// <inheritdoc />
    public ValueTask<SampleDto> GetHeroAsync(CancellationToken cancellationToken = default)
    {
        // TODO: Fetch hero content from DAL or CMS when connected.
        var hero = new SampleDto
        {
            Title = "Placeholder hero",
            Summary = "Introduce your signature message here.",
        };

        return ValueTask.FromResult(hero);
    }
}
