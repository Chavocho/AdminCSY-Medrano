using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin
{
    public partial class frmSplash : Form
    {
        int c = 0;
        public frmSplash()
        {
            InitializeComponent();
        }

        #region Paso 01
        /// <summary>
        /// Función que verifica que la configuración de la base de datos exista en el archivo de configuración,
        /// en caso de que no exista, lo crea.
        /// </summary>
        private void ConfiguracionBaseDatos()
        {
            if (!ConfiguracionXML.ExisteConfiguracion("basedatos"))
            {
                DialogResult r = MessageBox.Show("No tienes configurada tu conexión con la base de datos. ¿Deseas configurarla?", "EC-Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Forms.frmConfigBaseDatos(false)).ShowDialog(this);
                    ConfiguracionBaseDatos();
                }
                else
                {
                    MessageBox.Show("La aplicación se cerrará.", "EC-Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
            else
            {
                Config.servidor = ConfiguracionXML.LeerConfiguración("basedatos", "server");
                Config.baseDatos = ConfiguracionXML.LeerConfiguración("basedatos", "base");
                Config.usuario = ConfiguracionXML.LeerConfiguración("basedatos", "usuario");
                Config.pass = ConfiguracionXML.LeerConfiguración("basedatos", "pass");
            }
        }
        #endregion

        #region Paso 02
        //Inicializamos las variables de cantidad en las clases
        private void InicializarCantidades()
        {
            int cant = 0;
            cant = Cliente.Cantidad;
            cant = Cliente.CantidadCredito;
            cant = Cliente.CantidadSinCredito;
            cant = ClienteContacto.Cantidad;
            cant = Proveedor.Cantidad;
            cant = Proveedor.CantidadCredito;
            cant = Proveedor.CantidadSinCredito;
            //cant = ProveedorContacto.Cantidad;
            cant = Puesto.Cantidad;
            cant = Sucursal.Cantidad;
            cant = Sucursal.CantidadDomicilios;
            cant = Trabajador.Cantidad;
            cant = Usuario.CantidadUsuarios;
            cant = Usuario.CantidadUsuariosAdministrador;
            cant = Usuario.CantidadUsuariosEncargado;
            cant = Usuario.CantidadUsuariosDesconocido;
        }
        #endregion

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            try
            {
                ConfiguracionBaseDatos();
                ConexionBD.AbrirConexion();
                InicializarCantidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            (new frmLogin()).Show();
            this.Close();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            c += 1;
        }
    }
}
