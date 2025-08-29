using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Core.Contract;
using UserManagement.Core.DTO;

namespace UserManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    public class ParentMaterialController : ControllerBase
    {
        private readonly IUserService _service;

        public ParentMaterialController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("SaveOrUpdateUsers")]
        public async Task<UserListResponse<UserDTO>> SaveOrUpdateParentMaterial([FromBody] UserDTO userdto)
        {
            return await _service.AddOrUpdateUsers(userdto.UserId, userdto);
        }

        [HttpGet("GetAllUsers")]
        public async Task<UserListResponse<List<UserDTO>>> GetAllUsers()
        {
            return await _service.GetAllUsers();
        }

        [HttpDelete("DeleteUser/{userId}")]
        public async Task<UserListResponse<bool>> DeleteUser(int userId)
        {
            return await _service.DeleteUser(userId);
        }
    }
}
