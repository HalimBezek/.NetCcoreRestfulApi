using HotelListingApi.Data;
using HotelListingApi.RepositoryContracts;
using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Repository
{
    public class CountriesRepository : GenericRepository<Country> , ICountryRepository
    {
        private readonly HotelListingDbContext _dbContext;

        public CountriesRepository(HotelListingDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Country> GetDetails(int id)
        {
           return await _dbContext.Countries.Include(q => q.Hotels).FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
