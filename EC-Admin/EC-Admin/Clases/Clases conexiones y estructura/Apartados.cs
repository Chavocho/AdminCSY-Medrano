using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EC_Admin
{
    public class Apartados
    {
        #region Propiedades
        private int id;
        private int idSucursal;
        private int idCliente;
        private EstadoApartado estado;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;
        private List<int> idProductos;
        private List<int> cantProductos;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
        }

        public int IDCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public EstadoApartado Estado
        {
            get { return estado; }
            set { estado = value; }
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
            set { updateTime = value; }
        }

        public List<int> IDProductos
        {
            get { return idProductos; }
            set { idProductos = value; }
        }

        public List<int> CantProductos
        {
            get { return cantProductos; }
            set { cantProductos = value; }
        }
        #endregion

        public Apartados()
        {
            idProductos = new List<int>();
            cantProductos = new List<int>();
        }

        public Apartados(int id)
        {
            this.ID = id;
            idProductos = new List<int>();
            cantProductos = new List<int>();
        }

        async public Task ObtenerDatosAsync()
        {
            try
            {
                Task t = new Task(() =>
                {
                    MySqlCommand sql = new MySqlCommand();
                    sql.CommandText = "SELECT * FROM apartado WHERE id=?id";
                    sql.Parameters.AddWithValue("?id", id);
                    DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                    foreach (DataRow dr in dt.Rows)
                    {
                        idSucursal = (int)dr["id_sucursal"];
                        idCliente = (int)dr["id_cliente"];
                        estado = (EstadoApartado)Enum.Parse(typeof(EstadoApartado), dr["estado"].ToString());
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
                    }
                    ObtenerDetallado();
                });
                t.Start();
                await t;
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

        private void ObtenerDetallado()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM apartado_detallado WHERE id_apartado=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idProductos.Add((int)dr["id_producto"]);
                    cantProductos.Add((int)dr["cant"]);
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

        private int UltimoID()
        {
            int id = 0;
            try
            {
                string sql = "SELECT MAX(id) AS id FROM apartado WHERE id_sucursal='" + Config.idSucursal + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["id"] != DBNull.Value)
                        id = (int)dr["id"] + 1;
                    else
                        id = 1;
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
            return id;
        }

        async public Task InsertarAsync()
        {
            try
            {
                Task t = new Task(() =>
                {
                    id = UltimoID();
                    MySqlCommand sql = new MySqlCommand();
                    sql.CommandText = "INSERT INTO apartado (id, id_sucursal, id_cliente, estado, create_user, create_time) " +
                        "VALUES (?id, ?id_sucursal, ?id_cliente, ?estado, ?create_user, NOW())";
                    sql.Parameters.AddWithValue("?id", id);
                    sql.Parameters.AddWithValue("?id_sucursal", Config.idSucursal);
                    sql.Parameters.AddWithValue("?id_cliente", IDCliente);
                    sql.Parameters.AddWithValue("?estado", EstadoApartado.Espera);
                    sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                    ConexionBD.EjecutarConsulta(sql);
                    InsertarDetallado();
                });
                t.Start();
                await t;
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
                sql.CommandText = "INSERT INTO apartado_detallado (id_apartado, id_producto, cant) VALUES (?id_apartado, ?id_producto, ?cant)";
                for (int i = 0; i < IDProductos.Count; i++)
                {
                    sql.Parameters.AddWithValue("?id_apartado", id);
                    sql.Parameters.AddWithValue("?id_producto", idProductos[i]);
                    sql.Parameters.AddWithValue("?cant", cantProductos[i]);
                    ConexionBD.EjecutarConsulta(sql);
                    Inventario.CambiarCantidadInventario(idProductos[i], cantProductos[i] * -1, Config.idSucursal);
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

        async public static Task CambiarEstado(int id, EstadoApartado e)
        {
            try
            {
                Task t = new Task(async () =>
                {
                    MySqlCommand sql = new MySqlCommand();
                    sql.CommandText = "UPDATE apartado SET estado=?estado, update_user=?update_user, update_time=NOW() WHERE id=?id AND id_sucursal=?id_sucursal";
                    sql.Parameters.AddWithValue("?estado", e);
                    sql.Parameters.AddWithValue("?update_user", Usuario.IDUsuarioActual);
                    sql.Parameters.AddWithValue("?id", id);
                    sql.Parameters.AddWithValue("?id_sucursal", Config.idSucursal);
                    ConexionBD.EjecutarConsulta(sql);
                    if (e == EstadoApartado.Cancelada)
                    {
                        Apartados a = new Apartados(id);
                        await a.ObtenerDatosAsync();
                        for (int i = 0; i < a.IDProductos.Count; i++)
                        {
                            Inventario.CambiarCantidadInventario(a.IDProductos[i], a.CantProductos[i], Config.idSucursal);
                        }
                    }
                });
                t.Start();
                await t;
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
