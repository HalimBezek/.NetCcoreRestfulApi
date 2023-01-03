using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries{ get; set; }

        //when model is creating do this 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                      Id=1,
                      Name="Ramada",
                      ShortName="RM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Mahama",
                    ShortName = "MH"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name="Butik",
                    Address="istanbul",
                    Rating =5,
                    CountryId =1                   
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel",
                    Address = "istanbul",
                    Rating = 4,
                    CountryId = 2
                }
                );
        }


    }
}
