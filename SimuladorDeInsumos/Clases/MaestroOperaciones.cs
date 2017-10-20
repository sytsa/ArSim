using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeInsumos.Clases
{
    public class MaestroOperaciones
    {
        private List<Operacion> operaciones = new List<Operacion>();
        public int NumeroDeHoja { get; set; }
        public void AgregarOperacion(Operacion o)
        {
            operaciones.Add(o);
        }

        public Operacion BuscarTransaccion(String operacionId)
        {
            return operaciones.Find(item => item._operacionId == operacionId);
        }
    }
}
