using HotelListingApi.Data;
using HotelListingApi.RepositoryContracts;

namespace HotelListingApi.Repository
{
    public class CountriesRepository : GenericRepository<Country> , ICountryRepository
    {
        public CountriesRepository(HotelListingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
