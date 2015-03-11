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
    public partial class frmDatosPuesto : Form
    {
        bool editar = false;
        Trabajador t;

        public frmDatosPuesto()
        {
            InitializeComponent();
            t = new Trabajador();
        }

        public frmDatosPuesto(int id)
        {
            InitializeComponent();
            t = new Trabajador();
            t.IDPuesto = id;
            editar = true;
        }

        private void ObtenerDatos()
        {
            try
            {
                t.ObtenerDatosPuesto();
                txtNombre.Text = t.NombrePuesto;
                txtDepartamento.Text = t.DepartamentoPuesto;
            }
            catch (MySqlException ex)
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
                t.NombrePuesto = txtNombre.Text;
                t.DepartamentoPuesto = txtDepartamento.Text;
                t.InsertarPuesto();
            }
            catch (MySqlException ex)
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
                t.NombrePuesto = txtNombre.Text;
                t.DepartamentoPuesto = txtDepartamento.Text;
                t.EditarPuesto();
            }
            catch (MySqlException ex)
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
            if (txtDepartamento.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo departamento es obligatorio", "EC-Admin");
                return false;
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
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado correctamente el puesto!", "EC-Admin");
                        this.Close();
                    }
                    catch (MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el puesto. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el puesto.", "EC-Admin", ex);
                    }
                }
                else
                {
                    try
                    {
                        Editar();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado correctamente el puesto!", "EC-Admin");
                        this.Close();
                    }
                    catch (MySqlException ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el puesto. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                    }
                    catch (Exception ex)
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al modificar el puesto.", "EC-Admin", ex);
                    }
                }
            }
        }

        private void frmDatosPuesto_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                ObtenerDatos();
            }
        }
    }
}
