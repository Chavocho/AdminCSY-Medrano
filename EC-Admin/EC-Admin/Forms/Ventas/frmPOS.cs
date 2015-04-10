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
    public partial class frmPOS : Form
    {
        #region Instancia
        private static frmPOS frmInstancia;
        public static frmPOS Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmPOS();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmPOS();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        delegate void ImagenProducto(Image img);

        int id;
        decimal subtotal = 0M, impuesto = 0M, descuento = 0M, total = 0M, cantTot = 0M;

        Venta v;
        private int idCliente;
        private int idVendedor;

        public int IDCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public int IDVendedor
        {
            get { return idVendedor; }
            set { idVendedor = value; }
        }

        /// <summary>
        /// Inicializa la instancia de la clase frmPOS
        /// </summary>
        public frmPOS()
        {
            InitializeComponent();
            v = new Venta();
        }

        private void VerificarVisible()
        {
            if (!Instancia.Visible)
                Instancia.Show();
            else
                Instancia.Select();
        }

        /// <summary>
        /// Inicia una nueva venta, y verifica si el formulario es visible, en caso de no serlo, lo muestra primero
        /// y después inicia la nueva venta
        /// </summary>
        public void NuevaVenta()
        {
            VerificarVisible();
            v.NuevaVenta();
            ControlesVisibles();
            lblFolio.Text = v.IDVenta.ToString();
            lblSubtotal.Text = lblImpuesto.Text = lblDescuento.Text = lblTotal.Text = "$0.00";
            lblCantDif.Text = lblCantTot.Text = "0";
        }

        /// <summary>
        /// Recupera una venta que no haya sido completada antes
        /// </summary>
        /// <param name="id">ID de la venta</param>
        public void RecuperarVenta(int id)
        {
            v.IDVenta = id;
            v.RecuperarVenta();
        }

        /// <summary>
        /// Método que agrega un producto a la venta
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="cant">Cantidad del producto</param>
        /// <param name="desc">Descuento aplicado al producto</param>
        public void AgregarProducto(int id, string codProd, string nombre, decimal precio, decimal cant, decimal desc)
        {
            if (!VerificarProducto(id, cant))
            {
                dgvProductos.Rows.Add(new object[] { id, codProd, nombre, precio, cant, desc });
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, dgvProductos.RowCount - 1));
                dgvProductos_CellClick(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                CalcularTotales();
            }
        }

        /// <summary>
        /// Método que verifica la existencia del producto en la venta, en caso de estar registrado, suma la cantidad
        /// dada al producto
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <param name="cant">Cantidad a añadir al producto</param>
        private bool VerificarProducto(int id, decimal cant)
        {
            bool existe = false;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                if (dr.Cells[0].Value.ToString() == id.ToString())
                {
                    dr.Cells[4].Value = ((decimal)dr.Cells[4].Value + cant);
                    existe = true;
                    if (cant < 0 && (decimal)dr.Cells[4].Value <= 0)
                        QuitarProducto(id);
                    dgvProductos_CellClick(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                    CalcularTotales();
                    break;
                }
            }
            return existe;
        }

        public void ModificarProducto(decimal cant, decimal desc)
        {
            dgvProductos[4, dgvProductos.CurrentRow.Index].Value = cant;
            dgvProductos[5, dgvProductos.CurrentRow.Index].Value = desc;
            CalcularTotales();
        }

        private void QuitarProducto(int id)
        {
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                if (dr.Cells[0].Value.ToString() == id.ToString())
                {
                    dgvProductos.Rows.Remove(dr);
                    dgvProductos_CellClick(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                    CalcularTotales();
                    return;
                }
            }
        }

        private void CalcularTotales()
        {
            subtotal = 0M;
            impuesto = 0M;
            descuento = 0M;
            total = 0M;
            cantTot = 0M;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                subtotal += ((decimal)dr.Cells[3].Value * (decimal)dr.Cells[4].Value);
                cantTot += (decimal)dr.Cells[4].Value;
                descuento += (decimal)dr.Cells[5].Value;
            }
            impuesto = subtotal * Config.iva;
            total = subtotal + impuesto - descuento;

            lblSubtotal.Text = subtotal.ToString("C2");
            lblImpuesto.Text = impuesto.ToString("C2");
            lblDescuento.Text = descuento.ToString("C2");
            lblTotal.Text = total.ToString("C2");
            lblCantDif.Text = dgvProductos.RowCount.ToString();
            lblCantTot.Text = cantTot.ToString();
        }

        private void Imagen(Image img)
        {
            pcbProducto.Image = img;
        }

        public void Cobrar()
        {
        }

        private void Guardar()
        {
        }

        /// <summary>
        /// Método que hace visibles los controles que al abrir el formulario tienen su propiedad Visible en false
        /// </summary>
        private void ControlesVisibles()
        {
            dgvProductos.Enabled = true;
            lblECliente.Visible = true;
            lblCliente.Visible = true;
            lblEFolio.Visible = true;
            lblFolio.Visible = true;
            lblEVendedor.Visible = true;
            lblVendedor.Visible = true;
            btnClientes.Visible = true;
            btnProductos.Visible = true;
            btnCobrar.Visible = true;
            btnGuardar.Visible = true;
            btnVendedor.Visible = true;
            txtBusqueda.Enabled = true;
            grbTotales.Visible = true;
        }

        /// <summary>
        /// Control que cambia la propiedad Enable a false en determinados controles del formulario cuando se termina una venta
        /// </summary>
        private void ControlesInhabilitados()
        {
            dgvProductos.Enabled = false;
            lblECliente.Enabled = false;
            lblCliente.Enabled = false;
            lblEFolio.Enabled = false;
            lblFolio.Enabled = false;
            lblEVendedor.Enabled = false;
            lblVendedor.Enabled = false;
            btnClientes.Enabled = false;
            btnProductos.Enabled = false;
            btnCobrar.Enabled = false;
            btnGuardar.Enabled = false;
            btnVendedor.Enabled = false;
            txtBusqueda.Enabled = false;
            grbTotales.Enabled = false;
        }

        /// <summary>
        /// Control que cambia la propiedad Enable a true en determinados controles del formulario cuando se inicia una venta
        /// </summary>
        private void ControlesHabilitados()
        {
            dgvProductos.Enabled = true;
            lblECliente.Enabled = true;
            lblCliente.Enabled = true;
            lblEFolio.Enabled = true;
            lblFolio.Enabled = true;
            lblEVendedor.Enabled = true;
            lblVendedor.Enabled = true;
            btnClientes.Enabled = true;
            btnProductos.Enabled = true;
            btnCobrar.Enabled = true;
            btnGuardar.Enabled = true;
            btnVendedor.Enabled = true;
            txtBusqueda.Enabled = true;
            grbTotales.Enabled = true;
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            NuevaVenta();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            (new frmVentaProducto(this)).ShowDialog(this);
        }

        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                (new frmDatosVentaProducto(this, dgvProductos[2, dgvProductos.CurrentRow.Index].Value.ToString(), (decimal)dgvProductos[4, dgvProductos.CurrentRow.Index].Value, (decimal)dgvProductos[5, dgvProductos.CurrentRow.Index].Value)).ShowDialog(this);
        }

        private void frmPOS_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                if (e.Control)
                {
                    if (e.KeyCode == Keys.Oemplus)
                    {
                        VerificarProducto(id, 1);
                    }
                    else if (e.KeyCode == Keys.OemMinus)
                    {
                        VerificarProducto(id, -1);
                    }
                    else if (e.KeyCode == Keys.Delete)
                    {
                        QuitarProducto(id);
                    }
                }
            }
        }

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                id = (int)dgvProductos[0, e.RowIndex].Value;
            }
            else
                id = 0;
        }

        private void bgwImagen_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pcbProducto.InvokeRequired)
            {
                ImagenProducto i = new ImagenProducto(Imagen);
                this.Invoke(i, Producto.ImagenProducto(id));
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                if (!bgwImagen.IsBusy)
                    bgwImagen.RunWorkerAsync();
        }
    }
}
