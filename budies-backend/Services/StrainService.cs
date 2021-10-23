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
    public class StrainService : IStrainService
    {
        private readonly IContextFactory _context;

        public StrainService(IContextFactory context)
        {
            _context = context;
        }
        public async Task<Strains> Create(Strains strain)
        {
            using (var db = _context.CreateDbContext())
            {
                //var effect = new Effects{ Value = "string" };

                //var differentstrain = new Strains { Description = "string", Type = "string", Name = "string", Effect = effect };
                //await db.AddAsync(differentstrain);
                //await db.SaveChangesAsync();

                await db.Strains.AddAsync(strain);
                await db.SaveChangesAsync();
            }
                

            return strain;
        }

        public async Task Delete(int id)
        {
            using (var db = _context.CreateDbContext())
            {
                var strainToDelete = await db.Strains.FindAsync(id);
                db.Strains.Remove(strainToDelete);
                await db.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Strains>> Get()
        {
            using (var db = _context.CreateDbContext())
            {
                return await db.Strains.ToListAsync();
            }
        }

        public async Task<Strains> Get(int id)
        {
            using (var db = _context.CreateDbContext())
            {
                return await db.Strains.FindAsync(id);
            }
        }

        public async Task Update(Strains strain)
        {
            using (var db = _context.CreateDbContext())
            {
                db.Entry(strain).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
        }
    }
}
