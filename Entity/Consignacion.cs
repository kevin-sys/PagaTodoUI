using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Consignacion
    {
        public string EntidadServicios { get; set; }
        public int NumeroRecibo { get; set; }
        public DateTime FechaPago { get; set; }
        public float ValorPagado { get; set; }
    }
}
