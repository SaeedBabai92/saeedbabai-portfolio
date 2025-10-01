// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

namespace Portfolio.Contracts.Enums;

/// <summary>
///     Represents a simplified experience band for showcased work.
/// </summary>
// TODO: Revisit experience bands based on actual project data.
public enum ExperienceLevel
{
    /// <summary>Experience has not been categorised.</summary>
    Unknown = 0,

    /// <summary>Early-career or assisting roles.</summary>
    Junior = 1,

    /// <summary>Independent contributor with several shipped projects.</summary>
    Mid = 2,

    /// <summary>Seasoned contributor owning complex features.</summary>
    Senior = 3,

    /// <summary>Lead responsibilities such as architecture or mentoring.</summary>
    Lead = 4,
}
