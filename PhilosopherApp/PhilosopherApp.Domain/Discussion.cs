using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilosopherApp.Domain
{
    public class Discussion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Philosopher> Philosophers { get; set; }
    }
}
