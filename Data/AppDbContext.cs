using API_Banco.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Banco.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<API_Banco.Models.Cuenta> Cuenta { get; set; }

        public DbSet<API_Banco.Models.Retiro> Retiro { get; set; }

        public DbSet<API_Banco.Models.Transferencia> Transferencia { get; set; }

    }
}
