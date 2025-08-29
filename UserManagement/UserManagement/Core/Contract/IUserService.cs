using UserManagement.Core.DTO;

public interface IUserService
{
    Task<UserListResponse<UserDTO>> AddOrUpdateUsers(int id, UserDTO userdto);
    Task<UserListResponse<bool>> DeleteUser(int id);
    Task<UserListResponse<List<UserDTO>>> GetAllUsers();
}
