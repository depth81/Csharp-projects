using Microsoft.EntityFrameworkCore;

namespace EjemploAPI.Models
{
    public class EjemploContext : DbContext
    {

            public EjemploContext(DbContextOptions<EjemploContext> options)
                : base(options)
            {
            }

            public DbSet<EjemploItem> EjemploItem { get; set; }
    }

}
