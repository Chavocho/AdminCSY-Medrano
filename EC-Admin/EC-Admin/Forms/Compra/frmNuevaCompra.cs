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
    public partial class frmNuevaCompra : Form
    {
        int id;
        decimal subtotal = 0M, impuesto = 0M, descuento = 0M, total = 0M, cantTot = 0M;

        Venta v;
        private int idProveedor;
        private int idComprador = -1;
        public frmNuevaCompra()
        {
            InitializeComponent();
        }

        #region Compra

        private void NuevaCompra()
        {
        }

        #endregion

        #region Productos

        /// <summary>
        /// Método que agrega un producto a la venta
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="costo">Costo del producto</param>
        /// <param name="cant">Cantidad del producto</param>
        /// <param name="desc">Descuento aplicado al producto</param>
        public void AgregarProducto(int id, string codProd, string nombre, decimal costo, decimal cant, decimal desc, Unidades u)
        {
            if (!VerificarProducto(id, cant))
            {
                dgvProductos.Rows.Add(new object[] { id, codProd, nombre, costo, cant, desc, u });
                if (dgvProductos.RowCount == 1)
                {
                    dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                }
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
                        QuitarProducto(dr);
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

        private void QuitarProducto()
        {
            if (dgvProductos.CurrentRow != null)
            {
                int ind = dgvProductos.CurrentRow.Index;
                dgvProductos.Rows.Remove(dgvProductos.CurrentRow);
            }
        }

        private void QuitarProducto(DataGridViewRow dr)
        {
            int ind = dr.Index;
            dgvProductos.Rows.Remove(dr);
        }

        private void BusquedaProducto(string codProd)
        {
            try
            {
                string sql = "SELECT id, nombre, codigo, costo, unidad FROM producto WHERE codigo='" + codProd + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    AgregarProducto((int)dr["id"], dr["codigo"].ToString(), dr["nombre"].ToString(), (decimal)dr["costo"], 1M, 0M, (Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString()));
                    break;
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto.", "EC-Admin", ex);
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

        #endregion

        #region Proveedor

        public void AsignarProveedor(int id, string nombre)
        {
            this.idProveedor = id;
            this.lblProveedor.Text = nombre;

        }

        #endregion

        #region Comprador

        public void AsignarComprador(int id, string nombre)
        {
            this.idComprador = id;
            this.lblComprador.Text = nombre;
        }

        #endregion

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                id = (int)dgvProductos[0, e.RowIndex].Value;
                dgvProductos.Rows[e.RowIndex].Selected = true;
            }
            else
                id = 0;
            txtBusqueda.Select();
        }

        private void dgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularTotales();
            txtBusqueda.Select();
        }

        private void dgvProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotales();
            txtBusqueda.Select();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            (new frmCompraProveedor(this)).ShowDialog(this);
            txtBusqueda.Select();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            (new frmCompraProducto(this)).ShowDialog(this);
            txtBusqueda.Select();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Los datos ingresados son correctos?", "EC-Admin") == System.Windows.Forms.DialogResult.Yes)
            {
                NuevaCompra();
                FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha registrado la compra correctamente!", "EC-Admin");
                this.Close();
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BusquedaProducto(txtBusqueda.Text);
                txtBusqueda.Text = "";
                txtBusqueda.Select();
            }
        }

        private void frmNuevaCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvProductos.CurrentRow != null && btnProductos.Visible && btnProductos.Enabled)
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
                        QuitarProducto();
                    }
                    return;
                }
            }
            if (e.KeyCode == Keys.F1)
            {
                btnVendedor.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnProveedor.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnProductos.PerformClick();
            }
            else if (e.KeyCode == Keys.F12)
            {
                btnCobrar.PerformClick();
            }
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            if (idComprador <= 0)
            {
                (new frmVendedor(this)).ShowDialog(this);
            }
            else
            {
                (new frmVendedor(this, idComprador, lblComprador.Text)).ShowDialog(this);
            }
            txtBusqueda.Select();
        }
    }
}
