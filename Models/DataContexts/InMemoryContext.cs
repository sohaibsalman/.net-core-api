using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataContexts
{
    public class InMemoryContext : DbContext, IDataContext 
    {
        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base (options) { }
    }
}
