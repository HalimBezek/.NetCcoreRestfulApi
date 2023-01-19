using AutoMapper;
using HotelListingApi.Data;
using HotelListingApi.Models.Country;
using HotelListingApi.Models.Hotel;

namespace HotelListingApi.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
                CreateMap<Country,CreateCountryDto>().ReverseMap();
                CreateMap<Country,CountryInfoDto>().ReverseMap();
                CreateMap<Country,CountryDto>().ReverseMap();
                CreateMap<Country,UpdateCountryDto>().ReverseMap();

                CreateMap<Hotel,HotelDto>().ReverseMap();
        }
    }
}
