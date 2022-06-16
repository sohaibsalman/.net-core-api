using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Persistance
{
    public class InMemoryContext : DbContext, IApplicationContext
    {
        public DbContext Instance => this;

        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options) { }

        public DbSet<Student> Student { get ; set; }
    }
}
