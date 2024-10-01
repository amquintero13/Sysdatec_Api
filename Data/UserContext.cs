using Microsoft.EntityFrameworkCore;
using Prueba_Sysdatec.Models;

namespace Prueba_Sysdatec.Data
{
    public class UserContext :DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
