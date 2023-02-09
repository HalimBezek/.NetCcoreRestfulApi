using HotelListingApi.Data;
using HotelListingApi.RepositoryContracts;

namespace HotelListingApi.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(HotelListingDbContext dbContext) : base(dbContext)
        {
        }
    }
}
