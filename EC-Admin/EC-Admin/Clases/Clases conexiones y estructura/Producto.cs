using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EC_Admin
{
    class Producto
    {
        #region Propiedades
        private int id;
        private int idProveedor;
        private int idAlmacen;
        private int idCategoria;
        private string nombre;
        private string marca;
        private string codigo;
        private string descripcion01;
        private string descripcion02;
        private decimal costo;
        private decimal precio;
        private decimal cantidad;
        private decimal precioMedioMayoreo;
        private decimal precioMayoreo;
        private decimal cantidadMedioMayoreo;
        private decimal cantidadMayoreo;
        private Unidades unidad;
        private Image imagen;
        private bool eliminado;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;
        private int deleteUser;
        private DateTime deleteTime;
        private static int cantP = -1;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int IDProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        public int IDAlmacen
        {
            get { return idAlmacen; }
            set { idAlmacen = value; }
        }

        public int IDCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descripcion01
        {
            get { return descripcion01; }
            set { descripcion01 = value; }
        }

        public string Descripcion02
        {
            get { return descripcion02; }
            set { descripcion02 = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal PrecioMedioMayoreo
        {
            get { return precioMedioMayoreo; }
            set { precioMedioMayoreo = value; }
        }

        public decimal PrecioMayoreo
        {
            get { return precioMayoreo; }
            set { precioMayoreo = value; }
        }

        public decimal CantidadMedioMayoreo
        {
            get { return cantidadMedioMayoreo; }
            set { cantidadMedioMayoreo = value; }
        }

        public decimal CantidadMayoreo
        {
            get { return cantidadMayoreo; }
            set { cantidadMayoreo = value; }
        }

        public Unidades Unidad
        {
            get { return unidad; }
            set { unidad = value; }
        }

        public Image Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public bool Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
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

        public int DeleteUser
        {
            get { return deleteUser; }
        }

        public DateTime DeleteTime
        {
            get { return deleteTime; }
        }

        public static int CantidadP
        {
            get
            {
                if (cantP < 0)
                    CantP();
                return cantP;
            }
        }

        private static void CantP()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM producto WHERE eliminado=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cantP = int.Parse(dr["c"].ToString());
                    else
                        cantP = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        public Producto()
        {

        }

        public Producto(int id)
        {
            this.ID = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM producto WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idProveedor = (int)dr["proveedor_id"];
                    idAlmacen = (int)dr["almacen_id"];
                    idCategoria = (int)dr["categoria"];
                    nombre = dr["nombre"].ToString();
                    marca = dr["marca"].ToString();
                    codigo = dr["codigo"].ToString();
                    descripcion01 = dr["descripcion1"].ToString();
                    descripcion02 = dr["descripcion2"].ToString();
                    costo = (decimal)dr["costo"];
                    precio = (decimal)dr["precio"];
                    cantidad = (decimal)dr["cant"];
                    precioMedioMayoreo = (decimal)dr["precio_mediomayoreo"];
                    precioMayoreo = (decimal)dr["precio_mayoreo"];
                    cantidadMedioMayoreo = (decimal)dr["cant_mediomayoreo"];
                    cantidadMayoreo = (decimal)dr["cant_mayoreo"];
                    unidad = (Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString());
                    if (dr["imagen"] != DBNull.Value)
                        imagen = FuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
                    else
                        imagen = null;
                    eliminado = (bool)dr["eliminado"];
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
                    if (dr["delete_user"] != DBNull.Value)
                        deleteUser = (int)dr["delete_user"];
                    else
                        deleteUser = 0;
                    if (dr["delete_time"] != DBNull.Value)
                        deleteTime = (DateTime)dr["delete_time"];
                    else
                        deleteTime = new DateTime();
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
                sql.CommandText = "INSERT INTO producto (proveedor_id, almacen_id, categoria, nombre, marca, codigo, descripcion1, descripcion2, costo, precio, cant, precio_mediomayoreo, precio_mayoreo, cant_mediomayoreo, cant_mayoreo, unidad, imagen, create_user, create_time) " +
                    "VALUES (?proveedor_id, ?almacen_id, ?categoria, ?nombre, ?marca, ?codigo, ?descripcion1, ?descripcion2, ?costo, ?precio, ?cant, ?precio_mediomayoreo, ?precio_mayoreo, ?cant_mediomayoreo, ?cant_mayoreo, ?unidad, ?imagen, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?proveedor_id", idProveedor);
                sql.Parameters.AddWithValue("?almacen_id", idAlmacen);
                sql.Parameters.AddWithValue("?categoria", idCategoria);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?marca", marca);
                sql.Parameters.AddWithValue("?codigo", codigo);
                sql.Parameters.AddWithValue("?descripcion1", descripcion01);
                sql.Parameters.AddWithValue("?descripcion2", descripcion02);
                sql.Parameters.AddWithValue("?costo", costo);
                sql.Parameters.AddWithValue("?precio", precio);
                sql.Parameters.AddWithValue("?cant", cantidad);
                sql.Parameters.AddWithValue("?precio_mediomayoreo", precioMedioMayoreo);
                sql.Parameters.AddWithValue("?precio_mayoreo", precioMayoreo);
                sql.Parameters.AddWithValue("?cant_mediomayoreo", cantidadMedioMayoreo);
                sql.Parameters.AddWithValue("?cant_mayoreo", cantidadMayoreo);
                sql.Parameters.AddWithValue("?unidad", unidad);
                sql.Parameters.AddWithValue("?imagen", FuncionesGenerales.ImagenBytes(imagen));
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                ConexionBD.EjecutarConsulta(sql);
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

        public void Editar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE producto SET proveedor_id=?proveedor_id, almacen_id=?almacen_id, categoria=?categoria, nombre=?nombre, marca=?marca, codigo=?codigo, descripcion1=?descripcion1, descripcion2=?descripcion2, costo=?costo, precio=?precio, cant=?cant, " +
                    "precio_mediomayoreo=?precio_mediomayoreo, precio_mayoreo=?precio_mayoreo, cant_mediomayoreo=?cant_mediomayoreo, cant_mayoreo=?cant_mayoreo, unidad=?unidad, imagen=?imagen, update_user=?update_user, update_time=NOW() WHERE id=?id"; 
                sql.Parameters.AddWithValue("?proveedor_id", idProveedor);
                sql.Parameters.AddWithValue("?almacen_id", idAlmacen);
                sql.Parameters.AddWithValue("?categoria", idCategoria);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?marca", marca);
                sql.Parameters.AddWithValue("?codigo", codigo);
                sql.Parameters.AddWithValue("?descripcion1", descripcion01);
                sql.Parameters.AddWithValue("?descripcion2", descripcion02);
                sql.Parameters.AddWithValue("?costo", costo);
                sql.Parameters.AddWithValue("?precio", precio);
                sql.Parameters.AddWithValue("?cant", cantidad);
                sql.Parameters.AddWithValue("?precio_mediomayoreo", precioMedioMayoreo);
                sql.Parameters.AddWithValue("?precio_mayoreo", precioMayoreo);
                sql.Parameters.AddWithValue("?cant_mediomayoreo", cantidadMedioMayoreo);
                sql.Parameters.AddWithValue("?cant_mayoreo", cantidadMayoreo);
                sql.Parameters.AddWithValue("?unidad", unidad);
                sql.Parameters.AddWithValue("?imagen", FuncionesGenerales.ImagenBytes(imagen));
                sql.Parameters.AddWithValue("?update_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
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

        public static void CambiarEstado(int id, bool estado)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE producto SET eliminado=?estado, delete_user=?delete_user, delete_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?estado", estado);
                sql.Parameters.AddWithValue("?delete_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
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

        public static void CambiarCantidadInventario(int id, decimal cant)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE producto SET cant=?cant WHERE id=?id";
                sql.Parameters.AddWithValue("?cant", cant);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
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

        public static Image ImagenProducto(int id)
        {
            Image img = null;
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT imagen FROM producto WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["imagen"] != DBNull.Value)
                        img = FuncionesGenerales.BytesImagen((byte[])dr["imagen"]);
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
            return img;
        }

    }
}
