using MusicStore.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MusicStore.DAL
{
    public class StoreContext : DbContext
    {

        public StoreContext() : base("StoreContext")
        {
        }

        //Tablas que debe crear dentro de la BD. DbSet es un array: DbSet<clase que va a mapear> nombreTabla o nombrePropiedad(parametros get y set)
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        /* Metodo que genera el modelo. Es sobreescribible.
        Los nombres de las tablas los va a poner en singular por convención. */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}