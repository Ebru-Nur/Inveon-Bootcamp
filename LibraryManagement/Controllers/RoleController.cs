using LibraryManagement.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateRole(string roleName)
        {
            var result = await _roleService.CreateRoleAsync(roleName);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("Role created successfully");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAllRoles()
        {
            var roles = await _roleService.GetAllRolesAsync();
            return Ok(roles);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(string id, string roleName)
        {
            var result = await _roleService.UpdateRoleAsync(id, roleName);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("Role updated successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var result = await _roleService.DeleteRoleAsync(id);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("Role deleted successfully");
        }

        [HttpPost("assign")]
        public async Task<IActionResult> AssignRoleToUser(string userId, string roleName)
        {
            var result = await _roleService.AssignRoleToUserAsync(userId, roleName);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("Role assigned successfully");
        }

        [HttpPost("remove")]
        public async Task<IActionResult> RemoveRoleFromUser(string userId, string roleName)
        {
            var result = await _roleService.RemoveRoleFromUserAsync(userId, roleName);
            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("Role removed successfully");
        }
    }
}
