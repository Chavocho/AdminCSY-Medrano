using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    public class Paquete
    {
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
        private int cant;

        public int Cantidad
        {
            get { return cant; }
            set { cant = value; }
        }
        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Paquete()
        {

        }

        public Paquete(int id)
        {
            this.ID = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM paquete WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    
                }
            }
            catch (MySqlException ex)
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
