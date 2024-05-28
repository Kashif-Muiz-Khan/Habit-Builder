using Microsoft.AspNetCore.Identity;

namespace ALevelBlazorTemplate.Model
{
    public class User : IdentityUser
    {

        public List<Order> Orders { get; set; } = [];

    }
}
