using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace budies_backend.Models
{
    public class Strains
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
        public int EffectsID { get; set; }
        public virtual Effects Effect { get; set; }
        public int AilmentsID { get; set; }
        public virtual Ailments Ailments { get; set; }
        public int FlavorID { get; set; }
        public virtual Flavors Flavors { get; set; }
    }
}
