using Microsoft.AspNetCore.Identity;

namespace HotelListingApi.Data
{
    public class ApiUser:IdentityUser
    {
        public string FirsName{ get; set; }
        public string LastName{ get; set; }
    }
}
