// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using System;

namespace Portfolio.DAL.Entities;

/// <summary>
///     Represents a portfolio demo resource persisted in the database.
/// </summary>
public sealed class DemoResource
{
    /// <summary>
    ///     Gets or sets the identifier.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    ///     Gets or sets a short name for the resource.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    ///     Gets or sets a short summary of the resource.
    /// </summary>
    public string? Summary { get; set; }

    // TODO: Expand entity with metadata, media, and ordering fields.
}
