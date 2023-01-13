using Microsoft.EntityFrameworkCore;
using OracleAPI.Models;

namespace OracleAPI.Data
{
    public class ContextOracle : DbContext
    {
        //private readonly IConfiguration _configuration;
        //public ContextOracle(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        public ContextOracle(DbContextOptions<ContextOracle> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseOracle(_configuration.GetConnectionString("MiConexion"));
        //}
        public DbSet<CLIENTE> CLIENTE
        {
            get; set;
        }
    }
}
