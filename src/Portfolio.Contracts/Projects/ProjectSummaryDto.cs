// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai — https://github.com/youruser

using System;

namespace Portfolio.Contracts.Projects;

/// <summary>Projektin julkaistava peruskuvaus.</summary>
/// <param name="Id">Yksilöivä tunniste, jota käytetään integraatioissa.</param>
/// <param name="Slug">Hakukoneystävällinen polkutunniste.</param>
/// <param name="Title">Nimi, joka näytetään käyttöliittymässä.</param>
/// <param name="Summary">Lyhyt johdanto projektin sisältöön.</param>
public sealed record ProjectSummaryDto(Guid Id, string Slug, string Title, string Summary);
