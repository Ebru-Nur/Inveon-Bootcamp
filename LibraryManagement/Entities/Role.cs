using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Entities
{
    public class Role: IdentityRole
    {
        public string Description { get; set; }
    }
}
