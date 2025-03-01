using Microsoft.EntityFrameworkCore;
using ProyectoMVC.Models;  

namespace ProyectoMVC.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Alumnos> Alumnos { get; set; }
    }
}






