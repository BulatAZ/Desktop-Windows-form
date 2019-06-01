using System.Data.Entity;

namespace WindowsFormsApp1
{
    public class CitiesDBContext : DbContext
    {

        public DbSet<City> Cities { get; set; }
        public CitiesDBContext()
            : base("DefaultConnection")
        { }

    }
}
