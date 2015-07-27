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
    public partial class frmNuevoApartado : Form
    {
        int id;
        //Variable para el control de excepciones
        int cont = 0;
        int cantTot = 0;
        
        private int idCliente;
        
        public frmNuevoApartado()
        {
            InitializeComponent();
        }

        #region Apartados

        async private void InsertarApartado()
        {
            Apartados a = new Apartados();
            a.IDCliente = idCliente;
            a.IDSucursal = Config.idSucursal;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                a.IDProductos.Add((int)dr.Cells[0].Value);
                a.CantProductos.Add((int)dr.Cells[4].Value);
            }
            await a.InsertarAsync();
        }

        #endregion

        #region Productos

        /// <summary>
        /// Método que agrega un producto a la venta
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <param name="nombre">Nombre del producto</param>
        /// <param name="precio">Precio del producto</param>
        /// <param name="cant">Cantidad del producto</param>
        /// <param name="desc">Descuento aplicado al producto</param>
        public void AgregarProducto(int id, string codProd, string nombre, decimal precio, int cant, decimal desc, Unidades u)
        {
            if (!VerificarProducto(id, cant))
            {
                int cantInv = Inventario.CantidadProducto(id, Config.idSucursal);
                if (cant <= cantInv)
                {
                    dgvProductos.Rows.Add(new object[] { id, codProd, nombre, precio, cant, desc, u });
                    if (dgvProductos.RowCount == 1)
                    {
                        dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                        dgvProductos_CellClick(dgvProductos, new DataGridViewCellEventArgs(0, 0));
                    }
                }
            }
        }

        /// <summary>
        /// Método que verifica la existencia del producto en la venta, en caso de estar registrado, suma la cantidad
        /// dada al producto
        /// </summary>
        /// <param name="id">ID del producto</param>
        /// <param name="cant">Cantidad a añadir al producto</param>
        private bool VerificarProducto(int id, int cant)
        {
            bool existe = false;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                if (dr.Cells[0].Value.ToString() == id.ToString())
                {
                    int c = ((int)dr.Cells[4].Value + cant);
                    int cantInv = Inventario.CantidadProducto(id, Config.idSucursal);
                    if (c <= cantInv)
                    {
                        dr.Cells[4].Value = c;
                    }
                    else
                    {
                        FuncionesGenerales.Mensaje(this, Mensajes.Informativo, "La cantidad de productos que tratas de ingresar excede a la cantidad en inventario. La cantidad en inventario de \"" + dr.Cells[2].Value.ToString() + "\" son \"" + cantInv.ToString("0") + "\"", "Admin CSY");
                        dr.Cells[4].Value = cantInv;
                    }
                    existe = true;
                    if (c <= 0)
                        QuitarProducto(dr);
                    CalcularTotales();
                    break;
                }
            }
            return existe;
        }
        
        public void ModificarProducto(int cant, decimal desc)
        {
            dgvProductos[4, dgvProductos.CurrentRow.Index].Value = cant;
            dgvProductos[5, dgvProductos.CurrentRow.Index].Value = desc;
            CalcularTotales();
        }

        private void QuitarProducto()
        {
            if (dgvProductos.CurrentRow != null)
            {
                int ind = dgvProductos.CurrentRow.Index;
                dgvProductos.Rows.Remove(dgvProductos.CurrentRow);
                CambioImagen(ind);
                CalcularTotales();
            }
        }

        private void QuitarProducto(DataGridViewRow dr)
        {
            int ind = dr.Index;
            dgvProductos.Rows.Remove(dr);
            CambioImagen(ind);
            CalcularTotales();
        }

        private void CambioImagen(int ind)
        {
            if (ind <= dgvProductos.RowCount - 1)
            {
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, ind));
                dgvProductos_CellClick(dgvProductos, new DataGridViewCellEventArgs(0, ind));
            }
            else if (ind > dgvProductos.RowCount - 1)
            {
                dgvProductos_RowEnter(dgvProductos, new DataGridViewCellEventArgs(0, dgvProductos.RowCount - 1));
                dgvProductos_CellClick(dgvProductos, new DataGridViewCellEventArgs(0, dgvProductos.RowCount - 1));
            }
        }

        private void BusquedaProducto(string codProd, int cant)
        {
            try
            {
                string sql = "SELECT p.id, p.nombre, p.codigo, i.precio, p.unidad FROM producto AS p INNER JOIN inventario AS i ON (p.id=i.id_producto) WHERE codigo='" + codProd + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    AgregarProducto((int)dr["id"], dr["codigo"].ToString(), dr["nombre"].ToString(), (decimal)dr["precio"], cant, 0M, (Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString()));
                    break;
                }
            }
            catch (MySqlException ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto. No se ha podido conectar con la base de datos.", "Admin CSY", ex);
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al buscar el producto.", "Admin CSY", ex);
            }
        }

        private string CodigoProducto(int id)
        {
            string cod = "";
            try
            {
                string sql = "SELECT codigo FROM producto WHERE id='" + id + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cod = dr["codigo"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cod;
        }

        private void Imagen(Image img)
        {
            pcbProducto.Image = img;
        }

        private void bgwImagen_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pcbProducto.InvokeRequired)
            {
                try
                {
                    Action<Image> i = new Action<Image>(Imagen);
                    this.Invoke(i, Producto.Imagen01Producto(id));
                }
                catch
                {
                }
            }
        }

        #endregion

        #region Métodos DataGrid y demás

        private void CalcularTotales()
        {
            cantTot = 0;
            foreach (DataGridViewRow dr in dgvProductos.Rows)
            {
                cantTot += (int)dr.Cells[4].Value;
            }

            lblCantDif.Text = dgvProductos.RowCount.ToString();
            lblCantTot.Text = cantTot.ToString();
        }

        #endregion

        #region Clientes

        public void AsignarCliente(int id, string nombre)
        {
            this.idCliente = id;
            this.lblCliente.Text = nombre;
        }

        #endregion

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                id = (int)dgvProductos[0, e.RowIndex].Value;
                dgvProductos.Rows[e.RowIndex].Selected = true;
            }
            else
                id = 0;
            txtBusqueda.Select();
        }

        /// <summary>
        /// Método al que llama el evento CellClick del dgvProductos y que ejecuta la búsqueda de imagen del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
                if (!bgwImagen.IsBusy)
                    bgwImagen.RunWorkerAsync();
            txtBusqueda.Select();
        }

        private void frmNuevoApartado_Load(object sender, EventArgs e)
        {
            AsignarCliente(0, "Público en general");
        }

        private void btnApartar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount > 0)
            {
                if (FuncionesGenerales.Mensaje(this, Mensajes.Pregunta, "¿Deseas realizar éste apartado?", "Admin CSY") == DialogResult.Yes)
                {
                    try
                    {
                        btnApartar.Enabled = false;
                        InsertarApartado();
                        FuncionesGenerales.Mensaje(this, Mensajes.Exito, "¡Se ha creado correctamente el apartado!", "Admin CSY");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        btnApartar.Enabled = true;
                        FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al crear el apartado.", Config.shrug, ex);
                    }
                    
                }
            }
            else
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Alerta, "Debe haber al menos un producto para realizar el apartado.", "Admin CSY");
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (btnProductos.Visible || btnProductos.Enabled)
                (new frmVentaProducto(this)).ShowDialog(this);
            txtBusqueda.Select();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (btnClientes.Visible || btnClientes.Enabled)
                (new frmVentaCliente(this)).ShowDialog(this);
            txtBusqueda.Select();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtBusqueda.Text.Trim() != "")
                {
                    txtBusqueda.Text = txtBusqueda.Text.Replace("\u001f", "");
                    string[] datos = txtBusqueda.Text.Split(new char[] { '*' }, StringSplitOptions.RemoveEmptyEntries);
                    if (datos.Length > 1)
                    {
                        BusquedaProducto(datos[1].ToString(), int.Parse(datos[0]));
                    }
                    else
                    {
                        BusquedaProducto(datos[0].ToString(), 1);
                    }
                    txtBusqueda.Text = "";
                }
            }
        }

        private void frmNuevoApartado_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvProductos.CurrentRow != null && btnProductos.Visible && btnProductos.Enabled)
            {
                if (e.Control)
                {
                    if (e.KeyCode == Keys.Oemplus)
                    {
                        VerificarProducto(id, 1);
                    }
                    else if (e.KeyCode == Keys.OemMinus)
                    {
                        VerificarProducto(id, -1);
                    }
                    else if (e.KeyCode == Keys.Delete)
                    {
                        QuitarProducto();
                    }
                    return;
                }
            }
            if (!e.Control && !e.Alt && !e.Shift)
            {
                if (e.KeyCode == Keys.F1)
                {
                    btnProductos.PerformClick();
                }
                else if (e.KeyCode == Keys.F2)
                {
                    btnClientes.PerformClick();
                }
                else if (e.KeyCode == Keys.F3)
                {
                    btnApartar.PerformClick(); 
                }
            }
        }
    }
}
