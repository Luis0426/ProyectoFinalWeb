using Microsoft.EntityFrameworkCore;
using Paginas_Enchiladas.Models;

namespace Paginas_Enchiladas.DAL
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> options)
            : base(options)
        {

        }
        public virtual DbSet<Enchilada> Enchiladas { get; set; }

    }
}
