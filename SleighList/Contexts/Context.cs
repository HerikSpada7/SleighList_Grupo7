<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore;
using SleighList.Models;

namespace SleighList.Contexts
{
    // Classe que terá as informações do banco de dados
    public class Context : DbContext
    {
        // Criar um método construtor
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        // OnConfiguring -> Possui a configuracao da conexao com
        //o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // colocar as informacoes do banco
            // As configuracoes existem?
            if (!optionsBuilder.IsConfigured)
            {
                // A string de conexao do banco de dados:
                // Data Source => Nome do servidor do banco de dados
                // Initial Catalog => Nome do banco de dados
                // User Id e Password => Informacoes de acesso ao servidor do banco de dados
                // ALUNOS:
                //  optionsBuilder.UseSqlServer(@"
                //  Data Source=DESKTOP-LAO5MIJ\\SQLEXPRESSTEC; 
                //  Initial Catalog = Bibliotec_mvc; 
                //  User Id=sa; 
                //  Password=123; 
                //  Integrated Security=true; TrustServerCertificate = true");
                // SAMANTA:
                // optionsBuilder.UseSqlServer("Data Source=DESKTOP-LAO5MIJ\\SQLEXPRESSTEC; Initial Catalog = Bibliotec; User Id=sa; Password=abc123; Integrated Security=true; TrustServerCertificate = true");
                optionsBuilder.UseSqlServer("Data Source=NOTE14-S28\\SQLEXPRESS; Initial Catalog = SleighLits; User Id=sa; Password=123; TrustServerCertificate = true");

            }
        }

        // As referencias das nossas tabelas no banco de dados:

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Item> Item { get; set; }

    }
}
>>>>>>> 329ea3699f1974a3118fd4911de1e7c12fbf4a7f
