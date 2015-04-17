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
    public partial class frmCobrar : Form
    {
        frmPOS frm;
        decimal total;

        public frmCobrar(frmPOS frm, decimal total)
        {
            InitializeComponent();
            this.frm = frm;
            lblTotal.Text = total.ToString("C2");
            this.total = total;
            cboTipoPago.SelectedIndex = 0;
            CalcularCambio();
        }

        private void CalcularCambio()
        {
            decimal efectivo, cambio;
            decimal.TryParse(txtEfectivo.Text, out efectivo);
            cambio = total - efectivo;
            if (cambio > 0)
            {
                lblECambio.Text = "Falta:";
                lblECambio.Location = new Point(230, 102);
                lblCambio.BackColor = Colores.Error;
                lblCambio.Text = cambio.ToString("C2");
            }
            else
            {
                lblECambio.Text = "Cambio:";
                lblECambio.Location = new Point(206, 102);
                lblCambio.BackColor = Colores.Exito;
                lblCambio.Text = (cambio * -1).ToString("C2");
            }
        }

        private void frmCobrar_Load(object sender, EventArgs e)
        {
            txtEfectivo.Select();
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTipoPago.SelectedIndex)
            {
                case 0:
                    lblEEfectivo.Enabled = true;
                    txtEfectivo.Enabled = true;
                    break;
                default:
                    lblEEfectivo.Enabled = false;
                    txtEfectivo.Enabled = false;
                    txtEfectivo.Text = "0.00";
                    lblCambio.Text = "$0.00";
                    lblCambio.BackColor = Colores.Exito;
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
                    frm.GuardarVenta(false, (TipoPago)Enum.Parse(typeof(TipoPago), cboTipoPago.SelectedIndex.ToString()));
                    FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha guardado los datos de la venta correctamente!", "EC-Admin");
                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar los datos de la venta. No se ha podido conectar con la base de datos.", "EC-Admin", ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al guardar los datos de la venta.", "EC-Admin", ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "El efectivo debe ser mayor o igual al total", "EC-Admin");
            }
        }
    }
}
