
namespace Horacio.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Horacio.Models.Clown> Clowns { get; set; }
    }
}