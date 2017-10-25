using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeInsumos.Clases
{
    public static class Simulador
    {
        public static MaestroProductos MaestroProd { get; set; }
        public static MaestroOperaciones MaestroOpe { get; set; }
        public static HistorialTransacciones HistorialT { get; set; }

        public static void IniciarSimulador()
        {
            MaestroProd = new MaestroProductos();
            MaestroOpe = new MaestroOperaciones();
            HistorialT = new HistorialTransacciones();
        }
    }
}
