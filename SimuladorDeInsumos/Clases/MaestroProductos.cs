using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeInsumos
{
    public class MaestroProductos
    {
        private List<Producto> productos = new List<Producto>();
        public int NumeroDeHoja { get; set; }
        public int NumeroDeHojaStock { get; set; }
        public void AgregarProducto(Producto p)
        {
            productos.Add(p);
        }

        public void AgregarFecha(string productoId, DateTime fechaStock, int stockInicial)
        {
            BuscarProdcuto(productoId).AgregarStock(fechaStock, stockInicial);
        }

        public Producto BuscarProdcuto(string productoId)
        {
            return productos.Find(item => item._productId == productoId);
        }

        public void AgregarInfoExtra(
            string productoId,
            double nivelServicioDeseado = -1,
            double puntoPedido = -1,
            int numLotes = -1,
            double stockMedio = -1)
        {
            if (nivelServicioDeseado != -1)
                BuscarProdcuto(productoId)._nivelServicioDeseado = nivelServicioDeseado;
            if (puntoPedido != -1)
                BuscarProdcuto(productoId)._puntoPedido = puntoPedido;
            if (numLotes != -1)
                BuscarProdcuto(productoId)._numLotes = numLotes;
            if (stockMedio != -1)
                BuscarProdcuto(productoId)._stockMedio = stockMedio;
        }
        
    }
}
