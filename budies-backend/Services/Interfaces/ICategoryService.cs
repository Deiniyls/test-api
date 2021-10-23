using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using budies_backend.Models;

namespace budies_backend.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Effects>> GetEffect();
        Task<IEnumerable<Ailments>> GetAilment();
        Task<IEnumerable<Flavors>> GetFlavor();
        Task<Effects> GetEffect(int id);
        Task<Ailments> GetAilment(int id);
        Task<Flavors> GetFlavor(int id);
        
        Task<Effects> CreateEffect(Effects effect);
        Task<Ailments> CreateAilment(Ailments ailment);
        Task<Flavors> CreateFlavor(Flavors flavor);

        //Task Update(Effects effect);
        //Task Delete(int id);
    }
}
