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
    public partial class frmCancelacionCompra : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmCancelacionCompra()
        {
            InitializeComponent();
            c = new CerrarFrmEspera(Cerrar);
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }
        
        private void Buscar(string p)
        {
            try
            {
                string sql = "SELECT id, id_proveedor, id_comprador, total, tipo_pago, create_time FROM compra WHERE id='" + p + "' AND cancelada=0 AND id_sucursal='" + Config.idSucursal + "'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las compras. No se ha podido conectar con la base de datos.", Config.shrug, ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las compras.", Config.shrug, ex });
            }
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, id_proveedor, id_comprador, total, tipo_pago, create_time FROM compra WHERE (create_time BETWEEN ?fechaIni AND ?fechaFin) AND cancelada=0 AND id_sucursal='" + Config.idSucursal + "'";
                sql.Parameters.AddWithValue("?fechaIni", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fechaFin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las compras. No se ha podido conectar con la base de datos.", Config.shrug, ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las compras.", Config.shrug, ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvCompras.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    decimal total = (decimal)dr["total"], totalDev = DevolucionesCompra.TotalDevolucion((int)dr["id"]);
                    string tipoPago = "";
                    switch ((TipoPago)Enum.Parse(typeof(TipoPago), dr["tipo_pago"].ToString()))
                    {
                        case TipoPago.Efectivo:
                            tipoPago = "Efectivo";
                            break;
                        case TipoPago.Cheque:
                            tipoPago = "Cheque";
                            break;
                        case TipoPago.Crédito:
                            tipoPago = "Crédito";
                            break;
                        case TipoPago.Débito:
                            tipoPago = "Débito";
                            break;
                        case TipoPago.Transferencia:
                            tipoPago = "Transferencia";
                            break;
                    }
                    if ((total - totalDev) > 0)
                        dgvCompras.Rows.Add(new object[] { dr["id"], Cliente.NombreCliente((int)dr["id_proveedor"]), Trabajador.NombreTrabajador((int)dr["id_comprador"]), total - totalDev, tipoPago, dr["create_time"], totalDev });
                }
                dgvCompras_RowEnter(dgvCompras, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar las compras.", Config.shrug, ex);
            }
        }

        private void dgvCompras_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompras.CurrentRow != null)
                id = (int)dgvCompras[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!bgwBusqueda.IsBusy)
            {
                bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
                tmrEspera.Enabled = true;
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !bgwBusqueda.IsBusy)
            {
                bgwBusqueda.RunWorkerAsync(new object[] { txtBusqueda.Text });
                tmrEspera.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Privilegios._CancelarCompra)
            {
                if (dgvCompras.CurrentRow != null)
                {
                    if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas cancelar ésta compra? (Los productos de la compra se quitarán de inventario)", "Admin CSY") == DialogResult.Yes)
                    {
                        try
                        {
                            if ((decimal)dgvCompras[6, dgvCompras.CurrentRow.Index].Value > 0)
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "A la compra se le resto el valor de " + ((decimal)dgvCompras[6, dgvCompras.CurrentRow.Index].Value).ToString("C2") + " dado a que ya se habían devuelto productos con anterioridad.", "Admin CSY");
                            }
                            Compra.CancelarCompra(id);
                            FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha cancelado la compra correctamente!", "Admin CSY");
                            dgvCompras.Rows.Remove(dgvCompras.CurrentRow);
                        }
                        catch (MySqlException ex)
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cancelar la compra. No se ha podido conectar con la base de datos.", Config.shrug, ex);
                        }
                        catch (Exception ex)
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cancelar la compra.", Config.shrug, ex);
                        }
                    }
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            if (!Privilegios._DevolucionCompra)
            {
                if (dgvCompras.CurrentRow != null)
                {
                    (new frmDevolucionesCompra(id)).ShowDialog(this);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            if (a.Length == 1)
                Buscar(a[0].ToString());
            else if (a.Length == 2)
                Buscar((DateTime)a[0], (DateTime)a[1]);
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando compras", this);
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
            else if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
        }
    }
}
