using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Interfaces
{
    public interface IRoleService
    {
        Task<IdentityResult> CreateRoleAsync(string roleName);
        Task<IEnumerable<string>> GetAllRolesAsync();
        Task<IdentityResult> UpdateRoleAsync(string roleId, string roleName);
        Task<IdentityResult> DeleteRoleAsync(string roleId);
        Task<IdentityResult> AssignRoleToUserAsync(string userId, string roleName);
        Task<IdentityResult> RemoveRoleFromUserAsync(string userId, string roleName);
    }
}
