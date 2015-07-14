﻿using System;
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
    public partial class frmDatosContactoCliente : Form
    {
        ClienteContacto c;
        bool editar = false;

        public frmDatosContactoCliente(ClienteContacto c)
        {
            InitializeComponent();
            this.c = c;
        }

        public frmDatosContactoCliente(int id, ClienteContacto c)
        {
            InitializeComponent();
            this.c = c;
            c.ID = id;
            editar = true;
        }

        private void ObtenerDatosContacto()
        {
            try
            {
                c.ObtenerDatosContacto();
                txtNombre.Text = c.Nombre;
                txtApellidos.Text = c.Apellidos;
                txtLada01.Text = c.Lada01;
                txtTelefono01.Text = c.Telefono01;
                txtLada02.Text = c.Lada02;
                txtTelefono02.Text = c.Telefono02;
                txtExt.Text = c.Extension;
                txtCelular.Text = c.Celular;
                txtCorreo.Text = c.Correo;
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
                c.Nombre = txtNombre.Text;
                c.Apellidos = txtApellidos.Text;
                c.Lada01 = txtLada01.Text;
                c.Lada02 = txtLada02.Text;
                c.Telefono01 = txtTelefono01.Text;
                c.Telefono02 = txtTelefono02.Text;
                c.Extension = txtExt.Text;
                c.Celular = txtCelular.Text;
                c.Correo = txtCorreo.Text;
                c.Insertar();
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
                c.Nombre = txtNombre.Text;
                c.Apellidos = txtApellidos.Text;
                c.Lada01 = txtLada01.Text;
                c.Lada02 = txtLada02.Text;
                c.Telefono01 = txtTelefono01.Text;
                c.Telefono02 = txtTelefono02.Text;
                c.Extension = txtExt.Text;
                c.Celular = txtCelular.Text;
                c.Correo = txtCorreo.Text;
                c.Editar();
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
            bool res = true;
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtNombre);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNombre);
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtApellidos);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtApellidos);
            }
            if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtTelefono01);
                res = false;
            }
            else if (txtTelefono01.Text.Trim() == "" && txtTelefono02.Text.Trim() != "")
            {
                txtTelefono01.Text = txtTelefono02.Text;
                txtTelefono02.Text = "";
                FuncionesGenerales.ColoresBien(txtTelefono01);
                FuncionesGenerales.ColoresBien(txtTelefono02);
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtTelefono01);
                FuncionesGenerales.ColoresBien(txtTelefono02);
            }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.ColoresError(txtCorreo); 
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No se reconoce el correo ingresado como uno válido", "Admin CSY");
                    res = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtCorreo);
                }
            }
            return res;
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
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado correctamente el contacto!", "Admin CSY");
                        this.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el contacto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el contacto.", "Admin CSY", ex);
                    }
                }
                else
                {
                    try
                    {
                        Editar();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado correctamente el contacto!", "Admin CSY");
                        this.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el contacto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al modificar el contacto.", "Admin CSY", ex);
                    }
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "¡Los campos en rojo son obligatorios o tienen un error!", "Admin CSY");
            }
        }

        private void frmDatosContactoCliente_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                try
                {
                    ObtenerDatosContacto();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener los datos del contacto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al obtener los datos del contacto.", "Admin CSY", ex);
                }
            }
        }

        private void txtTelefono01_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLada01_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono02_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLada02_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
