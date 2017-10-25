using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeInsumos.Clases
{
    public class Transaccion
    {
        public string _productoId { get; set; }
        public DateTime _fecha { get; set; }
        public String _operacionId { get; set; }
        public int _cantidad { get; set; }

        public Transaccion(string productoId, DateTime fecha, String operacionId, int cantidad)
        {
            _productoId = productoId;
            _fecha = fecha;
            _operacionId = operacionId;
            _cantidad = cantidad;
        }
    
    }
}
