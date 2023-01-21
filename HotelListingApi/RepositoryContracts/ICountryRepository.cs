using HotelListingApi.Data;

namespace HotelListingApi.RepositoryContracts
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Country GetCountry(int id);
    }
}
