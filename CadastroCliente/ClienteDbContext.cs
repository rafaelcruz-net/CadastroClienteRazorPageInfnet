using CadastroCliente.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set;}

    }
}
