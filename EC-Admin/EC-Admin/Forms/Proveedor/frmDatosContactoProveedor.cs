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
    public partial class frmDatosContactoProveedor : Form
    {
        ProveedorContacto p;
        bool editar = false;

        public frmDatosContactoProveedor(ProveedorContacto p)
        {
            InitializeComponent();
            this.p = p;
        }

        public frmDatosContactoProveedor(int id, ProveedorContacto p)
        {
            InitializeComponent();
            this.p = p;
            this.p.ID = id;
        }

        private void ObtenerDatosContacto()
        {
            try
            {
                p.ObtenerDatosContacto();
                txtNombre.Text = p.Nombre;
                txtApellidos.Text = p.Apellidos;
                txtLada01.Text = p.Lada01;
                txtTelefono01.Text = p.Telefono01;
                txtLada02.Text = p.Lada02;
                txtTelefono02.Text = p.Telefono02;
                txtExt.Text = p.Extension;
                txtCelular.Text = p.Celular;
                txtCorreo.Text = p.Correo;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Insertar()
        {
            try
            {
                p.Nombre = txtNombre.Text;
                p.Apellidos = txtApellidos.Text;
                p.Lada01 = txtLada01.Text;
                p.Lada02 = txtLada02.Text;
                p.Telefono01 = txtTelefono01.Text;
                p.Telefono02 = txtTelefono02.Text;
                p.Extension = txtExt.Text;
                p.Celular = txtCelular.Text;
                p.Correo = txtCorreo.Text;
                p.Insertar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Editar()
        {
            try
            {
                p.Nombre = txtNombre.Text;
                p.Apellidos = txtApellidos.Text;
                p.Lada01 = txtLada01.Text;
                p.Lada02 = txtLada02.Text;
                p.Telefono01 = txtTelefono01.Text;
                p.Telefono02 = txtTelefono02.Text;
                p.Extension = txtExt.Text;
                p.Celular = txtCelular.Text;
                p.Correo = txtCorreo.Text;
                p.Editar();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerificarDatos()
        {
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio", "EC-Admin");
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo apellidos es obligatorio", "EC-Admin");
                return false;
            }
            if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un teléfono", "EC-Admin");
                return false;
            }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No se reconoce el correo ingresado como uno válido", "EC-Admin");
                    return false;
                }
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (!editar)
                {
                    try
                    {
                        Insertar();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado correctamente el contacto!", "EC-Admin");
                        this.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el contacto. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el contacto.", "EC-Admin", ex);
                    }
                }
                else
                {
                    try
                    {
                        Editar();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado correctamente el contacto!", "EC-Admin");
                        this.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el contacto. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al modificar el contacto.", "EC-Admin", ex);
                    }
                }
            }
        }

        private void frmDatosContactoProveedor_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                try
                {
                    ObtenerDatosContacto();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener los datos del contacto. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al obtener los datos del contacto.", "EC-Admin", ex);
                }
            }
        }

    }
}
