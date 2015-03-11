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
    public partial class frmIngresarUsuario : Form
    {
        frmReestablecerPass frm;
        public frmIngresarUsuario(frmReestablecerPass frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void ObtenerCorreoUsuario(string usuario)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, email FROM usuario WHERE username=?username";
                sql.Parameters.AddWithValue("?username", usuario);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    frm.Correo = dr["email"].ToString();
                    frm.ID = (int)dr["id"];
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void EnviarCódigoVerificación()
        {
            try
            {
                Usuario.CrearNumeroAutorizacion(frm.ID, frm.Correo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bgwVerificar_DoWork(object sender, DoWorkEventArgs e)
        {
            ObtenerCorreoUsuario(e.Argument.ToString());
        }

        private void bgwVerificar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (frm.Correo != "")
            {
                lblCorreo.Text = frm.Correo;
            }
            else
            {
                lblCorreo.Text = "El usuario ingresado no existe o no tiene un correo asignado.";
            }
            lblCorreo.Left = (this.Width - lblCorreo.Width) / 2;
            lblCorreo.Visible = true;
            btnCodigoCorreo.Visible = true;
        }

        private void btnVerificarUsuario_Click(object sender, EventArgs e)
        {
            bgwVerificar.RunWorkerAsync(txtUsuario.Text);
        }

        private void btnCodigoCorreo_Click(object sender, EventArgs e)
        {
            if (FuncionesGenerales.EsCorreoValido(lblCorreo.Text))
            {
                EnviarCódigoVerificación();
                frm.CambioFormulario(new frmVerificarUsuario(frm));
            }
            else
            {
                MessageBox.Show("Necesitas tener registrado un correo válido para poder continuar.", "EC-Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }    
    }
}
