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
    public partial class frmCancelaciones : Form
    {
        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmCancelaciones()
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
                string sql = "SELECT id, id_cliente, id_vendedor, total, tipo_pago, create_time, update_time FROM venta WHERE id='" + id + "' AND abierta=0 AND cancelada=0 AND id_sucursal='" + Config.idSucursal + "'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar a la base de datos.", Config.shrug, ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas.", Config.shrug, ex });
            }
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT id, id_cliente, id_vendedor, total, tipo_pago, create_time, update_time FROM venta " +
                    "WHERE ((create_time BETWEEN ?fecha_ini AND ?fecha_fin) OR (update_time BETWEEN ?fecha_ini AND ?fecha_fin)) AND abierta=0 AND cancelada=0 AND id_sucursal='" + Config.idSucursal + "'";
                sql.Parameters.AddWithValue("?fecha_ini", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fecha_fin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar a la base de datos.", Config.shrug, ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas.", Config.shrug, ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvVentas.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    decimal total = (decimal)dr["total"], totalDev = Devoluciones.TotalDevolucion((int)dr["id"]);
                    string tipoPago = "";
                    DateTime fecha;
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
                    if (dr["update_time"] != DBNull.Value)
                        fecha = (DateTime)dr["update_time"];
                    else
                        fecha = (DateTime)dr["create_time"];

                    if ((total - totalDev) > 0)
                        dgvVentas.Rows.Add(new object[] { dr["id"],  Cliente.NombreCliente((int)dr["id_cliente"]), Trabajador.NombreTrabajador((int)dr["id_vendedor"]), total - totalDev, tipoPago, fecha, totalDev });
                    Application.DoEvents();
                }
                dgvVentas_RowEnter(dgvVentas, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar las ventas.", Config.shrug, ex);
            }
        }

        private void MovimientoCaja()
        {
            try
            {
                DataGridViewRow dr = dgvVentas.CurrentRow;
                Caja c = new Caja();
                c.Descripcion = "CANCELACIÓN DE VENTA CON FOLIO: " + dgvVentas[0, dgvVentas.CurrentRow.Index].Value.ToString();
                switch (dr.Cells[4].Value.ToString())
                {
                    case "Efectivo":
                        c.Efectivo = (decimal)dr.Cells[3].Value;
                        //c.Voucher = 0M;
                        break;
                    case "Crédito":
                        c.Efectivo = 0M;
                        //c.Voucher = (decimal)dr.Cells[3].Value;
                        break;
                    case "Débito":
                        c.Efectivo = 0M;
                        //c.Voucher = (decimal)dr.Cells[3].Value;
                        break;
                }
                c.TipoMovimiento = EC_Admin.MovimientoCaja.Salida;
                c.IDSucursal = Config.idSucursal;
                c.RegistrarMovimiento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvVentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                id = (int)dgvVentas[0, e.RowIndex].Value;
            }
            else
            {
                id = 0;
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !bgwBusqueda.IsBusy)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(new object[] { txtBusqueda.Text });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!bgwBusqueda.IsBusy)
            {
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
            }
        }

        private void dtpFechas_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            if (a.Length == 1)
            {
                Buscar(a[0].ToString());
            }
            else
            {
                Buscar((DateTime)a[0], (DateTime)a[1]);
            }
        }

        private void bgwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cerrar();
            LlenarDataGrid();
        }

        private void tmrEspera_Tick(object sender, EventArgs e)
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEspera("Espere, cargando las ventas", this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Privilegios._CancelarVenta)
            {
                if (dgvVentas.CurrentRow != null)
                {
                    if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente desea cancelar esta venta?", "Admin CSY") == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            if ((decimal)dgvVentas[6, dgvVentas.CurrentRow.Index].Value > 0)
                            {
                                FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "A la venta se le resto el valor de " + ((decimal)dgvVentas[6, dgvVentas.CurrentRow.Index].Value).ToString("C2") + " dado a que ya se habían devuelto productos con anterioridad.", "Admin CSY");
                            }
                            Venta.CancelarVenta((int)dgvVentas[0, dgvVentas.CurrentRow.Index].Value);
                            MovimientoCaja();
                            FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha cancelado correctamente la venta!", "Admin CSY");
                            dgvVentas.Rows.Remove(dgvVentas.CurrentRow);

                        }
                        catch (MySqlException ex)
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cancelar la venta. No se ha podido conectar a la base de datos. Vuelva a cargar la lista de ventas para asegurarse de que ésta se haya cancelado.", Config.shrug, ex);
                        }
                        catch (Exception ex)
                        {
                            FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cancelar la venta. Vuelva a cargar la lista de ventas para asegurarse de que ésta se haya cancelado.", Config.shrug, ex);
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
            if (Privilegios._DevolucionVenta)
            {
                if (dgvVentas.CurrentRow != null)
                {
                    (new frmDevoluciones(id)).ShowDialog(this);
                    if (txtBusqueda.Text != "")
                        bgwBusqueda.RunWorkerAsync(new object[] { txtBusqueda.Text });
                    else
                        bgwBusqueda.RunWorkerAsync(new object[] { dtpFechaInicio.Value, dtpFechaFin.Value });
                    tmrEspera.Enabled = true;
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }
    }
}
