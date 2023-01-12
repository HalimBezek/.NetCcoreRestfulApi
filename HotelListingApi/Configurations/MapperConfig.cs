using AutoMapper;
using HotelListingApi.Data;
using HotelListingApi.Models.Country;

namespace HotelListingApi.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
                CreateMap<Country,CreateCountryDto>().ReverseMap();
        }
    }
}
