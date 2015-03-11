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
    public partial class frmEditarDomicilio : Form
    {
        Sucursal s;
        public frmEditarDomicilio(int id)
        {
            InitializeComponent();
            s = new Sucursal();
            s.IDDireccion = id;
        }

        private void CargarDatos()
        {
            try
            {
                s.ObtenerDatosDireccion();
                txtCalle.Text = s.CalleFiscal;
                txtNumExt.Text = s.NumeroExteriorFiscal;
                txtNumInt.Text = s.NumeroInteriorFiscal;
                txtCP.Text = s.CPFiscal;
                txtColonia.Text = s.ColoniaFiscal;
                txtCiudad.Text = s.CiudadFiscal;
                txtEstado.Text = s.EstadoFiscal;
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
                s.CalleFiscal = txtCalle.Text;
                s.NumeroExteriorFiscal = txtNumExt.Text;
                s.NumeroInteriorFiscal = txtNumInt.Text;
                s.CPFiscal = txtCP.Text;
                s.ColoniaFiscal = txtColonia.Text;
                s.CiudadFiscal = txtCiudad.Text;
                s.EstadoFiscal = txtEstado.Text;
                s.EditarDireccion();
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
            if (txtCalle.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo calle es obligatorio", "EC-Admin");
                return false;
            }
            if (txtNumInt.Text != "" && txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Se debe ingresar el campo número exterior antes que el número interior", "EC-Admin");
                return false;
            }
            if (txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo calle es obligatorio", "EC-Admin");
                return false;
            }
            if (txtCP.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo calle es obligatorio", "EC-Admin");
                return false;
            }
            if (txtColonia.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo calle es obligatorio", "EC-Admin");
                return false;
            }
            if (txtCiudad.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo calle es obligatorio", "EC-Admin");
                return false;
            }
            if (txtEstado.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo calle es obligatorio", "EC-Admin");
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
                    Editar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado correctamente la dirección!", "EC-Admin");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al modificar la dirección. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al modificar la dirección.", "EC-Admin", ex);
                }
            }
        }

        private void frmEditarDomicilio_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
