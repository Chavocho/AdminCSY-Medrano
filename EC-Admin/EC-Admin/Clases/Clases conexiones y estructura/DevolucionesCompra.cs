using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace EC_Admin
{
    class DevolucionesCompra
    {
        #region Propiedades
        private int id;
        private int idVenta;
        private decimal total;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public int CreateUser
        {
            get { return createUser; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
        }

        public int UpdateUser
        {
            get { return updateUser; }
        }

        public DateTime UpdateTime
        {
            get { return updateTime; }
        }

        private List<int> idProductos;
        private List<decimal> precioProductos;
        private List<int> cantidadProductos;

        public List<int> IDProductos
        {
            get { return idProductos; }
            set { idProductos = value; }
        }

        public List<decimal> PrecioProductos
        {
            get { return precioProductos; }
            set { precioProductos = value; }
        }

        public List<int> CantidadProductos
        {
            get { return cantidadProductos; }
            set { cantidadProductos = value; }
        }
        #endregion

        /// <summary>
        /// Inicializa las propiedades de la devolución detallada
        /// </summary>
        private void InicializarDetallada()
        {
            idProductos = new List<int>();
            precioProductos = new List<decimal>();
            cantidadProductos = new List<int>();
        }

        /// <summary>
        /// Inicializa la instancia de la clase Devoluciones
        /// </summary>
        public DevolucionesCompra()
        {
            InicializarDetallada();
        }

        /// <summary>
        /// Inicializa la instancia de la clase Devoluciones
        /// </summary>
        /// <param name="id">ID de la devolución</param>
        public DevolucionesCompra(Compra c, int id)
        {
            this.id = id;
            InicializarDetallada();
        }

        /// <summary>
        /// Obtiene los datos de la devolución de la base de datos
        /// </summary>
        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM devolucionp WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idVenta = (int)dr["id_venta"];
                    total = (decimal)dr["total"];
                    createUser = (int)dr["create_user"];
                    createTime = (DateTime)dr["create_time"];
                    if (dr["update_user"] != DBNull.Value)
                        updateUser = (int)dr["update_user"];
                    else
                        updateUser = 0;
                    if (dr["update_time"] != DBNull.Value)
                        updateTime = (DateTime)dr["update_user"];
                    else
                        updateTime = new DateTime();
                }
                ObtenerDatosDetallada();
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

        /// <summary>
        /// Obtiene los datos de la devolución detallada
        /// </summary>
        private void ObtenerDatosDetallada()
        {
            InicializarDetallada();
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM devolucion_detallada WHERE id_devolucion=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idProductos.Add((int)dr["id_producto"]);
                    precioProductos.Add((decimal)dr["precio"]);
                    cantidadProductos.Add((int)dr["cant"]);
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

        /// <summary>
        /// Inserta los datos de las propiedades en la base de datos
        /// </summary>
        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO devolucionp (id_venta, total, create_user, create_time) " +
                    "VALUES (?id_venta, ?total, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_venta", idVenta);
                sql.Parameters.AddWithValue("?total", total);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                this.id = ConexionBD.EjecutarConsulta(sql);
                InsertarDetallado();
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

        /// <summary>
        /// Inserta los datos de las propiedades de la compra detallada en la base de datos
        /// </summary>
        private void InsertarDetallado()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand(), sqlVenta = new MySqlCommand();
                sql.CommandText = "INSERT INTO devolucionp_detallada (id_devolucion, id_producto, precio, cant) " +
                    "VALUES (?id_devolucion, ?id_producto, ?precio, ?cant)";
                for (int i = 0; i < idProductos.Count; i++)
                {
                    sql.Parameters.AddWithValue("?id_devolucion", id);
                    sql.Parameters.AddWithValue("?id_producto", idProductos[i]);
                    sql.Parameters.AddWithValue("?precio", precioProductos[i]);
                    sql.Parameters.AddWithValue("?cant", cantidadProductos[i]);
                    ConexionBD.EjecutarConsulta(sql);
                    sql.Parameters.Clear();
                    Inventario.CambiarCantidadInventario(idProductos[i], cantidadProductos[i] * -1, Config.idSucursal);
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

    }
}
