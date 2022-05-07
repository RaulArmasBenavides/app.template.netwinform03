using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo03.Entity
{
    public class ClienteTO
    {

        public ClienteTO() {
            Nombre = string.Empty;
            Ciudad = string.Empty;
        }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
    }
}
