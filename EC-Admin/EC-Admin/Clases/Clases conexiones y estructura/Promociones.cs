using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Promociones
    {
        #region Propiedades
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int idProducto;

        public int IDProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        private bool existencias;

        public bool Existencias
        {
            get { return existencias; }
            set { existencias = value; }
        }
        private DateTime fechaIni;

        public DateTime FechaInicio
        {
            get { return fechaIni; }
            set { fechaIni = value; }
        }
        private DateTime fechaFin;

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }
        private decimal cantidad;

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        #endregion

        #region Cantidades
        public static int CantidadPromociones(int idProducto)
        {
            int cant = 0;
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM promocion WHERE id_producto='" + idProducto + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cant = int.Parse(dr["c"].ToString());
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
            return cant;
        }
        #endregion

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM promocion WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idProducto = (int)dr["id_producto"];
                    existencias = (bool)dr["existencias"];
                    fechaIni = (DateTime)dr["fecha_ini"];
                    fechaFin = (DateTime)dr["fecha_fin"];
                    cantidad = (decimal)dr["cant"];
                    precio = (decimal)dr["precio"];
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
                sql.CommandText = "INSERT INTO promocion (id_producto, existencias, fecha_ini, fecha_fin, cant, precio) " +
                    "VALUES (?id_producto, ?existencias, ?fecha_ini, ?fecha_fin, ?cant, ?precio)";
                sql.Parameters.AddWithValue("?id_producto", idProducto);
                sql.Parameters.AddWithValue("?existencias", existencias);
                if (fechaIni != new DateTime())
                    sql.Parameters.AddWithValue("?fecha_ini", fechaIni);
                else
                    sql.Parameters.AddWithValue("?fecha_ini", DBNull.Value);
                if (fechaFin != new DateTime())
                    sql.Parameters.AddWithValue("?fecha_fin", fechaFin);
                else
                    sql.Parameters.AddWithValue("?fecha_fin", DBNull.Value);
                sql.Parameters.AddWithValue("?cant", cantidad);
                sql.Parameters.AddWithValue("?precio", precio);
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

        public void Editar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE promocion SET id_producto=?id_producto, existencia=?existencias, fecha_ini=?fecha_ini, " + 
                    "fecha_fin=?fecha_fin, cant=?cant, precio=?precio WHERE id=?id";
                sql.Parameters.AddWithValue("?id_producto", idProducto);
                sql.Parameters.AddWithValue("?existencias", existencias);
                if (fechaIni != new DateTime())
                    sql.Parameters.AddWithValue("?fecha_ini", fechaIni);
                else
                    sql.Parameters.AddWithValue("?fecha_ini", DBNull.Value);
                if (fechaFin != new DateTime())
                    sql.Parameters.AddWithValue("?fecha_fin", fechaFin);
                else
                    sql.Parameters.AddWithValue("?fecha_fin", DBNull.Value);
                sql.Parameters.AddWithValue("?cant", cantidad);
                sql.Parameters.AddWithValue("?precio", precio);
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

        public static void Eliminar(int id)
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "DELETE FROM promocion WHERE id=?id";
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
