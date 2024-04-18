using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilosopherApp.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Philosopher Philosopher { get; set; }
        public int PhilosopherId { get; set; }

    }
}
