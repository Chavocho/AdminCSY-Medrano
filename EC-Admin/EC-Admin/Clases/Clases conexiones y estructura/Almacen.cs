using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Almacen
    {
        #region Propiedades
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int idTrabajador;

        public int IDTrabajador
        {
            get { return idTrabajador; }
            set { idTrabajador = value; }
        }
        private int numAlm;

        public int NumeroAlmacen
        {
            get { return numAlm; }
            set { numAlm = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private int idSucursal;

        public int IDSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
        }
        #endregion

        public Almacen()
        {

        }

        public Almacen(int id)
        {
            this.ID = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM almacen WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idTrabajador = (int)dr["id_trabajador"];
                    numAlm = (int)dr["num_alm"];
                    descripcion = dr["descripcion"].ToString();
                    idSucursal = (int)dr["id_sucursal"];
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
                sql.CommandText = "INSERT INTO almacen (id_trabajador, num_alm, descripcion, id_sucursal) VALUES (?id_trabajador, ?num_alm, ?descripcion, ?id_sucursal)";
                sql.Parameters.AddWithValue("?id_trabajador", idTrabajador);
                sql.Parameters.AddWithValue("?num_alm", numAlm);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
                sql.Parameters.AddWithValue("?id_sucursal", idSucursal);
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
                sql.CommandText = "UPDATE almacen SET id_trabajador=?id_trabajador, num_alm=?num_alm, descripcion=?descripcion, id_sucursal=?id_sucursal WHERE id=?id";
                sql.Parameters.AddWithValue("?id_trabajador", idTrabajador);
                sql.Parameters.AddWithValue("?num_alm", numAlm);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
                sql.Parameters.AddWithValue("?id_sucursal", idSucursal);
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
    }
}
