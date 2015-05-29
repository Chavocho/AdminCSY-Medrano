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
    public partial class frmPromociones : Form
    {
        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        public frmPromociones()
        {
            InitializeComponent();
            cboTipoPromocion.SelectedIndex = 0;
        }

        private void Cerrar()
        {
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void BuscarFechas(string p)
        {
            c = new CerrarFrmEspera(Cerrar);
            try
            {
                string sql = "SELECT p.id, pr.nombre, p.fecha_ini, p.fecha_fin, p.precio FROM promocion AS p INNER JOIN producto AS pr ON (p.id_producto=pr.id) WHERE pr.nombre LIKE '%" + p + "%' AND p.existencias=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las promociones. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las promociones.", "Admin CSY", ex });
            }
        }

        private void BuscarExistencias(string p)
        {
            try
            {
                string sql = "SELECT p.id, pr.nombre, p.cant, p.precio FROM promocion AS p INNER JOIN producto AS pr ON (p.id_producto=pr.id) WHERE pr.nombre LIKE '%" + p + "%' AND p.existencias=1";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las promociones. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las promociones.", "Admin CSY", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvPromociones.Rows.Clear();
                if (cboTipoPromocion.SelectedIndex == 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvPromociones.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["fecha_ini"], dr["fecha_fin"], -1, dr["precio"] });
                    }
                }
                else if (cboTipoPromocion.SelectedIndex == 1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dgvPromociones.Rows.Add(new object[] { dr["id"], dr["nombre"], new DateTime(), new DateTime(), dr["cant"], dr["precio"] });
                    }
                }
                if (dgvPromociones.RowCount > 0)
                {
                    dgvPromociones[1, 0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar la información.", "Admin CSY ", ex);
            }
        }

        private void cboTipoPromocion_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPromociones.Rows.Clear();
            if (cboTipoPromocion.SelectedIndex == 0)
            {
                dgvPromociones.Columns[2].Visible = true;
                dgvPromociones.Columns[3].Visible = true;
                dgvPromociones.Columns[4].Visible = false;
            }
            else if (cboTipoPromocion.SelectedIndex == 1)
            {
                dgvPromociones.Columns[2].Visible = false;
                dgvPromociones.Columns[3].Visible = false;
                dgvPromociones.Columns[4].Visible = true;
            }
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bgwBusqueda.RunWorkerAsync(new object[] { txtBusqueda.Text, cboTipoPromocion.SelectedIndex });
            }
        }

        private void bgwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] a = (object[])e.Argument;
            if ((int)a[1] == 0)
            {
                BuscarFechas(a[0].ToString());
            }
            else if ((int)a[1] == 1)
            {
                BuscarExistencias(a[0].ToString());
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
            FuncionesGenerales.frmEspera("Espere, cargando las promociones", this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }


    }
}
