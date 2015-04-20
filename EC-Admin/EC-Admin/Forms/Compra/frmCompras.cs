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
    public partial class frmCompras : Form
    {
        #region Instancia
        private static frmCompras frmInstancia;
        public static frmCompras Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmCompras();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmCompras();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmCompras()
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
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT c.total, SUM(d.cant) AS cant, c.create_time FROM compra INNER JOIN compra_detallada ON (c.id=?d.id_compra) WHERE c.create_time BETWEEN (?fechaIni AND ?fechaFin)";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaIni", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las compras. No se ha podido conectar a la base de datos.", "EC-Admin", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las compras.", "EC-Admin", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvCompras.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvCompras.Rows.Add(new object[] { dr["create_user"], dr["total"], dr["cant"] });
                }
                dgvCompras_RowEnter(dgvCompras, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar la información de la venta.", "EC-Admin", ex);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
        }

        private void dgvCompras_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompras.CurrentRow != null)
                id = (int)dgvCompras[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevaCompra()).ShowDialog(this);
        }
    }
}
