using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin.Forms
{
    public partial class frmBanco : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        #region Instancia
        private static frmBanco frmInstancia;
        public static frmBanco Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmBanco();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmBanco();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmBanco()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            c = new CerrarFrmEspera(Cerrar);
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, total, descripcion, tipo_movimiento, create_time FROM banco WHERE (create_time BETWEEN ?fechaIni AND ?fechaFin) AND id_sucursal='" + Config.idSucursal + "'";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar los datos de banco. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al cargar los datos de banco.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvBanco.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    string tipoMovimiento = "";
                    MovimientoCaja mc = (MovimientoCaja)Enum.Parse(typeof(MovimientoCaja), dr["tipo_movimiento"].ToString());
                    switch (mc)
                    {
                        case MovimientoCaja.Entrada:
                            tipoMovimiento = "Entrada";
                            break;
                        case MovimientoCaja.Salida:
                            tipoMovimiento = "Salida";
                            break;
                    }
                    dgvBanco.Rows.Add(new object[] { dr["id"], dr["create_time"], dr["descripcion"].ToString(), dr["total"], tipoMovimiento });
                    Application.DoEvents();
                }
                dgvCaja_RowEnter(dgvBanco, new DataGridViewCellEventArgs(0, 0));
                CalcularTotales();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de banco.", "Admin CSY", ex);
            }
        }

        private void CalcularTotales()
        {
            decimal vou = 0M;
            foreach (DataGridViewRow dr in dgvBanco.Rows)
            {
                vou += (decimal)dr.Cells[3].Value;
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Array a = (Array)e.Argument;
            if (a.Length == 2)
            {
                Buscar((DateTime)a.GetValue(0), (DateTime)a.GetValue(1));
            }
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void dgvCaja_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBanco.CurrentRow != null)
                id = (int)dgvBanco[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!bgwBusqueda.IsBusy)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
            }
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando movimientos de banco", this);
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
        }
    }
}
