using HotelListingApi.Data;

namespace HotelListingApi.RepositoryContracts
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
