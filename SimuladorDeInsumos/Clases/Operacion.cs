using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeInsumos.Clases
{
    public class Operacion
    {
        public String _operacionId { get; set; }
        public string _descripcion { get; set; }
        public string _signo { get; set; }
        public bool _considerar { get; set; }

        public Operacion(String operacionId, string descripcion, string signo, bool considerar)
        {
            _operacionId = operacionId;
            _descripcion = descripcion;
            _signo = signo;
            _considerar = considerar;
        }
    }
}
