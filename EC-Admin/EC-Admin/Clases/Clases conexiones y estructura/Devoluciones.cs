using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Devoluciones
    {
        #region Propiedades
        private int id;
        private int idVenta;
        private decimal total;
        private decimal saldo;
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

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
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
        private List<decimal> cantidadProductos;

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

        public List<decimal> CantidadProductos
        {
            get { return cantidadProductos; }
            set { cantidadProductos = value; }
        }
        #endregion

        private void InicializarDetallada()
        {
            idProductos = new List<int>();
            precioProductos = new List<decimal>();
            cantidadProductos = new List<decimal>();
        }

        public Devoluciones()
        {

        }

        public Devoluciones(int id)
        {
            this.id = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM devolucion WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idVenta = (int)dr["id_venta"];
                    total = (decimal)dr["total"];
                    saldo = (decimal)dr["saldo"];
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

        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO devolucion (id_venta, total, saldo, create_user, create_time) " + 
                    "VALUES (?id_venta, ?total, ?saldo, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_venta", idVenta);
                sql.Parameters.AddWithValue("?total", total);
                sql.Parameters.AddWithValue("?saldo", saldo);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                this.id = ConexionBD.EjecutarConsulta(sql);
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

        private void InsertarDetallado()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO devolucion_detallada (id_devolucion, id_producto, precio, cant) " + 
                    "VALUES (?id_devolucion, ?id_producto, ?precio, ?cant)";
                for (int i = 0; i < idProductos.Count; i++)
                {
                    sql.Parameters.AddWithValue("?id_devolucion", id);
                    sql.Parameters.AddWithValue("?id_producto", idProductos[i]);
                    sql.Parameters.AddWithValue("?precio", precioProductos[i]);
                    sql.Parameters.AddWithValue("?cant", cantidadProductos[i]);
                    ConexionBD.EjecutarConsulta(sql);
                    sql.Parameters.Clear();
                    Producto.CambiarCantidadInventario(idProductos[i], cantidadProductos[i]);
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

        public static decimal SaldoDevolucion(int id)
        {
            decimal saldo = 0M;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT saldo FROM devolucion WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    saldo = (decimal)dr["saldo"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return saldo;
        }

        public static void CambiarSaldo(int id, decimal saldo)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE devolucion SET saldo=saldo+?saldo, update_user=?update_user, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?saldo", saldo);
                sql.Parameters.AddWithValue("?update_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
