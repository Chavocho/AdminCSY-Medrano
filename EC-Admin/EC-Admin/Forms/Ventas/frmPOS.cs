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
            }
        }

        /// <summary>
        /// Método que verifica la existencia del producto en la venta, en caso de estar registrado, suma la cantidad
        /// dada al producto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cant"></param>
        private bool VerificarProducto(int id, decimal cant)
        {
            bool existe = false;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                if (dr.Cells[0].Value.ToString() == id.ToString())
                {
                    dr.Cells[4].Value = ((decimal)dr.Cells[4].Value + cant);
                    existe = true;
                }
            }
            return existe;
        }

        public void ModificarProducto(decimal precio, decimal cant, decimal desc)
        {
            dgvProductos[3, dgvProductos.CurrentRow.Index].Value = precio;
            dgvProductos[4, dgvProductos.CurrentRow.Index].Value = cant;
            dgvProductos[5, dgvProductos.CurrentRow.Index].Value = desc;
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
        }

        /// <summary>
        /// Control que cambia la propiedad Enable a true en determinados controles del formulario cuando se inicia una venta
        /// </summary>
        private void ControlesHabilitados()
        {
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            NuevaVenta();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            (new frmVentaProducto(this)).ShowDialog(this);
        }
    }
}
