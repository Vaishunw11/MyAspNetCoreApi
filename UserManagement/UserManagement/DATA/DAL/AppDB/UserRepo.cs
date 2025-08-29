using Microsoft.EntityFrameworkCore;
using UserManagement.BI.Mapping;
using UserManagement.Core.Contract;
using UserManagement.Core.Entity;

namespace UserManagement.DATA.DAL.AppDB
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly UserMapping _mapper;
        // private readonly ILogger<DeptRepository> _logger;


        public UserRepository(ApplicationDBContext context)
        {
            _context = context;

        }

        public async Task<int> AddUsers(Users user)
        {
            //_logger.LogInformation("Repository: Adding new User");
            _context.user.Add(user);
            await _context.SaveChangesAsync();
            return user.UserId;
        }

        public async Task<int> UpdateUser(Users user)
        {
            //_logger.LogInformation("Repository: Updating department with ID {DeptID}", dept.DepartmentID);
            _context.user.Update(user);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Users>> GetAllUsers() 
        {
            return await _context.user.Where(x => x.IsActive).ToListAsync();
        }


        public async Task<bool> DeleteUser(Users user)
        {
            user.IsActive = false;
            _context.user.Update(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}



