using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SitePessoalMVC.Domain.Entities;

namespace SitePessoalMVC.Infraestrutura
{
    public class SitePessoalDbContext : DbContext
    {
        private IConfiguration _configuration;

        public DbSet<Curso> Cursos { get; set; }

        public SitePessoalDbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var typeDatabase = _configuration["TypeDatabase"];
            var connectionString = _configuration.GetConnectionString(typeDatabase);
            if (connectionString == "MySql")
            {
                optionsBuilder.UseMySQL(connectionString);
            }
        }
    }
}
