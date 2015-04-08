using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EC_Admin.Forms;

namespace EC_Admin
{
    public partial class frmPrincipal : Form
    {
        bool cierreSesion = false;

        #region Instancia
        private static frmPrincipal frmInstancia;
        public static frmPrincipal Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmPrincipal();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmPrincipal();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void DatosUsuario()
        {
            pcbUsuario.Image = Usuario.ImagenUsuarioActual;
            lblNomUsuario.Text = Usuario.NombreUsuarioActual + "\n" + Usuario.ApellidosUsuarioActual;
            lblNomUsuario.Left = pcbUsuario.Right - lblNomUsuario.Width;
        }

        internal void UserDataChanged(object sender, EventArgs e)
        {
            DatosUsuario();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DatosUsuario();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cierreSesion = true;
            this.Close();
            (new frmLogin()).Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cierreSesion)
            {
                Application.Exit();
                ConexionBD.CerrarConexion();
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (!frmConfigs.Instancia.Visible)
                frmConfigs.Instancia.Show();
            else
                frmConfigs.Instancia.Select();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (!frmPOS.Instancia.Visible)
                frmPOS.Instancia.Show();
            else
                frmPOS.Instancia.Select();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {

        }

        private void btnCaja_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (!frmClientes.Instancia.Visible)
                frmClientes.Instancia.Show();
            else
                frmClientes.Instancia.Select();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (!frmProveedor.Instancia.Visible)
                frmProveedor.Instancia.Show();
            else
                frmProveedor.Instancia.Select();
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            if (!frmTrabajador.Instancia.Visible)
                frmTrabajador.Instancia.Show();
            else
                frmTrabajador.Instancia.Select();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (!frmProducto.Instancia.Visible)
                frmProducto.Instancia.Show();
            else
                frmProducto.Instancia.Select();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }
    
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (!frmUsuarios.Instancia.Visible)
                frmUsuarios.Instancia.Show();
            else
                frmUsuarios.Instancia.Select();
        }
    }
}
