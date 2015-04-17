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
        frmPOS frm;
        public frmDatosVentaProducto(frmPOS frm, string nombre, decimal cant, decimal descuento)
        {
            InitializeComponent();
            this.Text += nombre;
            nudCant.Value = cant;
            txtDescuento.Text = descuento.ToString();
            this.frm = frm;
            nudCant.Select();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal desc;
            decimal.TryParse(txtDescuento.Text, out desc);
            frm.ModificarProducto(nudCant.Value, desc);
            this.Close();
        }
    }
}
