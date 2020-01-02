using System.Data.Entity;

namespace Trabajo.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Trabajo.Models.Student> Students { get; set; }
    }
}