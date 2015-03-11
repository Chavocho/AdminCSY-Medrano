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
    public partial class frmConfigBaseDatos : Form
    {
        bool reiniciar;
        public frmConfigBaseDatos(bool reiniciar)
        {
            InitializeComponent();
            this.reiniciar = reiniciar;
        }

        private void Cargar()
        {
            txtServer.Text = Config.servidor;
            txtBase.Text = Config.baseDatos;
            txtUsuario.Text = Config.usuario;
            txtPass.Text = Config.pass;
        }

        private void Guardar()
        {
            ConfiguracionXML.GuardarConfiguracion("basedatos", "server", txtServer.Text);
            ConfiguracionXML.GuardarConfiguracion("basedatos", "base", txtBase.Text);
            ConfiguracionXML.GuardarConfiguracion("basedatos", "usuario", txtUsuario.Text);
            ConfiguracionXML.GuardarConfiguracion("basedatos", "pass", txtPass.Text);
            Config.servidor = txtServer.Text;
            Config.baseDatos = txtBase.Text;
            Config.usuario = txtUsuario.Text;
            Config.pass = txtPass.Text;
        }

        private void frmConfigBaseDatos_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult r = FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Es correcta la información?", "EC-Admin");
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                Guardar();
                this.Close();
            }
        }

        private void frmConfigBaseDatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reiniciar)
            {
                MessageBox.Show("La aplicación se reiniciará.", "EC-Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }
    }
}
