﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Proveedor : Persona
    {
        #region Propiedades
        private int id;
        private int sucursal;
        private string nombre;
        private string razonSocial;
        private string rfc;
        private string calle;
        private string numExt;
        private string numInt;
        private string colonia;
        private string ciudad;
        private string estado;
        private int cp;
        private string telefono01;
        private string telefono02;
        private string correo;
        private string lada01;
        private string lada02;
        private TipoPersona tipo;
        private decimal limiteCredito;
        private bool eliminado;
        private int createUser;
        private DateTime createTime;
        private int updateUser;
        private DateTime updateTime;
        private int deleteUser;
        private DateTime deleteTime;
        private static int cant = -1;
        private static int cantCred = -1;
        private static int cantSinCred = -1;

        public override int ID
        {
            get { return id; }
            set
            {
                id = value;
                contacto = new ProveedorContacto(value);
            }
        }

        public override int Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

        public override string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public override string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        public override string RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }

        public override string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public override string NumExt
        {
            get { return numExt; }
            set { numExt = value; }
        }

        public override string NumInt
        {
            get { return numInt; }
            set { numInt = value; }
        }

        public override string Colonia
        {
            get { return colonia; }
            set { colonia = value; }
        }

        public override string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public override string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public override int CP
        {
            get { return cp; }
            set { cp = value; }
        }

        public override string Telefono01
        {
            get { return telefono01; }
            set { telefono01 = value; }
        }

        public override string Telefono02
        {
            get { return telefono02; }
            set { telefono02 = value; }
        }

        public override string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public override string Lada01
        {
            get { return lada01; }
            set { lada01 = value; }
        }

        public override string Lada02
        {
            get { return lada02; }
            set { lada02 = value; }
        }

        public override TipoPersona Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public decimal LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }
        
        public override bool Eliminado
        {
            get { return eliminado; }
        }

        public override int CreateUser
        {
            get { return createUser; }
        }

        public override DateTime CreateTime
        {
            get { return createTime; }
        }

        public override int UpdateUser
        {
            get { return updateUser; }
        }

        public override DateTime UpdateTime
        {
            get { return updateTime; }
        }

        public override int DeleteUser
        {
            get { return deleteUser; }
        }

        public override DateTime DeleteTime
        {
            get { return deleteTime; }
        }

        /// <summary>
        /// Obtiene el total de proveedores
        /// </summary>
        public static int Cantidad
        {
            get
            {
                if (cant < 0)
                    Cant();
                return cant;
            }
        }

        /// <summary>
        /// Obtiene el total de proveedores con crédito
        /// </summary>
        public static int CantidadCredito
        {
            get
            {
                if (cantCred < 0)
                    CantProveedoresCredito();
                return cantCred;
            }
        }

        /// <summary>
        /// Obtiene el total de proveedores sin crédito
        /// </summary>
        public static int CantidadSinCredito
        {
            get
            {
                if (cantSinCred < 0)
                    CantProveedoresSinCredito();
                return cantSinCred;
            }
        }

        private ProveedorContacto contacto;

        public ProveedorContacto Contacto
        {
            get { return contacto; }
        }
        
        #endregion

        private static void ActualizarCantidades()
        {
            Cant();
            CantProveedoresCredito();
            CantProveedoresSinCredito();
        }

        /// <summary>
        /// Inicializa la instancia de la clase Proveedor
        /// </summary>
        public Proveedor()
        {

        }

        /// <summary>
        /// Inicializa la instancia de la clase Proveedor con el ID especificado
        /// </summary>
        /// <param name="id">ID del proveedor</param>
        public Proveedor(int id)
        {
            this.ID = id;
        }

        /// <summary>
        /// Método que obtiene la cantidad de proveedores
        /// </summary>
        private static void Cant()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM proveedor WHERE eliminado=0;";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cant = int.Parse(dr["c"].ToString());
                    else
                        cant = 0;
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
        /// Método que obtiene la cantidad de proveedores con crédito
        /// </summary>
        private static void CantProveedoresCredito()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT COUNT(id) AS c FROM proveedor WHERE tipo=?tipo AND eliminado=0;";
                sql.Parameters.AddWithValue("?tipo", TipoPersona.Credito);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cantSinCred = int.Parse(dr["c"].ToString());
                    else
                        cantSinCred = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que obtiene la cantidad de proveedores sin crédito
        /// </summary>
        private static void CantProveedoresSinCredito()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT COUNT(id) AS c FROM proveedor WHERE tipo=?tipo AND eliminado=0;";
                sql.Parameters.AddWithValue("?tipo", TipoPersona.SinCredito);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["c"] != DBNull.Value)
                        cantSinCred = int.Parse(dr["c"].ToString());
                    else
                        cantSinCred = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los datos de un proveedor según su ID
        /// </summary>
        public override void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM proveedor WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    sucursal = (int)dr["sucursal_id"];
                    nombre = dr["nombre"].ToString();
                    razonSocial = dr["razon_social"].ToString();
                    rfc = dr["rfc"].ToString();
                    calle = dr["calle"].ToString();
                    numExt = dr["num_ext"].ToString();
                    numInt = dr["num_int"].ToString();
                    colonia = dr["colonia"].ToString();
                    ciudad = dr["ciudad"].ToString();
                    estado = dr["estado"].ToString();
                    cp = (int)dr["cp"];
                    telefono01 = dr["telefono1"].ToString();
                    telefono02 = dr["telefono2"].ToString();
                    correo = dr["email"].ToString();
                    lada01 = dr["lada1"].ToString();
                    lada02 = dr["lada2"].ToString();
                    tipo = (TipoPersona)Enum.Parse(typeof(TipoPersona), dr["tipo"].ToString());
                    limiteCredito = (decimal)dr["limite_credito"];
                    eliminado = bool.Parse(dr["eliminado"].ToString());
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inserta un nuevo proveedor con los datos de la base de datos
        /// </summary>
        public override void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO proveedor (sucursal_id, nombre, razon_social, rfc, calle, num_ext, num_int, colonia, ciudad, estado, cp, telefono1, telefono2, email, lada1, lada2, tipo, limite_credito, create_user, create_time) " +
                    "VALUES (?sucursal_id, ?nombre, ?razon_social, ?rfc, ?calle, ?num_ext, ?num_int, ?colonia, ?ciudad, ?estado, ?cp, ?telefono1, ?telefono2, ?email, ?lada1, ?lada2, ?tipo, ?limite_credito, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?sucursal_id", sucursal);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?razon_social", razonSocial);
                sql.Parameters.AddWithValue("?rfc", rfc);
                sql.Parameters.AddWithValue("?calle", calle);
                sql.Parameters.AddWithValue("?num_ext", numExt);
                sql.Parameters.AddWithValue("?num_int", numInt);
                sql.Parameters.AddWithValue("?colonia", colonia);
                sql.Parameters.AddWithValue("?ciudad", ciudad);
                sql.Parameters.AddWithValue("?estado", estado);
                sql.Parameters.AddWithValue("?cp", cp);
                sql.Parameters.AddWithValue("?telefono1", telefono01);
                sql.Parameters.AddWithValue("?telefono2", telefono02);
                sql.Parameters.AddWithValue("?email", correo);
                sql.Parameters.AddWithValue("?lada1", lada01);
                sql.Parameters.AddWithValue("?lada2", lada02);
                sql.Parameters.AddWithValue("?tipo", tipo);
                sql.Parameters.AddWithValue("?limite_credito", limiteCredito);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                ConexionBD.EjecutarConsulta(sql);
                ActualizarCantidades();
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
        /// Edita un proveedor con los datos de las propiedades según su ID
        /// </summary>
        public override void Editar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE proveedor SET sucursal_id=?sucursal_id, nombre=?nombre, razon_social=?razon_social, rfc=?rfc, calle=?calle, num_ext=?num_ext, num_int=?num_int, colonia=?colonia, ciudad=?ciudad, " +
                    "estado=?estado, cp=?cp, telefono1=?telefono1, telefono2=?telefono2, email=?email, lada1=?lada1, lada2=?lada2, tipo=?tipo, limite_credito=?limite_credito, update_user=?update_user, update_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?sucursal_id", sucursal);
                sql.Parameters.AddWithValue("?nombre", nombre);
                sql.Parameters.AddWithValue("?razon_social", razonSocial);
                sql.Parameters.AddWithValue("?rfc", rfc);
                sql.Parameters.AddWithValue("?calle", calle);
                sql.Parameters.AddWithValue("?num_ext", numExt);
                sql.Parameters.AddWithValue("?num_int", numInt);
                sql.Parameters.AddWithValue("?colonia", colonia);
                sql.Parameters.AddWithValue("?ciudad", ciudad);
                sql.Parameters.AddWithValue("?estado", estado);
                sql.Parameters.AddWithValue("?cp", cp);
                sql.Parameters.AddWithValue("?telefono1", telefono01);
                sql.Parameters.AddWithValue("?telefono2", telefono02);
                sql.Parameters.AddWithValue("?email", correo);
                sql.Parameters.AddWithValue("?lada1", lada01);
                sql.Parameters.AddWithValue("?lada2", lada02);
                sql.Parameters.AddWithValue("?tipo", tipo);
                sql.Parameters.AddWithValue("?limite_credito", limiteCredito);
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

        /// <summary>
        /// Oculta o muestra a un proveedor de las búsquedas
        /// </summary>
        /// <param name="id">ID del proveedor a cambiar su estado</param>
        /// <param name="eliminar">Valor booleano que indica si se ocultará o mostrará el proveedor</param>
        public static void CambiarEstado(int id, bool eliminar)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE proveedor SET eliminado=?eliminado, delete_user=?delete_user, delete_time=NOW() WHERE id=?id";
                sql.Parameters.AddWithValue("?eliminado", eliminar);
                sql.Parameters.AddWithValue("?delete_user", Usuario.IDUsuarioActual);
                sql.Parameters.AddWithValue("?id", id);
                ConexionBD.EjecutarConsulta(sql);
                ActualizarCantidades();
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
