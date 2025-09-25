// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai — https://github.com/youruser

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;
using Portfolio.Contracts.Projects;

namespace Portfolio.Application.UseCases.Projects;

/// <summary>Tarjoaa peruspalvelut projektien noutamiseen portfoliosta.</summary>
public sealed class ProjectQueryService
{
    /// <summary>Palauttaa etusivulla korostettavat projektit.</summary>
    /// <param name="cancellationToken">Käyttäjän mahdollinen peruutuspyyntö.</param>
    /// <returns>Lista, jossa on vähintään yksi korostettava projekti.</returns>
    public Task<IReadOnlyList<ProjectSummaryDto>> GetHighlightedProjectsAsync(CancellationToken cancellationToken = default)
    {
        var projects = ImmutableArray.Create(
            new ProjectSummaryDto(
                Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                "portfolio-platform",
                "Saate sovellus",
                "Tiivis kuvaus projektista, joka esitellään etusivulla."));

        return Task.FromResult<IReadOnlyList<ProjectSummaryDto>>(projects);
    }
}
