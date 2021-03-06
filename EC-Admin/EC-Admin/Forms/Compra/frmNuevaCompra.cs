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
    public partial class frmNuevaCompra : Form
    {
        int id;
        decimal subtotal = 0M, impuesto = 0M, descuento = 0M, total = 0M;
        int cantTot = 0;
        TipoPago t;

        private int idProveedor;
        private int idComprador = -1;

        #region Info Pago

        private int idCuentaOrigen;
        private int idCuentaDestino;

        public int IDCuentaOrigen
        {
            get { return idCuentaOrigen; }
            set { idCuentaOrigen = value; }
        }

        public int IDCuentaDestino
        {
            get { return idCuentaDestino; }
            set { idCuentaDestino = value; }
        }

        private string numCheque;

        public string NumCheque
        {
            get { return numCheque; }
            set { numCheque = value; }
        }

        private decimal comision;

        public decimal Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        private string folioTerminal;

        public string FolioTerminal
        {
            get { return folioTerminal; }
            set { folioTerminal = value; }
        }

        private string referencia;

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }

        private string conceptoPago;

        public string ConceptoPago
        {
            get { return conceptoPago; }
            set { conceptoPago = value; }
        }

        private string beneficiario;

        public string Beneficiario
        {
            get { return beneficiario; }
            set { beneficiario = value; }
        }

        private bool configurado;

        public bool Configurado
        {
            get { return configurado; }
            set { configurado = value; }
        }

        

        #endregion

        public frmNuevaCompra()
        {
            InitializeComponent();
            configurado = false;
            cboTipoPago.SelectedIndex = 0;
        }

        #region Compras

        private void NuevaCompra()
        {
            Compra c = new Compra();
            c.IDSucursal = Config.idSucursal;
            c.IDProveedor = idProveedor;
            c.IDComprador = idComprador;
            c.IDCuentaOrigen = idCuentaOrigen;
            c.IDCuentaDestino = idCuentaDestino;
            c.Subtotal = subtotal;
            c.Impuesto = impuesto;
            c.Descuento = descuento;
            c.Total = total;
            c.Tipo = t;
            c.NumCheque = numCheque;
            c.Beneficiario = beneficiario;
            c.FolioTerminal = folioTerminal;
            if (t == TipoPago.Crédito || t == TipoPago.Débito)
                c.Comision = (total * comision) / 100;
            else
                c.Comision = comision;
            c.Referencia = referencia;
            c.ConceptoPago = conceptoPago;
            c.Remision = rbtnRemision.Checked;
            c.Factura = rbtnFactura.Checked;
            c.FolioRemision = txtRemision.Text;
            c.FolioFactura = txtFactura.Text;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            { 
                c.IDProductos.Add((int)dr.Cells[0].Value);
                c.Cantidad.Add((int)dr.Cells[4].Value);
                c.Unidad.Add((Unidades)Enum.Parse(typeof(Unidades), dr.Cells[6].Value.ToString()));
                c.Precio.Add((decimal)dr.Cells[3].Value);
                c.DescuentoProducto.Add((decimal)dr.Cells[5].Value);
            }
            c.Insertar();
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
        public void AgregarProducto(int id, string codProd, string nombre, decimal costo, int cant, decimal desc, Unidades u)
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
        private bool VerificarProducto(int id, int cant)
        {
            bool existe = false;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                if (dr.Cells[0].Value.ToString() == id.ToString())
                {
                    dr.Cells[4].Value = ((int)dr.Cells[4].Value + cant);
                    existe = true;
                    if (cant < 0 && (int)dr.Cells[4].Value <= 0)
                        QuitarProducto(dr);
                    CalcularTotales();
                    break;
                }
            }
            return existe;
        }

        public void ModificarProducto(int cant, decimal desc)
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

        private void BusquedaProducto(string codProd, int cant)
        {
            try
            {
                string sql = "SELECT p.id, p.nombre, p.codigo, i.precio, p.unidad FROM producto AS p INNER JOIN inventario AS i ON (p.id=i.id_producto) WHERE codigo='" + codProd + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    AgregarProducto((int)dr["id"], dr["codigo"].ToString(), dr["nombre"].ToString(), (decimal)dr["precio"], cant, 0M, (Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString()));
                    break;
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto.", "Admin CSY", ex);
            }
        }

        private void CalcularTotales()
        {
            subtotal = 0M;
            impuesto = 0M;
            descuento = 0M;
            total = 0M;
            cantTot = 0;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                subtotal += ((decimal)dr.Cells[3].Value * (int)dr.Cells[4].Value);
                cantTot += (int)dr.Cells[4].Value;
                descuento += ((decimal)dr.Cells[5].Value);
            }
            impuesto = subtotal * Config.iva / 100;
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

        private bool VerificarDatos()
        {
            if (idComprador <= 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes seleccionar un comprador", "Admin CSY");
                return false;
            }
            if (idProveedor <= 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes seleccionar un proveedor", "Admin CSY");
                return false;
            }
            if (dgvProductos.RowCount == 0)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar al menos un producto a la compra", "Admin CSY");
                return false;
            }
            if (rbtnRemision.Checked)
            {
                if (!chbFolioRemision.Checked)
                {
                    if (txtRemision.Text.Trim() == "")
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el folio de la remisión", "Admin CSY");
                        return false;
                    }
                }
            }
            if (rbtnFactura.Checked)
            {
                if (txtFactura.Text.Trim() == "")
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el folio de la factura", "Admin CSY");
                    return false;
                }
            }
            return true;
        }

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
            if (VerificarDatos())
            {
                if (configurado)
                {
                    if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Los datos ingresados son correctos?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            NuevaCompra();
                            this.configurado = false;
                            FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha registrado la compra correctamente!", "Admin CSY");
                            this.Close();
                        }
                        catch (MySqlException ex)
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al insertar la compra. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                        }
                        catch (Exception ex)
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al insertar la compra.", "Admin CSY", ex);
                        }
                    }
                }
                else
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No se ha configurado la informacion de pago", "Admin CSY");
            }
           

        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtBusqueda.Text.Trim() != "")
                {
                    string[] datos = txtBusqueda.Text.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
                    if (datos.Length > 1)
                    {
                        try
                        {
                            BusquedaProducto(datos[1].ToString(), int.Parse(datos[0]));
                        }
                        catch (FormatException)
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "Formato de multiplicador no válido", "Admin CSY");
                        }
                        
                    }
                    else
                    {
                        BusquedaProducto(datos[0].ToString(), 1);
                    }
                    txtBusqueda.Text = "";
                }
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
            else if (e.KeyCode == Keys.F11)
            {
                btnPagos.PerformClick();
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

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoPago.SelectedIndex)
            {
                case 0:
                    btnInfoPago.Visible = false;
                    t = TipoPago.Efectivo;
                    configurado = true;
                    break;
                case 1:
                    btnInfoPago.Visible = true;
                    t = TipoPago.Cheque;
                    configurado = false;
                    break;
                case 2:
                    btnInfoPago.Visible = true;
                    t = TipoPago.Crédito;
                    configurado = false;
                    break;
                case 3:
                    btnInfoPago.Visible = true;
                    t = TipoPago.Débito;
                    configurado = false;
                    break;
                case 4:
                    btnInfoPago.Visible = true;
                    t = TipoPago.Transferencia;
                    configurado = false;
                    break;
            }
        }

        private void dgvProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                (new frmDatosVentaProducto(this, dgvProductos[2, dgvProductos.CurrentRow.Index].Value.ToString(), (int)dgvProductos[4, dgvProductos.CurrentRow.Index].Value, (decimal)dgvProductos[5, dgvProductos.CurrentRow.Index].Value)).ShowDialog(this);
        }

        private void rbtnRemision_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRemision.Checked)
            {
                chbFolioRemision.Enabled = true;
                chbFolioRemision.Checked = false;
                txtFactura.Enabled = false;
                txtFactura.Text = "";
                txtRemision.Enabled = true;
            }
        }

        private void rbtnFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFactura.Checked)
            {
                chbFolioRemision.Enabled = false;
                chbFolioRemision.Checked = false;
                txtRemision.Enabled = false;
                txtRemision.Text = "";
                txtFactura.Enabled = true;
            }
        }

        private void chbFolioRemision_CheckedChanged(object sender, EventArgs e)
        {
            txtRemision.Enabled = !chbFolioRemision.Checked;
            if (rbtnRemision.Checked && chbFolioRemision.Checked)
                rbtnRemision.Checked = false;
            else
                rbtnRemision.Checked = true;
            txtRemision.Text = "";
        }

        private void btnInfoPago_Click(object sender, EventArgs e)
        {
            if (Cuenta.Cantidad <= 0)
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No hay cuentas registradas", "Admin CSY");
            else if (Cuenta.CantidadProv <= 0 && t == TipoPago.Transferencia)
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No hay cuentas de proveedores registradas", "Admin CSY");
            else if (Cuenta.CantidadSuc <= 0 && t != TipoPago.Efectivo)
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No hay cuentas de sucursales registradas", "Admin CSY");
            else
                (new frmInfoPago(cboTipoPago.SelectedIndex, this)).ShowDialog();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
