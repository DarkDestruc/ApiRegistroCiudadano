using ApiRegistroCiudadano.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace ApiRegistroCiudadano.Data
{
    public class ApiRegistroCiudadanoDbContext : DbContext
    {
        public ApiRegistroCiudadanoDbContext(DbContextOptions<ApiRegistroCiudadanoDbContext> options) : base (options)

        {
            
        }

        public DbSet<RegistroNuevo> registroNuevos { get; set; }
        public DbSet<CINuevoRegistro> CINuevoRegistros { get; set; }
    }
}
