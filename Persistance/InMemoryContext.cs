using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Threading.Tasks;

namespace Persistance
{
    public class InMemoryContext : DbContext, IApplicationContext
    {
        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options) { }

        public DbSet<Student> Student { get ; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
