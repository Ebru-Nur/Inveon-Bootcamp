using AutoMapper;
using LibraryManagement.Dto;
using LibraryManagement.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagement.Services
{
    public class UserService: IUserService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<IdentityUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> CreateUserAsync(UserDto userDto, string password)
        {
            var user = _mapper.Map<IdentityUser>(userDto);
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<UserDto> GetUserByIdAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            return _mapper.Map<UserDto>(user);
        }

        public async Task<IdentityResult> UpdateUserAsync(string userId, UserDto userDto)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });
            }

            _mapper.Map(userDto, user);
            return await _userManager.UpdateAsync(user);
        }

        public async Task<IdentityResult> DeleteUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return IdentityResult.Failed(new IdentityError { Description = "User not found" });
            }

            return await _userManager.DeleteAsync(user);
        }
    }
}
