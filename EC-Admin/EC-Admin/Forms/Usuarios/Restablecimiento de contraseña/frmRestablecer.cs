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
    public partial class frmReestablecer : Form
    {
        frmReestablecerPass frm;
        public frmReestablecer(frmReestablecerPass frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void ActualizarPass(string pass)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE usuario SET pass=?pass WHERE id=?id";
                sql.Parameters.AddWithValue("?pass", Criptografia.Cifrar(pass));
                sql.Parameters.AddWithValue("?id", frm.ID);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool VerificarDatos()
        {
            bool res = true;
            if (txtPass.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtPass);
                res = false;
            }
            else
            {
                if (txtPass.Text != txtRepPass.Text)
                {
                    FuncionesGenerales.ColoresError(txtRepPass);
                    FuncionesGenerales.ColoresError(txtPass);
                    res = false;
                }
            }
            return res;
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    ActualizarPass(txtPass.Text);
                    MessageBox.Show("Contraseña actualizada con éxito.", "Admin CSY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.Cerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
