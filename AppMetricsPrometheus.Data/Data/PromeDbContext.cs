using AppMetricsPrometheus.Domain;
using Microsoft.EntityFrameworkCore;

namespace AppMetricsPrometheus.Data.Data
{
    public class PromeDbContext : DbContext
    {
        public PromeDbContext(DbContextOptions<PromeDbContext> options) : base(options)
        {

        }

        public DbSet<Prome> Promes { get; set; }
    }
}
