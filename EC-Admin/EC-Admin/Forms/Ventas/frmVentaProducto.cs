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
    public partial class frmVentaProducto : Form
    {
        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        frmPOS frm;

        public frmVentaProducto(frmPOS frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void Cerrar()
        {
            txtBusqueda.Enabled = true;
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(string p)
        {
            try
            {
                string sql = "SELECT p.id, p.nombre, a.num_alm, p.codigo, p.precio, p.cant, p.unidad FROM producto AS p INNER JOIN almacen AS a ON (p.almacen_id=a.id) " +
                    "WHERE (p.nombre LIKE '%" + p + "%' OR p.codigo='" + p + "') AND p.eliminado=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos. No se ha podido conectar a la base de datos.", "EC-Admin", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos.", "EC-Admin", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvProductos.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvProductos.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["num_alm"], dr["codigo"], dr["precio"], dr["cant"], dr["unidad"] });
                }
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
            }
        }

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                id = (int)dgvProductos[0, e.RowIndex].Value;
            else
                id = 0;
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
            FuncionesGenerales.frmEspera("Espere, buscando productos", this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                DataGridViewRow dr = dgvProductos.CurrentRow;
                frm.AgregarProducto((int)dr.Cells[0].Value, dr.Cells[3].Value.ToString(), dr.Cells[1].Value.ToString(), (decimal)dr.Cells[4].Value, nudCant.Value, decimal.Parse(txtDescuento.Text), (Unidades)Enum.Parse(typeof(Unidades), dr.Cells[6].Value.ToString()));
                this.Close();
            }
        }

    }
}
