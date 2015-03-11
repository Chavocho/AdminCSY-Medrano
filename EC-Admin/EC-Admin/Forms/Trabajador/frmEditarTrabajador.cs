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
    public partial class frmEditarTrabajador : Form
    {
        Trabajador t;
        List<int> idSucursal = new List<int>();
        List<int> idPuesto = new List<int>();

        public frmEditarTrabajador(int id)
        {
            InitializeComponent();
            t = new Trabajador();
            t.ID = id;
        }
        private void CargarSucursales()
        {
            try
            {
                string sql = "SELECT id, nombre FROM sucursal WHERE eliminado=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idSucursal.Add((int)dr["id"]);
                    cboSucursal.Items.Add(dr["nombre"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarPuestos()
        {
            try
            {
                string sql = "SELECT id, nombre, departamento FROM puesto";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idPuesto.Add((int)dr["id"]);
                    cboPuesto.Items.Add(dr["nombre"].ToString() + "/" + dr["departamento"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int SeleccionarSucursal(int id)
        {
            int suc = 0;
            for (int i = 0; i < idSucursal.Count; i++)
            {
                if (idSucursal[i] == id)
                {
                    suc = i;
                    break;
                }
            }
            return suc;
        }

        private int SeleccionarPuesto(int id)
        {
            int pue = 0;
            for (int i = 0; i < idPuesto.Count; i++)
            {
                if (idPuesto[i] == id)
                {
                    pue = i;
                    break;
                }
            }
            return pue;
        }

        private void CargarDatos()
        {
            try
            {
                t.ObtenerDatos();
                cboSucursal.SelectedIndex = SeleccionarSucursal(t.IDSucursal);
                txtNombre.Text = t.Nombre;
                txtApellidos.Text = t.Apellidos;
                cboPuesto.SelectedIndex = SeleccionarPuesto(t.Puesto);
                txtTelefono.Text = t.Telefono;
                txtCelular.Text = t.Celular;
                txtCorreo.Text = t.Correo;
                txtDireccion.Text = t.Direccion;
                txtCiudad.Text = t.Ciudad;
                txtEstado.Text = t.Estado;
                txtCP.Text = t.CP.ToString();
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
                t.IDSucursal = idSucursal[cboSucursal.SelectedIndex];
                t.Puesto = idPuesto[cboPuesto.SelectedIndex];
                t.Nombre = txtNombre.Text;
                t.Apellidos = txtApellidos.Text;
                t.Telefono = txtTelefono.Text;
                t.Celular = txtCelular.Text;
                t.Correo = txtCorreo.Text;
                t.Direccion = txtDireccion.Text;
                t.Ciudad = txtCiudad.Text;
                t.Estado = txtEstado.Text;
                t.CP = int.Parse(txtCP.Text);
                t.Editar();
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
            if (cboSucursal.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Se debe seleccionar una sucursal asociada con éste trabajador.", "EC-Admin");
                return false;
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo apellidos es obligatorio.", "EC-Admin");
                return false;
            }
            if (cboPuesto.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Se debe seleccionar un puesto asociado con éste trabajador.", "EC-Admin");
                return false;
            }
            if (txtTelefono.Text.Trim() == "" && txtCelular.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un número de teléfono.", "EC-Admin");
                return false;
            }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no se reconoce cómo uno válido.", "EC-Admin");
                    return false;
                }
            }
            if (txtDireccion.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo dirección es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtCiudad.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo ciudad es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtEstado.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo estado es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtCP.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo código postal es obligatorio.", "EC-Admin");
                return false;
            }
            return true;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void frmEditarTrabajador_Load(object sender, EventArgs e)
        {
            CargarPuestos();
            CargarSucursales();
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Editar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado el trabajador correctamente!", "EC-Admin");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar el trabajador. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al modificar el trabajador.", "EC-Admin", ex);
                }
            }
        }

    }
}
