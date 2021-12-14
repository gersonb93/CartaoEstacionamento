using Microsoft.EntityFrameworkCore;
using CartaoEstacionamento.Models;
using CartaoEstacionamento.ViewModels;

namespace CartaoEstacionamento.Data
{
    public class CartaoEstacionamentoContext : DbContext
    {
        public CartaoEstacionamentoContext(DbContextOptions<CartaoEstacionamentoContext> options)
            : base(options)
        {
        }

        
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<PessoaViewModel> PessoaViewModel { get; set; }


    }
}
