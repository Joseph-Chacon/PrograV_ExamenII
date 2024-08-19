using Microsoft.EntityFrameworkCore;
using ExamenFinal.Models;

namespace MiAppWebBD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
