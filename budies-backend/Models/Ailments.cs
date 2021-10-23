using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace budies_backend.Models
{
    public class Ailments
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public virtual ICollection<Strains> Strains { get; set; }
        public Ailments()
        {
            Strains = new HashSet<Strains>();
        }
    }
}
