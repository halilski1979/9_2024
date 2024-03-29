using Microsoft.AspNetCore.Identity;

namespace WebEventuresUser.Data.Domain
{
    public class EventuresUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
