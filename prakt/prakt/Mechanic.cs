using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt
{
    public class Mechanic
    {
        public int ID { get; set; }

        public string MechanicsName { get; set; }

        public int IdOfClient { get; set; }

        public LinkedList<Client> Clients { get; set; } = new()

    }
}
