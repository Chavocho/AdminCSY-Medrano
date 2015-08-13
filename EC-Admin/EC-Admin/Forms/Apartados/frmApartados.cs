using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EC_Admin.Forms
{
    public partial class frmApartados : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmApartados()
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
                string sql = "SELECT a.id, c.nombre, a.estado, (SELECT COUNT(id_apartado) FROM apartado_detallado WHERE id_apartado=a.id) AS c, a.create_time FROM apartado AS a INNER JOIN cliente AS c ON (a.id_cliente=c.id) " +
                    "WHERE a.id='" + p + "' AND a.id_sucursal='" + Config.idSucursal + "'";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los apartados. No se ha podido conectar con la base de datos.", Config.shrug, ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los apartados.", Config.shrug, ex });
            }
        }

        private void Buscar(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT a.id, c.nombre, a.estado, (SELECT COUNT(id_apartado) FROM apartado_detallado WHERE id_apartado=a.id) AS c, a.create_time FROM apartado AS a INNER JOIN cliente AS c ON (a.id_cliente=c.id) " +
                    "WHERE (a.create_time BETWEEN ?fecha_ini AND ?fecha_fin) AND a.id_sucursal='" + Config.idSucursal + "'";
                sql.Parameters.AddWithValue("?fecha_ini", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fecha_fin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los apartados. No se ha podido conectar con la base de datos.", Config.shrug, ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los apartados.", Config.shrug, ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvCategorias.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    EstadoApartado e = (EstadoApartado)Enum.Parse(typeof(EstadoApartado), dr["estado"].ToString());
                    string estado = "";
                    switch (e)
                    {
                        case EstadoApartado.Espera:
                            estado = "Espera";
                            break;
                        case EstadoApartado.Salio:
                            estado = "A venta";
                            break;
                        case EstadoApartado.Cancelada:
                            estado = "Cancelada";
                            break;
                    }
                    dgvCategorias.Rows.Add(new object[] { dr["id"], dr["nombre"], estado, e, dr["c"], dr["create_time"] });
                }
                dgvCategorias_RowEnter(dgvCategorias, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los apartados.", Config.shrug, ex);
            }
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

        private void dgvCategorias_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                id = (int)dgvCategorias[0, e.RowIndex].Value;
                if ((EstadoApartado)Enum.Parse(typeof(EstadoApartado), dgvCategorias[3, e.RowIndex].Value.ToString()) == EstadoApartado.Espera)
                {
                    btnAceptar.Visible = btnCancelar.Visible = true;
                }
                else
                {
                    btnAceptar.Visible = btnCancelar.Visible = false;
                }
            }
            else
            {
                id = 0;
                btnAceptar.Visible = btnCancelar.Visible = false;
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            if (a.Length == 1)
            {
                Buscar(a[0].ToString());
            }
            else if (a.Length == 2)
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
            FuncionesGenerales.frmEspera("Espere, cargando apartados", this);
        }

        async private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Privilegios._EstadoApartado)
            {
                try
                {
                    if (dgvCategorias.CurrentRow != null)
                    {
                        await Apartados.CambiarEstado(id, EstadoApartado.Salio);
                        Apartados a = new Apartados(id);
                        await a.ObtenerDatosAsync();
                        frmPOS.Instancia.VentaApartado(a);
                        this.Close();
                    }
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mandar a venta el apartado. No se ha podido conectar a la base de datos.", Config.shrug, ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mandar a venta el apartado.", Config.shrug, ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }

        async private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Privilegios._EstadoApartado)
            {
                try
                {
                    if (dgvCategorias.CurrentRow != null)
                    {
                        await Apartados.CambiarEstado(id, EstadoApartado.Cancelada);
                        dgvCategorias[3, dgvCategorias.CurrentRow.Index].Value = EstadoApartado.Cancelada;
                        dgvCategorias[2, dgvCategorias.CurrentRow.Index].Value = "Cancelada";
                        btnAceptar.Visible = btnCancelar.Visible = false;
                    }
                }
                catch (MySqlException ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cancelar el apartado. No se ha podido conectar a la base de datos.", Config.shrug, ex);
                }
                catch (Exception ex)
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al cancelar el apartado.", Config.shrug, ex);
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Privilegios._CrearApartado)
            {
                if (Trabajador.Cantidad > 0)
                {
                    (new frmNuevoApartado()).ShowDialog(this);
                }
                else
                {
                    FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes trabajadores registrados. Para realizar apartados, debes tener al menos un trabajador registrado.", "Admin CSY");
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "No tienes los permisos necesarios para realizar ésta acción. Habla con tu administrador para que te asigne los permisos necesarios.", "Admin CSY");
            }
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
                dtpFechaFin.Value = dtpFechaInicio.Value;
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
                dtpFechaInicio.Value = dtpFechaFin.Value;
        }
    }
}
