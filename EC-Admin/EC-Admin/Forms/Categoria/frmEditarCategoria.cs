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
    public partial class frmEditarCategoria : Form
    {
        Categoria c;

        public frmEditarCategoria(int id)
        {
            InitializeComponent();
            c = new Categoria(id);
        }

        private void CargarDatos()
        {
            c.ObtenerDatos();
            txtNombre.Text = c.Nombre;
            txtDescripcion.Text = c.Descripcion;
        }

        private void Editar()
        {
            try
            {
                c.Nombre = txtNombre.Text;
                c.Descripcion = txtDescripcion.Text;
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
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio", "EC-Admin");
                return false;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo descripción es obligatorio", "EC-Admin");
                return false;
            }
            return true;
        }

        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Editar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado correctamente la categoría!", "EC-Admin");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar la categoría. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar la categoría.", "EC-Admin", ex);
                }
            }
        }
    }
}
