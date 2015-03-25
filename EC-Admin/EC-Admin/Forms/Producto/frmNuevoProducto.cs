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
    public partial class frmNuevoProducto : Form
    {
        List<int> idPro = new List<int>();
        List<int> idAlm = new List<int>();
        List<int> idCat = new List<int>();
        Unidades u;

        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        private void CargarProveedores()
        {
            try
            {
                string sql = "SELECT id, nombre FROM proveedor";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idPro.Add((int)dr["id"]);
                    cboProveedor.Items.Add(dr["nombre"]);
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los proveedores. No se ha podido conectar con la base de datos. La ventana se cerrará.", "EC-Admin", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los proveedores. La ventana se cerrará.", "EC-Admin", ex);
                this.Close();
            }
        }

        private void CargarAlmacenes()
        {
            try
            {
                string sql = "SELECT id, num_alm FROM almacen";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idPro.Add((int)dr["id"]);
                    cboProveedor.Items.Add(dr["num_alm"]);
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los almacenes. No se ha podido conectar con la base de datos. La ventana se cerrará.", "EC-Admin", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los almacenes. La ventana se cerrará.", "EC-Admin", ex);
                this.Close();
            }
        }

        private void CargarCategorias()
        {
            try
            {
                string sql = "SELECT id, nombre FROM categoria";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idPro.Add((int)dr["id"]);
                    cboProveedor.Items.Add(dr["nombre"]);
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar las categorías. No se ha podido conectar con la base de datos. La ventana se cerrará.", "EC-Admin", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar las categorías. La ventana se cerrará.", "EC-Admin", ex);
                this.Close();
            }
        }

        private void Insertar()
        {
            try
            {
                Producto p = new Producto();
                p.IDProveedor = idPro[cboProveedor.SelectedIndex];
                p.IDAlmacen = idAlm[cboAlmacen.SelectedIndex];
                p.IDCategoria = idCat[cboCategoria.SelectedIndex];
                p.Nombre = txtNombre.Text;
                p.Marca = txtMarca.Text;
                p.Codigo = txtCodigo.Text;
                p.Descripcion01 = txtDescripcion01.Text;
                p.Descripcion02 = txtDescripcion02.Text;
                p.Costo = decimal.Parse(txtCosto.Text);
                p.Precio = decimal.Parse(txtPrecio.Text);
                p.Cantidad = int.Parse(txtCant.Text);
                p.PrecioMedioMayoreo = decimal.Parse(txtPrecioMedioMayoreo.Text);
                p.PrecioMayoreo = decimal.Parse(txtPrecioMayoreo.Text);
                p.CantidadMedioMayoreo = int.Parse(txtCantMedioMayoreo.Text);
                p.CantidadMayoreo = int.Parse(txtCantMayoreo.Text);
                p.Unidad = u;
                p.Imagen = pcbImagen.Image;
                p.Insertar();
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
            if (cboProveedor.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo proveedor es obligatorio", "EC-Admin");
                return false;
            }
            if (cboAlmacen.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo almacen es obligatorio", "EC-Admin");
                return false;
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo categoría es obligatorio", "EC-Admin");
                return false;
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio", "EC-Admin");
                return false;
            }
            if (txtMarca.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo marca es obligatorio", "EC-Admin");
                return false;
            }
            if (txtCodigo.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo código es obligatorio", "EC-Admin");
                return false;
            }
            if (txtDescripcion01.Text.Trim() == "" && txtDescripcion02.Text.Trim() != "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El primer campo de descripción se debe ingresar antes que el segundo", "EC-Admin");
                return false;
            }
            if (txtCosto.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo costo es obligatorio", "EC-Admin");
                return false;
            }
            if (txtPrecio.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo precio es obligatorio", "EC-Admin");
                return false;
            }
            if (txtCant.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo cantidad es obligatorio", "EC-Admin");
                return false;
            }
            if (cboUnidad.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo unidad es obligatorio", "EC-Admin");
                return false;
            }
            return true;
        }

        private void txtPrecios_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void txtCantidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivos de imagen (*.jpg, *.jpeg) | *.jpg; *.jpeg";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                ofd.Multiselect = false;
                ofd.Title = "Seleccione la imagen del producto";
                DialogResult r = ofd.ShowDialog(this);
                if (r == System.Windows.Forms.DialogResult.OK)
                {
                    pcbImagen.Image = Bitmap.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener la imagen.", "EC-Admin", ex);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            pcbImagen.Image = null;
        }

        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboUnidad.SelectedIndex)
            {
                case 0:
                    u = Unidades.Kilogramo;
                    break;
                case 1:
                    u = Unidades.Pieza;
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                try
                {
                    Insertar();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el producto correctamente!", "EC-Admin");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el producto. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el producto.", "EC-Admin", ex);
                }
            }
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarAlmacenes();
            CargarCategorias();
        }
    }
}
