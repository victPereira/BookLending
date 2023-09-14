using BookLending.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLending.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Criando tabela com todas as propiedades da classe LendingModel de onde vem os campos.
        public DbSet<LendingModel> Lending { get; set; }
    }
}
