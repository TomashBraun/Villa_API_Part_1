using Villa_API.Models.Villa;
using Villa_API.Models.VillaNumberModel;

namespace Villa_API.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
