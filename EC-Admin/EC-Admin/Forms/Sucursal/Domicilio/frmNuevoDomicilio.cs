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
    public partial class frmNuevoDomicilio : Form
    {
        public frmNuevoDomicilio()
        {
            InitializeComponent();
        }

        private void Insertar()
        {
            try
            {
                Sucursal s = new Sucursal();
                s.CalleFiscal = txtCalle.Text;
                s.NumeroExteriorFiscal = txtNumExt.Text;
                s.NumeroInteriorFiscal = txtNumInt.Text;
                s.CPFiscal = txtCP.Text;
                s.ColoniaFiscal = txtColonia.Text;
                s.CiudadFiscal = txtCiudad.Text;
                s.EstadoFiscal = txtEstado.Text;
                s.InsertarDireccion();
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
            if (txtCalle.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtCalle);
                res = false;
            }
            if (txtNumInt.Text != "" && txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtNumExt);
                FuncionesGenerales.ColoresError(txtNumInt);
                res = false;
            }
            if (txtNumExt.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtNumExt);
                res = false;
            }
            if (txtCP.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtCP);
                res = false;
            }
            if (txtColonia.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtColonia);
                res = false;
            }
            if (txtCiudad.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtCiudad);
                res = false;
            }
            if (txtEstado.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtEstado);
                res = false;
            }
            return res;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el domicilio fiscal correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el domicilio. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el domicilio.", "Admin CSY", ex);
                }
            }
        }
    }
}
