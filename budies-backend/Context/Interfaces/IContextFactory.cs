using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace budies_backend.Context
{
    public interface IContextFactory
    {
        public BudiesDBContext CreateDbContext(string[] args = null);
    }
}
