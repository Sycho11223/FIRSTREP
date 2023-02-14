using FIRSTREP.API.Models.Domains;

namespace FIRSTREP.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();

    }
}
