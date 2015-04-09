﻿using System;
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
    public partial class frmProducto : Form
    {
        #region Instancia
        private static frmProducto frmInstancia;
        public static frmProducto Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmProducto();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmProducto();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id = 0;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);

        public frmProducto()
        {
            InitializeComponent();
        }

        private void Cerrar()
        {
            txtBusqueda.Enabled = true;
            tmrEspera.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void Buscar(string p)
        {
            try
            {
                string sql = "SELECT p.id, p.nombre, a.num_alm, p.codigo, p.costo, p.precio, p.cant FROM producto AS p INNER JOIN almacen AS a ON (p.almacen_id=a.id) " +
                    "WHERE (p.nombre LIKE '%" + p + "%' OR p.codigo='" + p + "') AND eliminado=0";
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos. No se ha podido conectar a la base de datos.", "EC-Admin", ex });
            }
            catch (Exception ex)
            {
                Cerrar();
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar los productos.", "EC-Admin", ex });
            }
        }

        private void LlenarDataGrid()
        {
            try
            {
                dgvProductos.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    dgvProductos.Rows.Add(new object[] { dr["id"], dr["nombre"], dr["num_alm"], dr["codigo"], dr["costo"], dr["precio"], dr["cant"] });
                }
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Eliminar()
        {
            try
            {
                Producto.CambiarEstado(id, true);
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

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                id = (int)dgvProductos[0, e.RowIndex].Value;
            else
                id = 0;
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBusqueda.Enabled = false;
                tmrEspera.Enabled = true;
                bgwBusqueda.RunWorkerAsync(txtBusqueda.Text);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmNuevoProducto()).ShowDialog(this);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && id > 0)
            {
                (new frmEditarProducto(id)).ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && id > 0)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Realmente desea eliminar el producto con nombre " + dgvProductos[1, dgvProductos.CurrentRow.Index].Value.ToString() + "?", "EC-Admin") == System.Windows.Forms.DialogResult.Yes)
                {
                    Eliminar();
                }
            }
        }
    }
}