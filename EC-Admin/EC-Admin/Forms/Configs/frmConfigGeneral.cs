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
    public partial class frmConfigGeneral : Form
    {
        #region Instancia
        private static frmConfigGeneral frmInstancia;
        public static frmConfigGeneral Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfigGeneral();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfigGeneral();
                return frmInstancia;

            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmConfigGeneral()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            if (ConfiguracionXML.ExisteConfiguracion("POS"))
            {
                txtIVA.Text = ConfiguracionXML.LeerConfiguración("POS", "IVA");
            }
        }

        private void Guardar()
        {
            ConfiguracionXML.GuardarConfiguracion("POS", "IVA", txtIVA.Text);
            Config.iva = decimal.Parse(txtIVA.Text);
        }

        private bool VerificarCampos()
        {
            bool res = true;
            if (txtIVA.Text.Trim() == "")
            {
                txtIVA.Text = "0";
            }
            return res;
        }

        private void frmConfigGeneral_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar la configuración", "Admin CSY", ex);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarCampos())
                {
                    Guardar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha guardado correctamente la configuración!", "Admin CSY");
                    this.Close();
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Los campos en rojo son obligatorios", "Admin CSY");
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar la configuración", "Admin CSY", ex);
            }
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void txtNumerosDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }
    }
}
