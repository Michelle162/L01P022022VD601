using Microsoft.EntityFrameworkCore;
namespace L01P022022VD601.Models
{
    public class sistema_notasContext : DbContext
    {
        public sistema_notasContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<facultades> facultades { get; set; }

        public DbSet<materias> materias { get; set; }
        public DbSet<departamentos> departamentos { get; set;}

        public DbSet<alumnos> alumnos { get; set; }

    }
}
