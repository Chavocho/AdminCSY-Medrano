using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EC_Admin.Forms
{
    public partial class frmCobrar : Form
    {
        int id;
        frmPOS frm;
        decimal total, saldo, tmpTotal;
        decimal totalPorcentaje = 0;
        TipoPago t;

        private int idDevolucion = 0;

        public int IDDevolucion
        {
            get { return idDevolucion; }
            set
            {
                saldo = Devoluciones.SaldoDevolucion(value);
                idDevolucion = value;
            }
        }

        public frmCobrar(frmPOS frm, int id, decimal total)
        {
            InitializeComponent();
            this.frm = frm;
            this.id = id;
            this.total = total;
            lblTotal.Text = total.ToString("C2");
            cboTipoPago.SelectedIndex = 0;
            CalcularCambio();
        }

        private void CalcularCambio()
        {
            decimal efectivo, cambio = 0M;
            decimal.TryParse(txtEfectivo.Text, out efectivo);
            cambio = total - efectivo;
            if (cambio > 0)
            {
                lblECambio.Text = "Falta:";
                lblCambio.BackColor = Colores.Error;
                lblCambio.Text = cambio.ToString("C2");
            }
            else
            {
                lblECambio.Text = "Cambio:";
                lblCambio.BackColor = Colores.Exito;
                lblCambio.Text = (cambio * -1).ToString("C2");
            }
        }

        private void QuitarEfectivo()
        {
            lblEEfectivo.Enabled = false;
            txtEfectivo.Enabled = false;
            txtEfectivo.Text = "0.00";
            lblCambio.Text = "$0.00";
            lblCambio.BackColor = Colores.Exito;
            lblECambio.Text = "Cambio:";
        }

        private void CobroConSaldo()
        {
            if (saldo >= total)
            {
                lblSaldo.Text = (saldo - total).ToString("C2");
                cboTipoPago.SelectedIndex = -1;
                cboTipoPago.Enabled = false;
                lblEEfectivo.Enabled = false;
                txtEfectivo.Enabled = false;
                txtEfectivo.Text = "0.00";
                lblCambio.Text = "$0.00";
                lblCambio.BackColor = Colores.Exito;
                lblECambio.Text = "Cambio:";
            }
            else
            {
                cboTipoPago.Enabled = true;
                lblSaldo.Text = "$0.00";
                tmpTotal = total;
                total = total - saldo;
                lblTotal.Text = total.ToString("C2");
                CalcularCambio();
            }
        }

        private void MovimientoCaja()
        {
            try
            {
                Banco b = new Banco();
                Caja c = new Caja();
                c.Descripcion = "VENTA MOSTRADOR";
                b.Descripcion = "VENTA MOSTRADOR";
                if (chbSaldo.Checked)
                {
                    if (cboTipoPago.SelectedIndex == 0)
                    {
                        c.Efectivo = total;
                        b.Voucher = 0M;
                        c.TipoMovimiento = EC_Admin.MovimientoCaja.Entrada;
                        c.IDSucursal = Config.idSucursal;
                        c.RegistrarMovimiento();
                    }
                    else if (cboTipoPago.SelectedIndex == 1 || cboTipoPago.SelectedIndex == 2)
                    {
                        c.Efectivo = 0M;
                        b.Voucher = totalPorcentaje;
                        b.TipoMovimiento = EC_Admin.MovimientoCaja.Entrada;
                        b.IDSucursal = Config.idSucursal;
                        b.RegistrarMovimiento();
                    }
                }
                else
                {
                    if (cboTipoPago.SelectedIndex == 0)
                    {
                        c.Efectivo = total;
                        b.Voucher = 0M;
                        c.TipoMovimiento = EC_Admin.MovimientoCaja.Entrada;
                        c.IDSucursal = Config.idSucursal;
                        c.RegistrarMovimiento();
                    }
                    else if (cboTipoPago.SelectedIndex == 1 || cboTipoPago.SelectedIndex == 2)
                    {
                        c.Efectivo = 0M;
                        b.Voucher = totalPorcentaje;
                        b.TipoMovimiento = EC_Admin.MovimientoCaja.Entrada;
                        b.IDSucursal = Config.idSucursal;
                        b.RegistrarMovimiento();
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ImprimirTicket()
        {
            try
            {
                Ticket t = new Ticket();
                t.TicketVenta(id);
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al imprimir el ticket.", "Admin CSY", ex);
            }
        }

        private void frmCobrar_Load(object sender, EventArgs e)
        {
            txtEfectivo.Select();
            cboTipoPago.SelectedIndex = 0;
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoPago.SelectedIndex)
            {
                case 0:
                    lblEEfectivo.Enabled = true;
                    txtEfectivo.Enabled = true;
                    txtDatos.Visible = lblEDatos.Visible = txtPorcentajeImpuesto.Visible = lblEPorcentajeImpuesto.Visible = lblEFolioTerminal.Visible = txtFolioTerminal.Visible = false;
                    CalcularCambio();
                    t = TipoPago.Efectivo;
                    this.Size = new Size(580, 275);
                    txtEfectivo.Select();
                    break;
                //case 1:
                //    QuitarEfectivo();
                //    lblEDatos.Text = "Núm. de cheque";
                //    txtDatos.Visible = lblEDatos.Visible = true;
                //    break;
                case 1:
                    QuitarEfectivo();
                    lblEDatos.Text = "Núm. de tarjeta";
                    txtDatos.Visible = lblEDatos.Visible = txtPorcentajeImpuesto.Visible = lblEPorcentajeImpuesto.Visible = lblEFolioTerminal.Visible = txtFolioTerminal.Visible = true;
                    txtPorcentajeImpuesto.Text = "0";
                    t = TipoPago.Crédito;
                    this.Size = new Size(580, 318);
                    txtPorcentajeImpuesto_TextChanged(txtPorcentajeImpuesto, new EventArgs());
                    break;
                case 2:
                    QuitarEfectivo();
                    lblEDatos.Text = "Núm. de tarjeta";
                    txtDatos.Visible = lblEDatos.Visible = txtPorcentajeImpuesto.Visible = lblEPorcentajeImpuesto.Visible = lblEFolioTerminal.Visible = txtFolioTerminal.Visible = true;
                    txtPorcentajeImpuesto.Text = "0";
                    t = TipoPago.Débito;
                    this.Size = new Size(580, 318);
                    txtPorcentajeImpuesto_TextChanged(txtPorcentajeImpuesto, new EventArgs());
                    break;
                //case 4:
                //    QuitarEfectivo();
                //    txtDatos.Visible = lblEDatos.Visible = false;
                //    break;
                default:
                    t = TipoPago.Efectivo;
                    break;
            }
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }

        private void txtEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (lblCambio.BackColor == Colores.Exito)
            {
                try
                {
                    switch (cboTipoPago.SelectedIndex)
                    {
                        case 0:
                            frm.GuardarVenta(false, t);
                            break;
                        case 1:
                        case 2:
                            decimal porcentajeImpuesto;
                            decimal.TryParse(txtPorcentajeImpuesto.Text, out porcentajeImpuesto);
                            if (porcentajeImpuesto < 0)
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El porcentaje de impuesto debe ser mayor o igual a 0", "Admin CSY");
                                return;
                            }
                            if (txtDatos.Text.Trim() == "")
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el número de la tarjeta", "Admin CSY");
                                return;
                            }
                            if (txtFolioTerminal.Text == "")
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el folio de la terminal de tarjetas", "Admin CSY");
                                return;
                            }
                            frm.GuardarVenta(false, t, txtDatos.Text, txtFolioTerminal.Text, total * (porcentajeImpuesto / 100));
                            break;
                    }
                    if (chbSaldo.Checked)
                    {
                        if (saldo >= tmpTotal)
                            Devoluciones.CambiarSaldo(idDevolucion, tmpTotal);
                        else
                            Devoluciones.CambiarSaldo(idDevolucion, saldo);
                    }
                    MovimientoCaja();
                    if (FuncionesGenerales.ImprimirTicket(this, "¿Desea imprimir el ticket de ésta venta?"))
                    {
                        ImprimirTicket();
                        ImprimirTicket();
                    }
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha guardado los datos de la venta correctamente!", "Admin CSY");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar los datos de la venta. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar los datos de la venta.", "Admin CSY", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El efectivo debe ser mayor o igual al total", "Admin CSY");
            }
        }

        private void txtPorcentajeImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void txtPorcentajeImpuesto_TextChanged(object sender, EventArgs e)
        {
            if (txtPorcentajeImpuesto.Text != "")
            {
                totalPorcentaje = total + (total * (decimal.Parse(txtPorcentajeImpuesto.Text) / 100));
            }
            else
            {
                totalPorcentaje = total;
            }
            lblTotal.Text = totalPorcentaje.ToString("C2");
        }

        private void txtEfectivo_Enter(object sender, EventArgs e)
        {
            txtEfectivo.SelectAll();
        }

        private void txtEfectivo_Click(object sender, EventArgs e)
        {
            txtEfectivo.SelectAll();
        }

        private void chbSaldo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSaldo.Checked)
            {
                IDDevolucion = (new frmDevolucionesVenta()).IDDevolucion();
                if (idDevolucion > 0)
                {
                    lblESaldo.Visible = true;
                    lblSaldo.Visible = true;
                    lblSaldo.Text = saldo.ToString("C2");
                    CobroConSaldo();
                }
                else
                {
                    chbSaldo.Checked = false;
                }
            }
            else
            {
                if (saldo > 0)
                {
                    total = tmpTotal;
                    lblTotal.Text = total.ToString("C2");
                    CalcularCambio();
                }
                idDevolucion = 0;
                saldo = 0;
                lblESaldo.Visible = false;
                lblSaldo.Visible = false;
            }
        }
    }
}
