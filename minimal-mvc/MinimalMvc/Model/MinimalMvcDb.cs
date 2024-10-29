using Microsoft.EntityFrameworkCore;

namespace MinimalMvc.Model
{
    public class MinimalMvcDb : DbContext
    {
        public MinimalMvcDb(DbContextOptions<MinimalMvcDb> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}