using CESDEUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

/*Con esta clase el Entity FrameWork sabe cual es la BD que va a crear para almacenar las tablas:
Students, Enrollment, Course. Esta clase es el contexto de las tablas y con base en este contexto, el efw crea la BD 
DAL -> Data Acess Layer */
namespace CESDEUniversity.DAL
{
    public class UniversityContext : DbContext
    {
        //Constructor del contexto.
        public UniversityContext() : base("UniversityContext") 
        {
        }

        //Tablas que debe crear dentro de la BD. DbSet es un array: DbSet<clase que va a mapear> nombreTabla o nombrePropiedad(parametros get y set)
        public DbSet<Student> Students { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

        /* Metodo que genera el modelo. Es sobreescribible.
        Los nombres de las tablas los va a poner en singular por convención. */
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    }
}