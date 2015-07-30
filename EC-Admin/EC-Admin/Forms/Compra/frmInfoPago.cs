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
    public partial class frmInfoPago : Form
    {
        int index, idAux, idCuentaOrigen, idCuentaDestino;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        frmNuevaCompra frmNC = null;
        Cuenta ct;

        public frmInfoPago(int index, frmNuevaCompra frm)
        {
            InitializeComponent();
            this.index = index;
            frmNC = frm;
            if (frm.Configurado)
            {
                idCuentaOrigen = frm.IDCuentaOrigen;
                RecargarDatos();
            }
                
            switch (index)
            {
                case 1:
                    btnCuentaDestino.Visible = false;
                    grbCuentaDestino.Visible = false;
                    txtConcepto.Visible = false;
                    lblConcepto.Visible = false;
                    grbInfo.Text = "Pago por Cheque";
                    lblDato1.Text = "N° de cheque";
                    lblDato2.Text = "Beneficiario";
                    if (frm.Configurado)
                    {
                        txtDato1.Text = frm.NumCheque;
                        txtDato2.Text = frm.Beneficiario;
                    }
                    break;
                case 2:
                    btnCuentaDestino.Visible = false;
                    grbCuentaDestino.Visible = false;
                    txtConcepto.Visible = false;
                    lblConcepto.Visible = false;
                    grbInfo.Text = "Pago a Crédito";
                    lblDato1.Text = "Folio de terminal";
                    lblDato2.Text = "Comision en %";
                    if (frm.Configurado)
                    {
                        txtDato1.Text = frm.FolioTerminal;
                        txtDato2.Text = frm.Comision.ToString();
                    }
                    break;
                case 3:
                    btnCuentaDestino.Visible = false;
                    grbCuentaDestino.Visible = false;
                    txtConcepto.Visible = false;
                    lblConcepto.Visible = false;
                    grbInfo.Text = "Pago a Débito";
                    lblDato1.Text = "Folio de terminal";
                    lblDato2.Text = "Comision en %";
                    if (frm.Configurado)
                    {
                        txtDato1.Text = frm.FolioTerminal;
                        txtDato2.Text = frm.Comision.ToString();
                    }
                    break;
                case 4:
                    btnCuentaDestino.Visible = true;
                    grbCuentaDestino.Visible = true;
                    txtConcepto.Visible = true;
                    lblConcepto.Visible = true;
                    grbInfo.Text = "Pago por Transferencia";
                    lblDato1.Text = "Referencia";
                    lblDato2.Text = "Comision en $";
                    if (frm.Configurado)
                    {
                        txtDato1.Text = frm.Referencia;
                        txtDato2.Text = frm.Comision.ToString();
                        txtConcepto.Text = frm.ConceptoPago;
                        idCuentaDestino = frm.IDCuentaDestino;
                    }
                    break;
            }
            
            
        }

        private void RecargarDatos()
        {
            ct = new Cuenta(frmNC.IDCuentaOrigen);
            ct.ObtenerDatos();
            lblBancoOrigen.Text = ct.Banco;
            lblCuentaOrigen.Text = ct.NumeroCuenta;
            lblSucOrigen.Text = ct.Sucursal;
            lblBenefOrigen.Text = ct.Beneficiario;
            ct = null;
            if (frmNC.IDCuentaDestino != 0)
            {
                ct = new Cuenta(frmNC.IDCuentaDestino);
                ct.ObtenerDatos();
                lblBancoDestino.Text = ct.Banco;
                lblCuentaDestino.Text = ct.NumeroCuenta;
                lblSucDestino.Text = ct.Sucursal;
                lblBenefDestino.Text = ct.Beneficiario;
                ct = null;
            }
            
        }
        private bool VerificarDatos()
        {
            switch (index)
            {
                case 1:
                    if (txtDato1.Text.Trim() == "")
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el número de cheque", "Admin CSY");
                        return false;
                    }
                    if (txtDato2.Text.Trim() == "")
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar un beneficiario", "Admin CSY");
                        return false;
                    }
                    break;
                case 2:
                case 3:
                    if (txtDato1.Text.Trim() == "")
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar el folio de la terminal", "Admin CSY");
                        return false;
                    }
                    if (txtDato2.Text.Trim() == "")
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar una comision", "Admin CSY");
                        return false;
                    }
                    
                    break;
                case 4:
                    if (txtDato1.Text.Trim() == "")
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar la referencia", "Admin CSY");
                        return false;
                    }
                    if (txtDato2.Text.Trim() == "")
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar una comision", "Admin CSY");
                        return false;
                    }
                    if (txtConcepto.Text.Trim() == "")
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debes ingresar un concepto de pago por la transferencia", "Admin CSY");
                        return false;
                    }
                    break;
            }
            return true;
        }


        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar()
        {
            try
            {
                string sql = "SELECT * FROM cuenta WHERE id_sucursal=" + Config.idSucursal;
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las cuentas. No se ha podido conectar a la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las cuentas.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            dgvCuentas.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                dgvCuentas.Rows.Add(new object[] { dr["id"], (TipoCuenta)Enum.Parse(typeof(TipoCuenta),dr["tipo"].ToString()),dr["clabe"], dr["banco"], dr["beneficiario"], dr["sucursal"], dr["num_cuenta"] });
            }
            dgvCuentas_RowEnter(dgvCuentas, new DataGridViewCellEventArgs(0, 0));
        }

        


        private void frmInfoPago_Load(object sender, EventArgs e)
        {
            bgwBusqueda.RunWorkerAsync();
        }

        private void DatosCuenta(bool origen)
        {
            try
            {
                Cuenta c = new Cuenta(idAux);
                c.ObtenerDatos();
                if (origen)
                {
                    lblBancoOrigen.Text = c.Banco;
                    lblCuentaOrigen.Text = c.NumeroCuenta;
                    lblSucOrigen.Text = c.Sucursal;
                    lblBenefOrigen.Text = c.Beneficiario;
                    idCuentaOrigen = idAux;
                }
                else
                {
                    lblBancoDestino.Text = c.Banco;
                    lblCuentaDestino.Text = c.NumeroCuenta;
                    lblSucDestino.Text = c.Sucursal;
                    lblBenefDestino.Text = c.Beneficiario;
                    idCuentaDestino = idAux;
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de la cuenta. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de la cuenta.", "Admin CSY", ex);
            }
        }

        private void btnCuentaOrigen_Click(object sender, EventArgs e)
        {
            if (idCuentaOrigen <= 0 || idAux != idCuentaOrigen)
            {
                idCuentaOrigen = idAux;
                Cuenta c = new Cuenta(idCuentaOrigen);
                c.ObtenerDatos();
                if (idCuentaOrigen != idCuentaDestino)
                {
                    if (c.TipoCuenta == TipoCuenta.Sucursal)
                        DatosCuenta(true);
                    else
                    {
                        (new frmMensaje(Mensajes.Alerta, "Debe asignar una cuenta origen de tipo sucursal", "Admin CSY")).ShowDialog(this);
                        idCuentaOrigen = 0;
                    }
                        
                }
                else
                {
                    (new frmMensaje(Mensajes.Alerta, "Debe asignar cuentas diferentes", "Admin CSY")).ShowDialog(this);
                    idCuentaOrigen = 0;
                }
                       
            }   
        }

        private void btnCuentaDestino_Click(object sender, EventArgs e)
        {
            if (idCuentaDestino <= 0 || idAux != idCuentaDestino)
            {
                idCuentaDestino = idAux;
                Cuenta c = new Cuenta(idCuentaDestino);
                c.ObtenerDatos();
                if (idCuentaDestino != idCuentaOrigen)
                {
                    if (c.TipoCuenta == TipoCuenta.Proveedor)
                        DatosCuenta(false);
                    else
                    {
                        (new frmMensaje(Mensajes.Alerta, "Debe asignar una cuenta origen de tipo proveedor", "Admin CSY")).ShowDialog(this);
                        idCuentaDestino = 0;
                    }
                        
                }
                else
                {
                    (new frmMensaje(Mensajes.Alerta, "Debe asignar cuentas diferentes", "Admin CSY")).ShowDialog(this);
                    idCuentaDestino = 0;
                }
                    
            }
            
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            Buscar();
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, buscando cuentas bancarias", this);
        }

        private void dgvCuentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentas.CurrentRow != null)
                idAux = (int)dgvCuentas[0, e.RowIndex].Value;
            else
                idAux = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarDatos())
            {
                if (dgvCuentas.CurrentRow != null && idCuentaOrigen > 0)
                {
                    if (frmNC != null)
                    {
                        frmNC.IDCuentaOrigen = idCuentaOrigen;
                        switch (index)
                        {
                            case 1:
                                frmNC.NumCheque = txtDato1.Text;
                                frmNC.Beneficiario = txtDato2.Text;
                                break;
                            case 2:
                            case 3:
                                frmNC.FolioTerminal = txtDato1.Text;
                                frmNC.Comision = Convert.ToDecimal(txtDato2.Text);
                                break;
                            case 4:
                                frmNC.IDCuentaDestino = idCuentaDestino;
                                frmNC.Referencia = txtDato1.Text;
                                frmNC.Comision = Convert.ToDecimal(txtDato2.Text);
                                frmNC.ConceptoPago = txtConcepto.Text;
                                break;
                        }
                        frmNC.Configurado = true;
                    }
                    this.Close();
                }
            }
        }
    }
}
