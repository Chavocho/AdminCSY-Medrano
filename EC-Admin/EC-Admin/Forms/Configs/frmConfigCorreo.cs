using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin.Forms.Configs
{
    public partial class frmConfigCorreo : Form
    {
        public frmConfigCorreo()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            txtCorreo.Text = Config.correoOrigenExterno;
            txtPass.Text = Config.contraseñaOrigenExterno;
            txtHost.Text = Config.hostExterno;
            txtPuerto.Text = Config.puertoExterno;
        }

        private void GuardarDatos()
        {
            Config.correoOrigenExterno = txtCorreo.Text;
            Config.contraseñaOrigenExterno = txtPass.Text;
            Config.hostExterno = txtHost.Text;
            Config.puertoExterno = txtPuerto.Text;
            ConfiguracionXML.GuardarConfiguracion("correo", "correo", txtCorreo.Text);
            ConfiguracionXML.GuardarConfiguracion("correo", "pass", txtPass.Text);
            ConfiguracionXML.GuardarConfiguracion("correo", "host", txtHost.Text);
            ConfiguracionXML.GuardarConfiguracion("correo", "puerto", txtPuerto.Text);
        }

        private bool VerificarDatos()
        {
            if (txtCorreo.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo correo es obligatorio", "EC-Admin");
                return false;
            }
            else
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no se reconoce como válido", "EC-Admin");
                    return false;
                }
            }
            if (txtHost.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo host es obligatorio", "EC-Admin");
                return false;
            }
            if (txtPuerto.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo puerto es obligatorio", "EC-Admin");
                return false;
            }
            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                GuardarDatos();
                FuncionesGenerales.Mensaje(this, Mensajes.Exito, "Se ha guardado la configuración con éxito", "EC-Admin");
                this.Close();
            }
        }

        private void txtPuerto_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }
    }
}
