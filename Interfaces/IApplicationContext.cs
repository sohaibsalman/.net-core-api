using Microsoft.EntityFrameworkCore;
using Models;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IApplicationContext
    {
        public int SaveChanges();
        public Task<int> SaveChangesAsync();

        // DB Sets for the application
        DbSet<Student> Student { get; set; }
    }
}
