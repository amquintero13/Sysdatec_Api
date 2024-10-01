using Microsoft.EntityFrameworkCore;
using Prueba_Sysdatec.Data;
using Prueba_Sysdatec.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Prueba_Sysdatec.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        // Obtener el listado de usuarios
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        // Obrtener un usuario por su Id
        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        // Agregar un usuario
        public async Task AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        // Verificar existencia de un usuario
        public async Task<bool> UserExistsAsync(int id)
        {
            return await _context.Users.AnyAsync(u => u.Id == id);
        }
    }
}
