using Excel;
using SimuladorDeInsumos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDeInsumos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        DataSet excel;
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            pbarFilas.Value = 0;
            pbarHojas.Value = 0;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Archivo de excel|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Variable global
                    Simulador.IniciarSimulador();

                    // Manejo archivo
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader lectorExcel = ExcelReaderFactory.CreateBinaryReader(fs);
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
                    DataTable tablaMaestroProd = excel.Tables[Simulador.MaestroProd.NumeroDeHoja];
                    DataTable tablaStockRef = excel.Tables[Simulador.MaestroProd.NumeroDeHojaStock];
                    DataTable tablaMaestroOpe = excel.Tables[Simulador.MaestroOpe.NumeroDeHoja];
                    DataTable tablaHistorialT = excel.Tables[Simulador.HistorialT.NumeroDeHoja];

                    lblFilas.Text = "Productos: " + tablaMaestroProd.Rows.Count
                                  + " | Stock Ref: " + tablaStockRef.Rows.Count
                                  + " | Transacciones: " + tablaMaestroOpe.Rows.Count
                                  + " | Historial: " + tablaHistorialT.Rows.Count;

                    // Mapeo de datos a clases
                    foreach (DataRow fila in tablaMaestroProd.Rows)
                    {
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

                    // Cierre del archivo
                    lectorExcel.Close();

                    // Habilitamos el panel del analizador
                    tabSimulador.Enabled = true;
                }
            }

        }
        
    }
}
