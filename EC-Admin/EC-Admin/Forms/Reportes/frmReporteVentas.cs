using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EC_Admin.Forms
{
    public partial class frmReporteVentas : Form
    {
        List<int> idVendedores = new List<int>();
        DataTable dtVenta = new DataTable();
        DataTable dtCaja = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmReporteVentas()
        {
            InitializeComponent();
            c = new CerrarFrmEspera(Cerrar);
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void CargarTrabajadores()
        {
            try
            {
                string sql = "SELECT id, nombre, apellidos FROM trabajador";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idVendedores.Add((int)dr["id"]);
                    cboVendedor.Items.Add(dr["nombre"].ToString() + " " + dr["apellidos"].ToString());
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los trabajadores. La búsqueda por trabajadores estará inhabilitada. No se ha podido conectar a la base de datos.", Config.shrug, ex);
                btnBuscarTrabajador.Enabled = false;
                cboVendedor.Enabled = false;
                chbTrabajador.Enabled = false;
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los trabajadores. La búsqueda por trabajadores estará inhabilitada.", Config.shrug, ex);
                btnBuscarTrabajador.Enabled = false;
                cboVendedor.Enabled = false;
                chbTrabajador.Enabled = false;
            }
        }

        private void Buscar(int idVendedor)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id_vendedor, total, update_time FROM venta WHERE id_vendedor=?id_vendedor AND abierta=0 AND cancelada=0;";
                sql.Parameters.AddWithValue("?id_vendedor", idVendedor);
                dtVenta = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al obtener los datos del reporte. No se ha podido conectar con la base de datos.", Config.shrug, ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al obtener los datos del reporte.", Config.shrug, ex });
            }
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id_vendedor, total, update_time FROM venta WHERE ((create_time BETWEEN ?fechaIni AND ?fechaFin) OR (update_time BETWEEN ?fechaIni AND ?fechaFin)) AND abierta=0 AND cancelada=0;";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dtVenta = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al obtener los datos del reporte. No se ha podido conectar con la base de datos.", Config.shrug, ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al obtener los datos del reporte.", Config.shrug, ex });
            }
        }

        private void Buscar(int idVendedor, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id_vendedor, total, update_time FROM venta WHERE id_vendedor=?id_vendedor AND ((create_time BETWEEN ?fechaIni AND ?fechaFin) OR (update_time BETWEEN ?fechaIni AND ?fechaFin)) AND abierta=0 AND cancelada=0;";
                sql.Parameters.AddWithValue("?id_vendedor", idVendedor);
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dtVenta = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al obtener los datos del reporte. No se ha podido conectar con la base de datos.", Config.shrug, ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al obtener los datos del reporte.", Config.shrug, ex });
            }
        }

        private void Graficar()
        {
            chrInformacion.Series.Clear();
            int dias = (dtpFechaFin.Value - dtpFechaInicio.Value).Days;
            if (dias <= 7)
            {
                DateTime _fecha = new DateTime();
                string fechaMostrar = "";
                decimal totalFecha = 0M;
                foreach (DataRow dr in dtVenta.Rows)
                {
                    DateTime fecha = ((DateTime)dr["update_time"]).Date;
                    if (fecha == _fecha)
                    {
                        totalFecha += (decimal)dr["total"];
                    }
                    else
                    {
                        if (fechaMostrar != "")
                        {
                            chrInformacion.Series.Add(fechaMostrar).Points.AddXY(fechaMostrar, totalFecha);
                        }
                        _fecha = fecha;
                        fechaMostrar = fecha.ToString("dd/MM/yyyy");
                        totalFecha += (decimal)dr["total"];
                    }
                }
                if (fechaMostrar != "")
                {
                    chrInformacion.Series.Add(fechaMostrar).Points.AddXY(fechaMostrar, totalFecha);
                }
            }
            else if (dias <= 30)
            {
                DateTime _fecha = new DateTime();
                string fechaMostrar = "";
                decimal totalFecha = 0M;
                foreach (DataRow dr in dtVenta.Rows)
                {
                    DateTime fecha = ((DateTime)dr["update_time"]).Date;
                    int diasSemana = (fecha.Date - dtpFechaInicio.Value.Date).Days;
                    if (diasSemana % 7 != 0)
                    {
                        totalFecha += (decimal)dr["total"];
                    }
                    else
                    {
                        if (fechaMostrar != "")
                        {
                            chrInformacion.Series.Add(fechaMostrar).Points.AddXY(fechaMostrar, totalFecha);
                        }
                        _fecha = fecha;
                        fechaMostrar = fecha.ToString("dd/MM/yyyy");
                        totalFecha += (decimal)dr["total"];
                    }
                }
                if (fechaMostrar != "")
                {
                    chrInformacion.Series.Add(fechaMostrar).Points.AddXY(fechaMostrar, totalFecha);
                }
            }
            else if (dias <= 365)
            {
            }
            else
            {

            }

        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            if (a.Length == 1)
            {
                Buscar((int)a[0]);
            }
            else if (a.Length == 2)
            {
                Buscar((DateTime)a[0], (DateTime)a[1]);
            }
            else if (a.Length == 3)
            {
                Buscar((int)a[0], (DateTime)a[1], (DateTime)a[2]);
            }
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            Graficar();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, generando reporte", this);
        }

        private void btnBuscarFechas_Click(object sender, EventArgs e)
        {
            if (chbTrabajador.Checked)
            {
                bgwBusqueda.RunWorkerAsync(new object[] { idVendedores[cboVendedor.SelectedIndex], dtpFechaInicio.Value, dtpFechaFin.Value });
            }
            else
            {
                bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
            }
            tmrEspera.Enabled = true;
        }

        private void btnBuscarTrabajador_Click(object sender, EventArgs e)
        {
            if (chbTrabajador.Checked)
            {
                bgwBusqueda.RunWorkerAsync(new object[] { idVendedores[cboVendedor.SelectedIndex], dtpFechaInicio.Value, dtpFechaFin.Value });
            }
            else
            {
                bgwBusqueda.RunWorkerAsync(new object[] { idVendedores[cboVendedor.SelectedIndex] });
            }
            tmrEspera.Enabled = true;
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            CargarTrabajadores();
            if (cboVendedor.Items.Count <= 0)
            {
                cboVendedor.Enabled = false;
                btnBuscarTrabajador.Enabled = false;
                chbTrabajador.Enabled = false;
            }
            else
            {
                cboVendedor.SelectedIndex = 0;
            }
        }
    }
}
