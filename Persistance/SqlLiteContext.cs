using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class SqlLiteContext : DbContext, IApplicationContext
    {
        public DbContext Instance => this;

        public SqlLiteContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Student { get ; set; }
    }
}
