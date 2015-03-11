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
    public partial class frmNuevoUsuario : Form
    {
        NivelesUsuario n;
        bool quitoImagen = false;
        private byte[] huella = null;

        public byte[] Huella
        {
            get { return huella ; }
            set { huella = value; }
        }
        
        public frmNuevoUsuario(string[] niveles)
        {
            InitializeComponent();
            cboNivel.Items.AddRange(niveles);
            cboNivel.SelectedIndex = 0;
        }

        private void InsertarUsuario()
        {
            try
            {
                Usuario u = new Usuario();
                u.UserName = txtUsuario.Text;
                u.Contraseña = txtPass.Text;
                u.NivelUsuario = n;
                u.Nombre = txtNombre.Text;
                u.Apellidos = txtApellidos.Text;
                u.Correo = txtCorreo.Text;
                if (!quitoImagen)
                    u.Imagen = pcbImagen.Image;
                else
                    u.Imagen = null;
                u.Huella = huella;
                u.InsertarUsuario();
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
            if (txtUsuario.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo usuario es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtPass.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo contraseña es obligatorio.", "EC-Admin");
                return false;
            }
            else
            {
                if (txtPass.Text != txtRepPass.Text)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Las contraseñas no coinciden. Éstas deben coincidir para poder continuar.", "EC-Admin");
                    return false;
                }
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio", "EC-Admin");
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo apellidos es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no es valido. Verifique que este escrito correctamente.", "EC-Admin");
                    return false;
                }
            }
            if (lblInfo.Visible)
            {
                return false;
            }
            return true;
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (*.jpeg, *.jpg) | *.jpeg; *.jpg;";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Multiselect = false;
            DialogResult r = ofd.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                pcbImagen.Image = new Bitmap(ofd.FileName);
                quitoImagen = false;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pcbImagen.Image = null;
            quitoImagen = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    InsertarUsuario();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el usuario con éxito!", "EC-Admin");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboNivel.Items[cboNivel.SelectedIndex].ToString())
            {
                case "Administrador":
                    n = NivelesUsuario.Administrador;
                    break;
                case "Encargado":
                    n = NivelesUsuario.Encargado;
                    break;
                case "Desconocido":
                    n = NivelesUsuario.Desconocido;
                    break;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.ExisteUsuario(txtUsuario.Text))
            {
                lblInfo.Visible = true;
                txtUsuario.BackColor = Colores.Error;
                txtUsuario.ForeColor = Colores.Claro;
            }
            else
            {
                lblInfo.Visible = false;
                txtUsuario.BackColor = Colores.Claro;
                txtUsuario.ForeColor = Colores.Obscuro;
            }
        }
    }
}
