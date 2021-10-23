using budies_backend.Services.Interfaces;
using budies_backend.Models;
using budies_backend.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace budies_backend.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IContextFactory _context;

        public CategoryService(IContextFactory context)
        {
            _context = context;
        }

        public async Task<Effects> CreateEffect(Effects effect)
        {
            using (var db = _context.CreateDbContext())
            {
                await db.Effects.AddAsync(effect);
                await db.SaveChangesAsync();
            }
            return effect;
        }
        public async Task<Ailments> CreateAilment(Ailments ailment)
        {
            using (var db = _context.CreateDbContext())
            {
                await db.Ailments.AddAsync(ailment);
                await db.SaveChangesAsync();
            }
            return ailment;
        }

        public async Task<Flavors> CreateFlavor(Flavors flavor)
        {
            using (var db = _context.CreateDbContext())
            {
                await db.Flavors.AddAsync(flavor);
                await db.SaveChangesAsync();
            }
            return flavor;
        }


        public async Task<IEnumerable<Effects>> GetEffect()
        {
            using (var db = _context.CreateDbContext())
            {
                return await db.Effects.ToListAsync();
            }
        }

        public async Task<Effects> GetEffect(int id)
        {
            using (var db = _context.CreateDbContext())
            {
                return await db.Effects.FindAsync(id);
            }
        }

        public async Task<IEnumerable<Ailments>> GetAilment()
        {
            using (var db = _context.CreateDbContext())
            {
                return await db.Ailments.ToListAsync();
            }
        }

        public async Task<Ailments> GetAilment(int id)
        {
            using (var db = _context.CreateDbContext())
            {
                return await db.Ailments.FindAsync(id);
            }
        }

        public async Task<IEnumerable<Flavors>> GetFlavor()
        {
            using (var db = _context.CreateDbContext())
            {
                return await db.Flavors.ToListAsync();
            }
        }

        public async Task<Flavors> GetFlavor(int id)
        {
            using (var db = _context.CreateDbContext())
            {
                return await db.Flavors.FindAsync(id);
            }
        }
    }
}
