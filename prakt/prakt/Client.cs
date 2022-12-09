using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt
{
    
        public class Client
        {
        [Column("Id")]
        public int ID { get; set; }

            public string ClientsName { get; set; }

            public int IdOfMechanic { get; set; }

            public Mechanic? Mechanics { get; set; }

    }
}
