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
    public partial class frmDevolucionesVenta : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmDevolucionesVenta()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(string p)
        {
            try
            {
                string sql = "SELECT id, saldo, create_time FROM devolucion WHERE id='" + p + "'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Invoke(c);
                Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las devoluciones. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Invoke(c);
                Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las devoluciones.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvDevoluciones.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvDevoluciones.Rows.Add(new object[] { dr["id"], dr["saldo"], dr["create_time"] });
                    Application.DoEvents();
                }
                dgvDevoluciones_RowEnter(dgvDevoluciones, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar las devoluciones.", "Admin CSY", ex);
            }
        }

        public int IDDevolucion()
        {
            if (!this.Visible)
                this.ShowDialog();
            this.Close();
            return id;
        }

        private void dgvDevoluciones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDevoluciones.CurrentRow != null)
                id = (int)dgvDevoluciones[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !bgwBusqueda.IsBusy)
            {
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
                tmrEspera.Enabled = true;
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Buscar(e.Argument.ToString());
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, estamos buscando las devoluciones", this);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas usar el saldo de ésta devolución?", "Admin CSY") == DialogResult.Yes)
            {
                IDDevolucion();
            }
        }
    }
}
