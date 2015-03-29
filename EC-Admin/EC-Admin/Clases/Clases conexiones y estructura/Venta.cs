using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Venta
    {
        #region Propiedades Venta
        private int idV;

        public int IDVenta
        {
            get { return idV; }
            set { idV = value; }
        }
        private int idC;

        public int IDCliente
        {
            get { return idC; }
            set { idC = value; }
        }
        private int idS;

        public int IDSucursal
        {
            get { return idS; }
            set { idS = value; }
        }
        private int idT;

        public int IDVendedor
        {
            get { return idT; }
            set { idT = value; }
        }
        private bool cancelada;

        public bool Cancelada
        {
            get { return cancelada; }
            set { cancelada = value; }
        }
        private bool abierta;

        public bool Abierta
        {
            get { return abierta; }
            set { abierta = value; }
        }
        private decimal subtotal;

        public decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private decimal impuesto;

        public decimal Impuesto
        {
            get { return impuesto; }
            set { impuesto = value; }
        }
        private decimal descuento;

        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        private string remision;

        public string Remision
        {
            get { return remision; }
            set { remision = value; }
        }
        private string factura;

        public string Factura
        {
            get { return factura; }
            set { factura = value; }
        }
        private TipoPago tipo;

        public TipoPago Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private int createUser;

        public int CreateUser
        {
            get { return createUser; }
            set { createUser = value; }
        }
        private DateTime createTime;

        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        private int updateUser;

        public int UpdateUser
        {
            get { return updateUser; }
            set { updateUser = value; }
        }
        private DateTime updateTime;

        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
        private int cancelUser;

        public int CancelUser
        {
            get { return cancelUser; }
            set { cancelUser = value; }
        }
        private DateTime cancelTime;

        public DateTime CancelTime
        {
            get { return cancelTime; }
            set { cancelTime = value; }
        }
        #endregion

        #region Propiedades Venta Detallada
        private List<int> idP;

        public List<int> IDProductos
        {
            get { return idP; }
            set { idP = value; }
        }
        private List<decimal> cantidad;

        public List<decimal> Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private List<decimal> precio;

        public List<decimal> Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private List<decimal> descuentoP;

        public List<decimal> DescuentoProducto
        {
            get { return descuentoP; }
            set { descuentoP = value; }
        }
        private List<Unidades> unidad;

        public List<Unidades> Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }
        #endregion

        public Venta()
        {
            InicializarVenta();
            InicializarVentaDetallada();
        }

        public Venta(int idVenta)
        {
            this.idV = idVenta;
            InicializarVenta();
            InicializarVentaDetallada();
        }

        #region Métodos Venta

        private void InicializarVenta()
        {
            idC = 0;
            idV = 0;
            cancelada = false;
            abierta = true;
            subtotal = 0;
            impuesto = 0;
            descuento = 0;
            total = 0;
        }

        public void NuevaVenta()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO venta (create_user, create_time) VALUES (?create_user, NOW())";
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                idV = ConexionBD.EjecutarConsulta(sql);
                InicializarVenta();
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

        public void RecuperarVenta()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM venta WHERE id=?id";
                sql.Parameters.AddWithValue("?id", idV);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idC = (int)dr["id_cliente"];
                    idS = (int)dr["id_sucursal"];
                    idT = (int)dr["id_vendedor"];
                    cancelada = (bool)dr["cancelada"];
                    abierta = (bool)dr["abierta"];
                    subtotal = (decimal)dr["subtotal"];
                    impuesto = (decimal)dr["impuesto"];
                    descuento = (decimal)dr["descuento"];
                    total = (decimal)dr["total"];
                    remision = dr["remision"].ToString();
                    factura = dr["factura"].ToString();
                    tipo = (TipoPago)Enum.Parse(typeof(TipoPago), dr["tipo_pago"].ToString());
                    createUser = (int)dr["create_user"];
                    createTime = (DateTime)dr["create_time"];
                    if (dr["update_user"] != DBNull.Value)
                        updateUser = (int)dr["update_user"];
                    else
                        updateUser = 0;
                    if (dr["update_time"] != DBNull.Value)
                        updateTime = (DateTime)dr["update_time"];
                    else
                        updateTime = new DateTime();
                    if (dr["cancel_user"] != DBNull.Value)
                        cancelUser = (int)dr["cancel_user"];
                    else
                        cancelUser = 0;
                    if (dr["cancel_time"] != DBNull.Value)
                        cancelTime = (DateTime)dr["cancel_time"];
                    else
                        cancelTime = new DateTime();
                    RecuperarVentaDetallada();
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
        }
        #endregion

        #region Métodos Venta Detallada

        private void InicializarVentaDetallada()
        {
            idP = new List<int>();
            cantidad = new List<decimal>();
            precio = new List<decimal>();
            descuentoP = new List<decimal>();
            unidad = new List<Unidades>();
        }

        private void InsertarProductos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                for (int i = 0; i < idP.Count; i++)
                {
                    sql.CommandText = "INSERT INTO (id_venta, id_producto, cant, precio, descuento, unidad) " +
                    "VALUES (?id_venta, ?id_producto, ?cant, ?precio, ?descuento, ?unidad)";
                    sql.Parameters.AddWithValue("?id_venta", idV);
                    sql.Parameters.AddWithValue("?id_producto", idP[i]);
                    sql.Parameters.AddWithValue("?cant", cantidad[i]);
                    sql.Parameters.AddWithValue("?precio", precio[i]);
                    sql.Parameters.AddWithValue("?descuento", descuentoP[i]);
                    sql.Parameters.AddWithValue("?unidad", unidad[i]);
                    ConexionBD.EjecutarConsulta(sql);
                    sql.Parameters.Clear();
                    Producto.CambiarCantidadInventario(idP[i], decimal.Negate(cantidad[i]));
                }
                InicializarVentaDetallada();
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

        private void RecuperarVentaDetallada()
        {
            InicializarVentaDetallada();
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM venta_detallada WHERE id_venta=?id";
                sql.Parameters.AddWithValue("?id", idV);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idP.Add((int)dr["id_producto"]);
                    cantidad.Add((decimal)dr["cant"]);
                    precio.Add((decimal)dr["precio"]);
                    descuentoP.Add((decimal)dr["descuento"]);
                    unidad.Add((Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString()));
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
        }
        #endregion
    }
}
