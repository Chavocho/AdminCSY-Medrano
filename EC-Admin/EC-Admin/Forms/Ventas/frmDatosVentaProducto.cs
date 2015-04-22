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
    public partial class frmDatosVentaProducto : Form
    {
        frmPOS frm = null;
        frmNuevaCompra frmC = null;
        public frmDatosVentaProducto(frmPOS frm, string nombre, decimal cant, decimal descuento)
        {
            InitializeComponent();
            this.Text += nombre;
            nudCant.Value = cant;
            txtDescuento.Text = descuento.ToString();
            this.frm = frm;
            nudCant.Select();
        }

        public frmDatosVentaProducto(frmNuevaCompra frm, string nombre, decimal cant, decimal descuento)
        {
            InitializeComponent();
            this.frmC = frm;
            this.Text += nombre;
            nudCant.Value = cant;
            txtDescuento.Text = descuento.ToString();
            nudCant.Select();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal desc;
            decimal.TryParse(txtDescuento.Text, out desc);
            if (frm != null)
                frm.ModificarProducto(nudCant.Value, desc);
            else if (frmC != null)
                frmC.ModificarProducto(nudCant.Value, desc);
            this.Close();
        }
    }
}
