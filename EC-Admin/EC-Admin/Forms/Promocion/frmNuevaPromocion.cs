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
    public partial class frmNuevaPromocion : Form
    {
        int id = -1;
        decimal costo;

        public frmNuevaPromocion()
        {
            InitializeComponent();
            chbExistencias.Checked = true;
        }

        public void AsignarProducto(int id, string nombre, decimal costo)
        {
            this.id = id;
            this.costo = costo;
            lblProducto.Text = nombre;
        }

        private void Insertar()
        {
            try
            {
                Promociones p = new Promociones();
                p.IDProducto = id;
                p.Existencias = chbExistencias.Checked;
                if (chbExistencias.Checked)
                {
                    p.FechaInicio = new DateTime();
                    p.FechaFin = new DateTime();
                    p.Cantidad = decimal.Parse(txtCant.Text);
                }
                else
                {
                    p.FechaInicio = dtpFechaIni.Value;
                    p.FechaFin = dtpFechaFin.Value;
                    p.Cantidad = 0M;
                }
                p.Precio = decimal.Parse(txtPrecio.Text);
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

        private bool VerificarCampos()
        {
            bool res = true;
            if (txtPrecio.Text.Trim() == "")
            {
                FuncionesGenerales.ColoresError(txtPrecio);
                res = false;
            }
            return res;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, false);
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesGenerales.VerificarEsNumero(ref sender, ref e, true);
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaIni.Value > dtpFechaFin.Value)
                dtpFechaIni.Value = dtpFechaFin.Value;
            if (dtpFechaFin.Value < dtpFechaIni.Value)
                dtpFechaFin.Value = dtpFechaIni.Value;
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            (new frmProductoPromocion(this)).ShowDialog(this);
        }

        private void chbExistencias_CheckedChanged(object sender, EventArgs e)
        {
            if (chbExistencias.Checked)
            {
                dtpFechaIni.Enabled = false;
                dtpFechaFin.Enabled = false;
                txtCant.Enabled = true;
            }
            else
            {
                dtpFechaIni.Enabled = true;
                dtpFechaFin.Enabled = true;
                txtCant.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
