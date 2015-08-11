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
    public partial class frmUsuarios : Form
    {
        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        #region Instancia
        private static frmUsuarios frmInstancia;
        public static frmUsuarios Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmUsuarios();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmUsuarios();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void BuscarUsuarios()
        {
            try
            {
                string sql = "SELECT id, username, nombre, apellidos, nivel, email FROM usuario WHERE eliminado=0 AND sucursal_id='" + Config.idSucursal + "'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los usuarios. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error genérico al buscar los usuarios.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            dgvUsuarios.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string nivel = "";
                switch (dr["nivel"].ToString())
                {
                    case "0":
                        nivel = "Administrador";
                        break;
                    case "1":
                        nivel = "Encargado";
                        break;
                    case "2":
                        nivel = "Desconocido";
                        break;
                }
                dgvUsuarios.Rows.Add(dr["id"], dr["username"], dr["nombre"].ToString() + " " + dr["apellidos"].ToString(), dr["email"], nivel, dr["nivel"]);
            }
            dgvUsuarios_RowEnter(dgvUsuarios, new DataGridViewCellEventArgs(0, 0));
        }

        private void Editar()
        {
            (new frmEditarUsuario(id)).ShowDialog(this);
            tmrEspera.Enabled = true;
            bgwUsuarios.RunWorkerAsync();
        }

        private void Eliminar()
        {
            DialogResult r = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente deseas eliminar a " + dgvUsuarios[2, dgvUsuarios.CurrentRow.Index].Value.ToString() + "?", "Admin CSY");
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                Usuario.CambiarEstadoEliminadoUsuario(id, true);
                tmrEspera.Enabled = true;
                bgwUsuarios.RunWorkerAsync();
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            tmrEspera.Enabled = true;
            bgwUsuarios.RunWorkerAsync();
        }

        private void bgwUsuarios_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarUsuarios();
        }

        private void bgwUsuarios_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (Privilegios._CrearUsuario)
            {
                (new frmNuevoUsuario()).ShowDialog(this);
                bgwUsuarios.RunWorkerAsync();
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (Privilegios._ModificarUsuario)
            {
                if (dgvUsuarios.CurrentRow != null)
                {
                    Editar();
                }
            }
            else
            {
                if (dgvUsuarios.CurrentRow != null)
                {
                    if (id == Usuario.IDUsuarioActual)
                    {
                        Editar();
                    }
                    else
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
                    }
                }
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (Privilegios._EliminarUsuario)
            {
                try
                {
                    if (dgvUsuarios.CurrentRow != null)
                    {
                        Eliminar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }

        private void dgvUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                id = (int)dgvUsuarios[0, e.RowIndex].Value;
            }
            else
            {
                id = 0;
            }
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Buscando usuarios, espere", this);
        }

        private void btnUsuariosEliminados_Click(object sender, EventArgs e)
        {
            if (Privilegios._ReestablecerUsuario)
            {
                (new frmUsuariosEliminados()).ShowDialog(this);
                tmrEspera.Enabled = true;
                bgwUsuarios.RunWorkerAsync();
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }
    }
}
