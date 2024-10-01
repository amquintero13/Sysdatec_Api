using Prueba_Sysdatec.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prueba_Sysdatec.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task AddUserAsync(User user);
        Task<bool> UserExistsAsync(int id);
    }
}
