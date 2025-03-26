using Microsoft.EntityFrameworkCore;
using PoolApp.Models;

namespace PoolApp.Data
{
    public class PoolAppContext : DbContext
    {
        public PoolAppContext(DbContextOptions<PoolAppContext> options) : base(options)
        {
        }

        DbSet<Pool> Pool {  get; set; }
    }
}
