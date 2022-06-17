using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Threading.Tasks;

namespace Persistance
{
    public class MySqlContext : DbContext, IApplicationContext
    {
        public MySqlContext(DbContextOptions options) : base(options) { }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        public DbSet<Student> Student { get; set; }
    }
}
