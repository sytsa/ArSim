using Excel;
using SimuladorDeInsumos.Clases;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimuladorDeInsumos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        DataSet excel;
        IExcelDataReader lectorExcel;
        
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            pbarFilas.Value = 0;
            pbarHojas.Value = 0;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Archivo de excel|*.xls"  , ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Variable global
                    Simulador.IniciarSimulador();

                    // Manejo archivo
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    lectorExcel = ExcelReaderFactory.CreateBinaryReader(fs);
                    lectorExcel.IsFirstRowAsColumnNames = true;
                    excel = lectorExcel.AsDataSet();
                    
                    //Escribir nombre del archivo
                    txtPath.Text = ofd.FileName;

                    int indiceHoja = 0;
                    foreach (DataTable dt in excel.Tables)
                    {
                        //Chequeo de las 4 tablas
                        switch (dt.TableName)
                        {
                            case "Maestro de productos":
                                cboxTablasMP.Checked = true;
                                pbarHojas.Value += 25;
                                Simulador.MaestroProd.NumeroDeHoja = indiceHoja;
                                break;
                            case "Stock de referencia":
                                cboxTablasS.Checked = true;
                                pbarHojas.Value += 25;
                                Simulador.MaestroProd.NumeroDeHojaStock = indiceHoja;
                                break;
                            case "Historial de transacciones":
                                cboxTablasH.Checked = true;
                                pbarHojas.Value += 25;
                                Simulador.HistorialT.NumeroDeHoja = indiceHoja;
                                break;
                            case "Maestro de transacciones":
                                cboxTablasMT.Checked = true;
                                pbarHojas.Value += 25;
                                Simulador.MaestroOpe.NumeroDeHoja = indiceHoja;
                                break;
                            default:
                                break;
                        }
                        indiceHoja++;
                    }

                    // Mapeo de hojas a clases
                    DataTable tablaMaestroProd, tablaStockRef, tablaMaestroOpe, tablaHistorialT;
                    Mapeo_Hojas_Clases(out tablaMaestroProd, out tablaStockRef, out tablaMaestroOpe, out tablaHistorialT);

                    // Mapeo de datos a clases
                    Mapeo_Datos_Clases(tablaMaestroProd, tablaStockRef, tablaMaestroOpe, tablaHistorialT);

                    // Cierre del archivo
                    lectorExcel.Close();

                    // Habilitamos el panel del analizador
                    tabSimulador.Enabled = true;

                    // Llenado del combo de maestro de productos
                    comboMProd.Items.Clear();
                    foreach (Producto prod in Simulador.MaestroProd.productos)
                    {
                        comboMProd.Items.Add(prod._productId + " - " + prod._descripcion);
                    }
                }
            }

        }

        private void Mapeo_Hojas_Clases(out DataTable tablaMaestroProd, out DataTable tablaStockRef, out DataTable tablaMaestroOpe, out DataTable tablaHistorialT)
        {
            tablaMaestroProd = excel.Tables[Simulador.MaestroProd.NumeroDeHoja];
            tablaStockRef = excel.Tables[Simulador.MaestroProd.NumeroDeHojaStock];
            tablaMaestroOpe = excel.Tables[Simulador.MaestroOpe.NumeroDeHoja];
            tablaHistorialT = excel.Tables[Simulador.HistorialT.NumeroDeHoja];
            lblFilas.Text = "Productos: " + tablaMaestroProd.Rows.Count
                          + " | Stock Ref: " + tablaStockRef.Rows.Count
                          + " | Transacciones: " + tablaMaestroOpe.Rows.Count
                          + " | Historial: " + tablaHistorialT.Rows.Count;
        }

        private void Mapeo_Datos_Clases(DataTable tablaMaestroProd, DataTable tablaStockRef, DataTable tablaMaestroOpe, DataTable tablaHistorialT)
        {
            foreach (DataRow fila in tablaMaestroProd.Rows)
            {
                if (!(fila[0] is DBNull && fila[1] is DBNull && fila[2] is DBNull))
                    Simulador.MaestroProd.AgregarProducto(
                    new Producto(
                        Convert.ToString(fila["Código"]),
                        Convert.ToString(fila["Descripción"]),
                        Convert.ToString(fila["Unidad de medida"]),
                        Convert.ToInt32(fila["LeadTime"]),
                        Convert.ToDouble(fila["Valor unitario"])
                        ));
            }
            pbarFilas.Value += 25;
            cboxFilasMP.Checked = true;

            foreach (DataRow fila in tablaStockRef.Rows)
            {
                if (!(fila[0] is DBNull && fila[1] is DBNull && fila[2] is DBNull))
                    Simulador.MaestroProd.AgregarFecha(
                    Convert.ToString(fila["Código"]),
                    DateTime.FromOADate((double)fila["Fecha"]),
                    Convert.ToInt32(fila["Stock"] is "-" ? 0 : fila["Stock"])
                    );
            }
            pbarFilas.Value += 25;
            cboxFilasS.Checked = true;

            foreach (DataRow fila in tablaMaestroOpe.Rows)
            {
                if (!(fila[0] is DBNull && fila[1] is DBNull && fila[2] is DBNull))
                    Simulador.MaestroOpe.AgregarOperacion(
                    new Operacion(
                        Convert.ToString(fila["Tipo de documento"]),
                        Convert.ToString(fila["Descripción"]),
                        Convert.ToString(fila["Signo"]),
                        Convert.ToBoolean(fila["Considerar"] is "No" ? false : true)
                        ));
            }
            pbarFilas.Value += 25;
            cboxFilasMT.Checked = true;

            
            foreach (DataRow fila in tablaHistorialT.Rows)
            {
                if (!(fila[0] is DBNull && fila[1] is DBNull && fila[2] is DBNull))
                    Simulador.HistorialT.AgregarTransaccion(
                    new Transaccion(
                        Convert.ToString(fila["Código"]),
                        DateTime.FromOADate((double)fila["Fecha"]),
                        Convert.ToString(fila["Tipo de documento"]),
                        Convert.ToInt32(fila["Cantidad"])
                        ));
            }
            
            pbarFilas.Value += 25;
            cboxFilasH.Checked = true;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void comboMProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnalisisGraficoProducto();
        }

        private void comboGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnalisisGraficoProducto();
        }

        private void AnalisisGraficoProducto()
        {
            if (comboMProd.SelectedItem == null || comboGrafico.SelectedItem == null)
            {
                MessageBox.Show("Seleccione por favor un producto y un tipo de gráfico");
            }
            else
            {
                string prodId = comboMProd.SelectedItem.ToString().Split(' ')[0];
                string tipoGrafico = comboGrafico.SelectedItem.ToString();
                graficoAG.Series[0].Points.Clear();

                List<Operacion> opeValidas;
                switch (tipoGrafico)
                {
                    case "Entradas":
                        opeValidas = Simulador.MaestroOpe.FiltrarOperaciones("+");
                        break;
                    case "Salidas":
                        opeValidas = Simulador.MaestroOpe.FiltrarOperaciones("-");
                        break;
                    case "Variación de Stock":
                        opeValidas = Simulador.MaestroOpe.FiltrarOperaciones("+");
                        opeValidas.AddRange(Simulador.MaestroOpe.FiltrarOperaciones("-"));
                        break;
                    default:
                        opeValidas = Simulador.MaestroOpe.FiltrarOperaciones("+");
                        break;
                }
                List<Transaccion> grafico = new List<Transaccion>();

                lectorExcel.AsDataSet().Tables[Simulador.HistorialT.NumeroDeHoja].Rows.Clear();
                

                foreach (Operacion ope in opeValidas)
                {
                    grafico.AddRange(Simulador.HistorialT.transacciones.FindAll(item => (item._productoId == prodId) && (item._operacionId == ope._operacionId)));
                }


                DateTime fecAnterior;
                int cantidad = 0;
                // Chequear que estoy perdiendo datos
                for (int i = 0; i < grafico.Count; i++)
                {
                    fecAnterior = grafico[i]._fecha;
                    cantidad = grafico[i]._cantidad;
                    i++;
                    while( fecAnterior == grafico[i]._fecha && i < grafico.Count)
                    {
                        cantidad += grafico[i]._cantidad;
                        i++;
                    }
                    graficoAG.Series[0].Points.AddXY(fecAnterior, cantidad);
                }

                //foreach (Transaccion t in grafico)
                //{
                //    if (fecAnterior != t._fecha)
                //    {
                //        graficoAG.Series[0].Points.AddXY(t._fecha, t._cantidad);
                //        fecAnterior = t._fecha;
                //        esRepetido = false;
                //    }
                //    else
                //    {
                        
                //        cantidad += t._cantidad;
                //    }
                //}

                if(graficoAG.Series[0].Points.Count == 0)
                {
                    MessageBox.Show("No hay valores para este producto y este tipo de gráfico");
                }

            }
        }
    }
}
