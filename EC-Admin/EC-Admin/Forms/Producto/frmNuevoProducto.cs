﻿using MySql.Data.MySqlClient;
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
        Producto p;

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
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los proveedores. No se ha podido conectar con la base de datos. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar los proveedores. La ventana se cerrará.", "Admin CSY", ex);
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
                    idCat.Add((int)dr["id"]);
                    cboCategoria.Items.Add(dr["nombre"]);
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar las categorías. No se ha podido conectar con la base de datos. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cargar las categorías. La ventana se cerrará.", "Admin CSY", ex);
                this.Close();
            }
        }

        private void Insertar()
        {
            try
            {
                p = new Producto();
                decimal costo, precio, cant, precioMedioMayoreo, precioMayoreo, cantMedioMayoreo, cantMayoreo;
                decimal.TryParse(txtCosto.Text, out costo);
                decimal.TryParse(txtPrecio.Text, out precio);
                decimal.TryParse(txtCant.Text, out cant);
                decimal.TryParse(txtPrecioMedioMayoreo.Text, out precioMedioMayoreo);
                decimal.TryParse(txtPrecioMayoreo.Text, out precioMayoreo);
                decimal.TryParse(txtCantMedioMayoreo.Text, out cantMedioMayoreo);
                decimal.TryParse(txtCantMayoreo.Text, out cantMayoreo);
                p.IDProveedor = idPro[cboProveedor.SelectedIndex];
                p.IDCategoria = idCat[cboCategoria.SelectedIndex];
                p.Nombre = txtNombre.Text;
                p.Marca = txtMarca.Text;
                p.Codigo = txtCodigo.Text;
                p.Descripcion01 = txtDescripcion01.Text;
                p.Costo = costo;
                p.Precio = precio;
                p.Cantidad = cant;
                p.PrecioMedioMayoreo = precioMedioMayoreo;
                p.PrecioMayoreo = precioMayoreo;
                p.CantidadMedioMayoreo = cantMedioMayoreo;
                p.CantidadMayoreo = cantMayoreo;
                p.Unidad = u;
                p.Imagen01 = pcbImagen01.Image;
                p.Imagen02 = pcbImagen02.Image;
                p.Imagen03 = pcbImagen03.Image;
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
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo proveedor es obligatorio", "Admin CSY");
                return false;
            }
            if (cboCategoria.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo categoría es obligatorio", "Admin CSY");
                return false;
            }
            if (txtNombre.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo nombre es obligatorio", "Admin CSY");
                return false;
            }
            if (txtMarca.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo marca es obligatorio", "Admin CSY");
                return false;
            }
            if (txtCodigo.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo código es obligatorio", "Admin CSY");
                return false;
            }
            if (txtCosto.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo costo es obligatorio", "Admin CSY");
                return false;
            }
            if (txtPrecio.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo precio es obligatorio", "Admin CSY");
                return false;
            }
            if (txtCant.Text.Trim() == "")
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo cantidad es obligatorio", "Admin CSY");
                return false;
            }
            if (txtCantMedioMayoreo.Text.Trim() != "")
            {
                if (txtPrecioMedioMayoreo.Text.Trim() == "")
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo precio de medio mayoreo debe ser ingresado", "Admin CSY");
                    return false;
                }
            }
            else if (txtPrecioMedioMayoreo.Text.Trim() != "")
            {
                if (txtCantMedioMayoreo.Text.Trim() == "")
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo cantidad de medio mayoreo debe ser ingresado", "Admin CSY");
                    return false;
                }
            }
            if (txtCantMayoreo.Text.Trim() != "")
            {
                if (txtPrecioMayoreo.Text.Trim() == "")
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo precio de mayoreo debe ser ingresado", "Admin CSY");
                    return false;
                }
            }
            else if (txtPrecioMayoreo.Text.Trim() != "")
            {
                if (txtCantMayoreo.Text.Trim() == "")
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo cantidad de mayoreo debe ser ingresado", "Admin CSY");
                    return false;
                }
            }
            if (cboUnidad.SelectedIndex < 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El campo unidad es obligatorio", "Admin CSY");
                return false;
            }
            return true;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void txtNumerosEnteros_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void pcbImagen_Click(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;
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
                    pcb.Image = Bitmap.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al obtener la imagen.", "Admin CSY", ex);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string texto = btn.Text.Substring(btn.Text.Length - 2, 2);
            if (texto == "01")
            {
                pcbImagen01.Image = null;
            }
            else if (texto == "02")
            {
                pcbImagen02.Image = null;
            }
            else if (texto == "03")
            {
                pcbImagen03.Image = null;
            }
        }

        private void cboUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboUnidad.SelectedIndex)
            {
                case 0:
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
                    InsertarPaquete();
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado el producto correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el producto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el producto.", "Admin CSY", ex);
                }
            }
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarCategorias();
        }

        #region Paquetes
        bool edito;

        private void InsertarDataGrid(string precio, string cant)
        {
            dgvPaquetes.Rows.Add(new object[] { 0, decimal.Parse(precio), int.Parse(cant), false, false });
        }

        private void EditarDataGrid(int rowIndex, string precio, string cant)
        {
            dgvPaquetes[1, rowIndex].Value = decimal.Parse(precio);
            dgvPaquetes[2, rowIndex].Value = int.Parse(cant);
            dgvPaquetes[4, rowIndex].Value = true;
        }

        private void EliminarDataGrid(int rowIndex)
        {
            dgvPaquetes.Rows.RemoveAt(rowIndex);
        }

        private void InsertarPaquete()
        {
            try
            {
                foreach (DataGridViewRow dr in dgvPaquetes.Rows)
                {
                    Paquete pa = new Paquete();
                    pa.IDProducto = p.ID;
                    pa.Precio = (decimal)dr.Cells[1].Value;
                    pa.CantidadPaquetes = (int)dr.Cells[2].Value;
                    pa.Insertar();
                }
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

        private bool VerificarDatosPaquete()
        {
            bool res = true;
            if (txtPrecioPaquete.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(ref txtPrecioPaquete);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(ref txtPrecioPaquete);
            }
            if (txtCantPaquete.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(ref txtCantPaquete);
                res = false;
            }
            else
            {
                FuncionesGenerales.ColoresBien(ref txtCantPaquete);
            }
            return res;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            edito = false;
            btnAceptarPaquete.Text = "Crear";
            txtCantPaquete.Text = "";
            txtPrecioPaquete.Text = "";
            pnlPaquete.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.CurrentRow != null)
            {
                edito = true;
                btnAceptarPaquete.Text = "Modificar";
                txtCantPaquete.Text = "";
                txtPrecioPaquete.Text = "";
                pnlPaquete.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.CurrentRow != null)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente desea eliminar este paquete?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                {
                    EliminarDataGrid(dgvPaquetes.CurrentRow.Index);
                }
            }
        }

        private void btnAceptarPaquete_Click(object sender, EventArgs e)
        {
            if (VerificarDatosPaquete())
            {
                if (!edito)
                {
                    InsertarDataGrid(txtPrecioPaquete.Text, txtCantPaquete.Text);
                    dgvPaquetes.Rows[dgvPaquetes.RowCount - 1].Selected = true;
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha añadido el paquete con éxito!", "Admin CSY");
                }
                else
                {
                    EditarDataGrid(dgvPaquetes.CurrentRow.Index, txtPrecioPaquete.Text, txtCantPaquete.Text);
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha modificado el paquete con éxito!", "Admin CSY");
                }
                pnlPaquete.Visible = false;
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "¡Los campos en rojo son obligatorios!", "Admin CSY");
            }
        }

        #endregion
    }
}
