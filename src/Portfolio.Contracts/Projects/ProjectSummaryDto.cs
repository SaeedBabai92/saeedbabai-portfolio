// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai � https://github.com/youruser

using System;

namespace Portfolio.Contracts.Projects;

/// <summary>Projektin julkaistava peruskuvaus.</summary>
/// <param name="Id">Yksil�iv� tunniste, jota k�ytet��n integraatioissa.</param>
/// <param name="Slug">Hakukoneyst�v�llinen polkutunniste.</param>
/// <param name="Title">Nimi, joka n�ytet��n k�ytt�liittym�ss�.</param>
/// <param name="Summary">Lyhyt johdanto projektin sis�lt��n.</param>
public sealed record ProjectSummaryDto(Guid Id, string Slug, string Title, string Summary);
