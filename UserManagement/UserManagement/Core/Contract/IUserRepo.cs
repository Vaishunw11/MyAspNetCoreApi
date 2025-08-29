using UserManagement.Core.Entity;

namespace UserManagement.Core.Contract
{
    public interface IUserRepository
    {
        Task<int> AddUsers(Users user);

        Task<int> UpdateUser(Users user);

        Task<List<Users>> GetAllUsers();   

        Task<bool> DeleteUser(Users user);
    }
}


