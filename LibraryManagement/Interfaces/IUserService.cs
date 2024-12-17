using LibraryManagement.Dto;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsync(UserDto userDto, string password);
        Task<UserDto> GetUserByIdAsync(string userId);
        Task<IdentityResult> UpdateUserAsync(string userId, UserDto userDto);
        Task<IdentityResult> DeleteUserAsync(string userId);
    }
}
