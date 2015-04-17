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
                DialogResult r = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "No tienes configurada tu conexión con la base de datos. ¿Deseas configurarla?", "EC-Admin");
                if (r == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Forms.frmConfigBaseDatos(false)).ShowDialog(this);
                    ConfiguracionBaseDatos();
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La aplicación se cerrará.", "EC-Admin");
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
            VerificarConexion();
        }

        /// <summary>
        /// Método que verifica la conexión con la base de datos
        /// </summary>
        private void VerificarConexion()
        {
            try
            {
                if (!ConexionBD.Ping())
                {
                    DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "EC-Admin");
                    if (re == System.Windows.Forms.DialogResult.Yes)
                    {
                        (new Forms.frmConfigBaseDatos(true)).ShowDialog(this);
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "EC-Admin");
                if (re == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Forms.frmConfigBaseDatos(true)).ShowDialog(this);
                }
            }
            catch (Exception)
            {
                DialogResult re = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "La conexión con los datos ingresados no se ha logrado efectuar, ¿desea modificarlos?", "EC-Admin");
                if (re == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Forms.frmConfigBaseDatos(true)).ShowDialog(this);
                }
            }
        }

        /// <summary>
        /// Función que carga los datos de la sucursal
        /// </summary>
        private void ConfiguracionSucursal()
        {
            if (ConfiguracionXML.ExisteConfiguracion("sucursal"))
            {
                Config.idSucursal = int.Parse(ConfiguracionXML.LeerConfiguración("sucursal", "id"));
                Config.nombreSucursal = ConfiguracionXML.LeerConfiguración("sucursal", "nombre");
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

        #region Paso 03
        private void ClienteGeneral()
        {
            if (Cliente.Cantidad == 0)
            {
                Cliente.ClienteGeneral();
            }
        }
        #endregion

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            try
            {
                ConfiguracionBaseDatos();
                ConfiguracionSucursal();
                InicializarCantidades();
                ClienteGeneral();
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
