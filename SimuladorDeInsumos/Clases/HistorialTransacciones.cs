using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeInsumos.Clases
{
    public class HistorialTransacciones
    {
        public List<Transaccion> transacciones = new List<Transaccion>();
        public int NumeroDeHoja { get; set; }

        public void AgregarTransaccion(Transaccion t)
        {
            transacciones.Add(t);
        }

        public Transaccion BuscarTransaccion(string productoId, DateTime f, String operacionId)
        {
            return transacciones.Find(
                item => (item._productoId == productoId) 
                    && (item._operacionId == operacionId)
                    && (item._fecha == f));
        }

    }
}
