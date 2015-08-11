using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin
{
    public partial class frmLogin : Form
    {
        bool cancelo;

        public frmLogin()
        {
            InitializeComponent();
            FuncionesGenerales.DeshabilitarBotonCerrar(this);
            cancelo = true;
        }

        async private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Task<bool> t = Usuario.VerificarIngresoUsuario(txtUsuario.Text, txtPass.Text);
                await t;
                if (t.Result)
                {
                    frmPrincipal.Instancia.Show();
                    cancelo = false;
                    this.Close();
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El usuario y/o contraseña no coinciden.", "Admin CSY");
                    txtPass.Text = "";
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al verificar los datos del usuario. No se ha podido conectar a la base de datos.", Config.shrug, ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al verificar los datos del usuario.", Config.shrug, ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelo)
            {
                Application.Exit();
                ConexionBD.CerrarConexion();
            }
        }

        private void llbReestablecer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPass.Text = "";
            (new Forms.frmReestablecerPass()).ShowDialog(this);
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (Usuario.CantidadUsuarios == 0)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "No tienes usuarios registrados, ¿deseas crear uno?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    (new Forms.frmNuevoUsuario()).Show();
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La aplicación se cerrará. Puede crear un usuario la próxima vez que lo abra.", "Admin CSY");
                    btnCancelar.PerformClick();
                }
            }
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((new frmDescripcion()).Descripcion());
            //FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Algo", "¯\\_(ツ)_/¯");
            //FuncionesGenerales.Mensaje(this, Mensajes.Error, "Algo", "¯\\_(ツ)_/¯");
            //FuncionesGenerales.Mensaje(this, Mensajes.Exito, "Algo", "¯\\_(ツ)_/¯");
            //FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "Algo", "¯\\_(ツ)_/¯");
            //FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "Algo", "¯\\_(ツ)_/¯");
            //Cliente.ClienteGeneral();
            //(new frmEspera("Algo")).ShowDialog(this);
            //Application.Restart();
            //FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error de prueba.", "¯\\_(ツ)_/¯", new Exception("Algo"));
            Properties.Settings.Default.PrimerUso = true;
            Properties.Settings.Default.Save();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }
    }
}
