using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Entities
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
