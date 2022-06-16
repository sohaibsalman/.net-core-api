using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Threading.Tasks;

namespace Persistance
{
    public class SqlLiteContext : DbContext, IApplicationContext
    {
        public SqlLiteContext(DbContextOptions options) : base(options) { }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        public int Save()
        {
            return base.SaveChanges();
        }

        public DbSet<Student> Student { get ; set; }
    }
}
