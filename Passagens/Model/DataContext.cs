using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens.Model
{
    public class DataContext : DbContext
    {
        DbSet<Cliente> Cliente { get; set; }
    }
}
