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
        private int cantidad;
        private decimal precioMedioMayoreo;
        private decimal precioMayoreo;
        private int cantidadMedioMayoreo;
        private int cantidadMayoreo;
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

        public int Cantidad
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

        public int CantidadMedioMayoreo
        {
            get { return cantidadMedioMayoreo; }
            set { cantidadMedioMayoreo = value; }
        }

        public int CantidadMayoreo
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

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
