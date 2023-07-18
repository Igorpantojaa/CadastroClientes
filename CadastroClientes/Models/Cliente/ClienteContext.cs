using CadastroClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroClientes.Database
{
    public class ClienteContext : DbContext
    {
        public DbSet <Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB; " +
                "AttachDbFilename = C:\\Dev\\VSTUDIO\\CadastroClientes\\CadastroClientes" +
                "\\Database\\BaseClientes.mdf; Integrated Security = True;");
        }
    }
}