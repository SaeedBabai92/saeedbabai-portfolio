// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using System;

namespace Portfolio.Contracts.Abstractions;

/// <summary>
///     Describes a linkable demo or resource for portfolio consumption.
/// </summary>
public interface IExternalResourceLink
{
    /// <summary>
    ///     Gets the display name for the resource.
    /// </summary>
    string Title { get; }

    /// <summary>
    ///     Gets the optional live URL for the resource.
    /// </summary>
    Uri? LiveUrl { get; }

    /// <summary>
    ///     Gets the optional source control URL for the resource.
    /// </summary>
    Uri? RepositoryUrl { get; }

    // TODO: Extend with metadata such as tags once demos are curated.
}
