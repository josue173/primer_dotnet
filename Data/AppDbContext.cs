
using Microsoft.EntityFrameworkCore;
using Universidad.Models;
namespace MiServicioWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; } = null!;
    }
}

