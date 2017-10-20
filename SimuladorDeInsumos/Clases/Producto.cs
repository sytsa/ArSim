using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeInsumos  
{
    public class Producto 
    {
        public string _productId { get; set; }
        public string _descripcion { get; set; }
        public string _uMedida { get; set; }
        public int _leadTime { get; set; }
        public double _valorUnitario { get; set; }
        public double _nivelServicioDeseado { get; set; }
        public double _puntoPedido { get; set; }
        public int _numLotes { get; set; }
        public double _stockMedio { get; set; }
        public DateTime _fechaStock { get; set; }
        public int _stockInicial { get; set; }

        public Producto(string productoId, 
            string descripcion, 
            string uMedida, 
            int leadTiem,
            double valorUnitario
           )
        {
            _productId = productoId;
            _descripcion = descripcion;
            _uMedida = uMedida;
            _valorUnitario = valorUnitario;
        }

        public void AgregarStock (DateTime fechaStock, int stockInicial)
        {
            _fechaStock = fechaStock;
            _stockInicial = stockInicial;
        }
        
        
    }
}
