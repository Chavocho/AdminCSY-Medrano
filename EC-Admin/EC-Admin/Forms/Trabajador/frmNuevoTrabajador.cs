using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class frmNuevoTrabajador : Form
    {
        private byte[] huella;
        private bool existeCamara = false;
        private FilterInfoCollection dispositivoDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;
        List<int> idSucursal = new List<int>();
        List<int> idPuesto = new List<int>();

        public frmNuevoTrabajador()
        {
            InitializeComponent();
        }

        #region Cámara
        public void CargarCamaras(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
                cboCamaras.Items.Add(Dispositivos[i].Name.ToString());
            cboCamaras.Text = cboCamaras.Items[0].ToString();
        }

        public void BuscarCamaras()
        {
            dispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivoDeVideo.Count == 0)
            {
                existeCamara = false;
            }
            else
            {
                existeCamara = true;
                CargarCamaras(dispositivoDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }
        }

        public void Mostrar_Imagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pcbImagen.Image = Imagen;
        }
        #endregion

        private void CargarSucursales()
        {
            try
            {
                string sql = "SELECT id, nombre FROM sucursal WHERE eliminado=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idSucursal.Add((int)dr["id"]);
                    cboSucursal.Items.Add(dr["nombre"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CargarPuestos()
        {
            try
            {
                string sql = "SELECT id, nombre, departamento FROM puesto";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idPuesto.Add((int)dr["id"]);
                    cboPuesto.Items.Add(dr["nombre"].ToString() + "/" + dr["departamento"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Insertar()
        {
            try
            {
                Trabajador t = new Trabajador();
                t.IDSucursal = idSucursal[cboSucursal.SelectedIndex];
                t.Puesto = idPuesto[cboPuesto.SelectedIndex];
                t.Nomina = txtNumNomina.Text;
                t.Nombre = txtNombre.Text;
                t.Apellidos = txtApellidos.Text;
                t.Telefono = txtTelefono.Text;
                t.Celular = txtCelular.Text;
                t.Correo = txtCorreo.Text;
                t.Direccion = txtDireccion.Text;
                t.Ciudad = txtCiudad.Text;
                t.Estado = txtEstado.Text;
                t.CP = int.Parse(txtCP.Text);
                t.FechaInicio = dtpFechaInicio.Value;
                t.Imagen = pcbImagen.Image;
                t.Huella = huella;
                t.Insertar();
            }
            catch (MySqlException ex)
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
            if (cboSucursal.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Se debe seleccionar una sucursal asociada con éste trabajador.", "EC-Admin");
                return false;
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtApellidos.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo apellidos es obligatorio.", "EC-Admin");
                return false;
            }
            if (cboPuesto.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Se debe seleccionar un puesto asociado con éste trabajador.", "EC-Admin");
                return false;
            }
            if (txtNumNomina.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo número de nómina es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtTelefono.Text.Trim() == "" && txtCelular.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un número de teléfono.", "EC-Admin");
                return false;
            }
            if (txtCorreo.Text.Trim() != "")
            {
                if (!FuncionesGenerales.EsCorreoValido(txtCorreo.Text))
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El correo ingresado no se reconoce cómo uno válido.", "EC-Admin");
                    return false;
                }
            }
            if (txtDireccion.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo dirección es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtCiudad.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo ciudad es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtEstado.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo estado es obligatorio.", "EC-Admin");
                return false;
            }
            if (txtCP.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo código postal es obligatorio.", "EC-Admin");
                return false;
            }
            return true;
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void frmNuevoTrabajador_Load(object sender, EventArgs e)
        {
            BuscarCamaras();
            CargarPuestos();
            CargarSucursales();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el trabajador correctamente!", "EC-Admin");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el trabajador. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error genérico al crear el trabajador.", "EC-Admin", ex);
                }
            }
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            if (fuenteDeVideo == null)
            {
                if (existeCamara)
                {
                    fuenteDeVideo = new VideoCaptureDevice(dispositivoDeVideo[cboCamaras.SelectedIndex].MonikerString);
                    fuenteDeVideo.NewFrame += new NewFrameEventHandler(Mostrar_Imagen);
                    fuenteDeVideo.Start();
                    cboCamaras.Enabled = false;
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "No hay ninguna cámara seleccionada", "EC-Admin");
                }
            }
            else
            {
                if (fuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    FuncionesGenerales.EfectoFoto(ref pcbImagen);
                }
            }
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            if (fuenteDeVideo != null)
            {
                TerminarFuenteDeVideo();
                pcbImagen.Image = null;
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (*.jpg; *.jpeg) | *.jpg; *.jpeg";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            DialogResult r = ofd.ShowDialog(this);
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                pcbImagen.Image = Bitmap.FromFile(ofd.FileName);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pcbImagen.Image = null;
        }
    }
}
