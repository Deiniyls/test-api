using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using budies_backend.Models;

namespace budies_backend.Services.Interfaces
{
    public interface IStrainService
    {
        Task<IEnumerable<Strains>> Get();
        Task<Strains> Get(int id);
        Task<Strains> Create(Strains strain);
        Task Update(Strains strain);
        Task Delete(int id);
    }
}
