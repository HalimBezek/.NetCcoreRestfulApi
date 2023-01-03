﻿using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries{ get; set; }
    }
}
