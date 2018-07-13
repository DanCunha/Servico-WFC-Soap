using System.Data.Entity;


namespace Passagens.Model
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
    }
}
