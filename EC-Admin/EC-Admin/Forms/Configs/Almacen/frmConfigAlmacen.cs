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
    public partial class frmConfigAlmacen : Form
    {
        #region Instancia
        private static frmConfigAlmacen frmInstancia;
        public static frmConfigAlmacen Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfigAlmacen();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfigAlmacen();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmConfigAlmacen()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar()
        {
            try
            {
                string sql = "SELECT a.*, t.nombre, t.apellidos FROM almacen AS a INNER JOIN trabajador AS t ON (a.id_trabajador=t.id)";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los almacenes. No se ha podido conectar con la base de datos.", "EC-Admin", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los almacenes.", "EC-Admin", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dgvAlmacen.Rows.Add(new object[] { dr["id"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dr["num_alm"], dr["descripcion"].ToString() });
                }
                dgvAlmacen_RowEnter(dgvAlmacen, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de los almacenes.", "EC-Admin", ex);
            }
        }

        private void frmConfigAlmacen_Load(object sender, EventArgs e)
        {
            bgwBusqueda.RunWorkerAsync();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void dgvAlmacen_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlmacen.CurrentRow != null)
                id = (int)dgvAlmacen[0, e.RowIndex].Value;
            else
                id = 0;
        }
    }
}
