using System.ComponentModel.DataAnnotations;
using UserManagement.Enum;

namespace UserManagement.Core.DTO
{
    public class UserDTO
    {
        [Key]

        public int UserId { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }

        public string? Role { get; set; }

        public bool IsActive { get; set; }
    }

    public class UserListResponse<T>
    {
        public EnumResponse Result { get; set; }

        public T? Data { get; set; }

    }
}
