using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilosopherApp.Domain
{
    public class DiscussionPhilosopher
    {
        public int PhilosopherId { get; set; }
        public int DiscussionId { get; set; }
        public DateTime DateJoined { get; set; }

    }
}
