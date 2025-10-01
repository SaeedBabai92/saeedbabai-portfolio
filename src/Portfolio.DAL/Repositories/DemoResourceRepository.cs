// Licensed under the MIT License.
// See LICENSE in the project root for license information.
// (c) 2025 Saeed Babai ? https://github.com/youruser

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portfolio.DAL.Entities;

namespace Portfolio.DAL.Repositories;

internal sealed class DemoResourceRepository : IDemoResourceRepository
{
    private readonly PortfolioDbContext _dbContext;

    public DemoResourceRepository(PortfolioDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IReadOnlyList<DemoResource>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        // TODO: Apply projections or caching when dataset grows.
        return await _dbContext.Set<DemoResource>()
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }
}
