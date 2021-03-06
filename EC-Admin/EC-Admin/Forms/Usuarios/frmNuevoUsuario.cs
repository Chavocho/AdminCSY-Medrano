﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace EC_Admin.Forms
{
    public partial class frmNuevoUsuario : Form
    {
        Privilegios p = new Privilegios();

        public Privilegios P
        {
            get { return p; }
            set { p = value; }
        }

        frmPrimerUso frm = null;
        Camara c;
        private byte[] huella = null;

        public byte[] Huella
        {
            get { return huella ; }
            set { huella = value; }
        }
        
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        public frmNuevoUsuario(frmPrimerUso frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        async private void InsertarUsuario()
        {
            try
            {
                Usuario u = new Usuario();
                if (Config.idSucursal > 0)
                    u.IDSucusal = Config.idSucursal;
                else
                    u.IDSucusal = 1;
                u.UserName = txtUsuario.Text;
                u.Contraseña = txtPass.Text;
                u.Nombre = txtNombre.Text;
                u.Apellidos = txtApellidos.Text;
                u.Correo = txtCorreo.Text;
                u.Imagen = pcbImagen.Image;
                u.Huella = huella;
                u.InsertarUsuario();
                p.IDUsuario = u.ID;
                await p.InsertarEditar();
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
            if (txtUsuario.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtUsuario);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtUsuario);
            }
            if (txtPass.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtPass);
                res = false;
            }
            else
            {
                if (txtPass.Text != txtRepPass.Text)
                {
                    FuncionesGenerales.ColoresError(txtPass);
                    FuncionesGenerales.ColoresError(txtRepPass);
                    res = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtPass);
                    FuncionesGenerales.ColoresBien(txtRepPass);
                }
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtNombre);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(txtNombre);
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtApellidos);
                res = false;
            }
            else
	        {
                FuncionesGenerales.ColoresBien(txtApellidos);
	        }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no es valido. Verifique que este escrito correctamente.", "Admin CSY");
                    FuncionesGenerales.ColoresError(txtCorreo);
                    res = false;
                }
                else
                {
                    FuncionesGenerales.ColoresBien(txtCorreo);
                }
            }
            if (lblInfo.Visible)
            {
                res = false;
            }
            return res;
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            if (c.FuenteDeVideo != null)
            {
                c.TerminarFuenteDeVideo();
                pcbImagen.Image = null;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (*.jpeg, *.jpg) | *.jpeg; *.jpg;";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Multiselect = false;
            DialogResult r = ofd.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                pcbImagen.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pcbImagen.Image = null;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    if (frm == null)
                    {
                        InsertarUsuario();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el usuario con éxito!", "Admin CSY");
                        this.Close();
                    }
                    else
                    {
                        InsertarUsuario();
                        frm.Siguiente();
                        this.Close();
                    }
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
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Los campos en rojo son obligatorios", "Admin CSY");
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

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            c = new Camara(ref pcbImagen, ref cboCamaras);
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            if (c.FuenteDeVideo == null)
            {
                if (c.ExisteCamara)
                {
                    c.IniciarCamara(cboCamaras.SelectedIndex);
                    cboCamaras.Enabled = false;
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "No hay ninguna cámara seleccionada", "Admin CSY");
                }
            }
            else
            {
                c.TerminarFuenteDeVideo();
                FuncionesGenerales.EfectoFoto(ref pcbImagen);
                cboCamaras.Enabled = true;
            }
        }

        private void frmNuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (c.FuenteDeVideo != null)
            {
                c.TerminarFuenteDeVideo();
            }
        }

        private void btnPrivilegios_Click(object sender, EventArgs e)
        {
            if (Privilegios._AdministrarPermisos)
            {
                (new frmPrivilegios(this)).ShowDialog(this);
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }
    }
}
