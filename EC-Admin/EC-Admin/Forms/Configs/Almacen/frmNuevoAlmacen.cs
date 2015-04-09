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
    public partial class frmNuevoAlmacen : Form
    {
        private int idTrabajador;

        public int IDTrabajador
        {
            get { return idTrabajador; }
            set
            {
                idTrabajador = value;
            }
        }

        public string NombreTrabajador
        {
            get { return lblJefeAlmacen.Text; }
            set { lblJefeAlmacen.Text = value; }
        }
        
        public frmNuevoAlmacen()
        {
            InitializeComponent();
        }

        private void Insertar()
        {
            try
            {
                Almacen a = new Almacen();
                a.IDTrabajador = idTrabajador;
                a.NumeroAlmacen = int.Parse(txtNumAlm.Text);
                a.Descripcion = txtDescripcion.Text;
                a.Insertar();
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
            if (txtNumAlm.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo número de almacen es obligatorio", "EC-Admin");
                return false;
            }
            if (txtDescripcion.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo descripción es obligatorio", "EC-Admin");
                return false;
            }
            if (idTrabajador <= 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes asignar a un jefe de almacen", "EC-Admin");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado correctamente el almacen!", "EC-Admin");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el almacen. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el almacen. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                }
            }
        }

        private void txtNumAlm_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            (new frmAlmacenTrabajador(this)).ShowDialog(this);
        }
    }
}
