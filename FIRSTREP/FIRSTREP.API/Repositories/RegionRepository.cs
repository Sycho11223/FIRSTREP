using FIRSTREP.API.Data;
using FIRSTREP.API.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace FIRSTREP.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly FIRSTREPDbContext fIRSTREPDbContext;

        public RegionRepository(FIRSTREPDbContext fIRSTREPDbContext)
        {
            this.fIRSTREPDbContext = fIRSTREPDbContext;
        }
        public async Task<IEnumerable<Region>>GetAllAsync()
        {
            return await fIRSTREPDbContext.Regions.ToListAsync(); 
        }
    }
}
