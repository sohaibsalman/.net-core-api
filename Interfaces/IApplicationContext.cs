using Microsoft.EntityFrameworkCore;
using Models;

namespace Interfaces
{
    public interface IApplicationContext
    {
        // Pointer to the current concrete class context
        DbContext Instance { get; }

        // DB Sets for the application
        DbSet<Student> Student { get; set; }
    }
}
