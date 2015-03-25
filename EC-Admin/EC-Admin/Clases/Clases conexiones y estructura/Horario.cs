using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EC_Admin
{
    class Horario
    {
        #region Propiedades
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int idTrabajador;

        public int IDTrabajor
        {
            get { return idTrabajador; }
            set { idTrabajador = value; }
        }
        private bool lunes;

        public bool Lunes
        {
            get { return lunes; }
            set { lunes = value; }
        }
        private bool martes;

        public bool Martes
        {
            get { return martes; }
            set { martes = value; }
        }
        private bool miercoles;

        public bool Miercoles
        {
            get { return miercoles; }
            set { miercoles = value; }
        }
        private bool jueves;

        public bool Jueves
        {
            get { return jueves; }
            set { jueves = value; }
        }
        private bool viernes;

        public bool Viernes
        {
            get { return viernes; }
            set { viernes = value; }
        }
        private bool sabado;

        public bool Sabado
        {
            get { return sabado; }
            set { sabado = value; }
        }
        private bool domingo;

        public bool Domingo
        {
            get { return domingo; }
            set { domingo = value; }
        }
        private DateTime horaIni;

        public DateTime HoraInicio
        {
            get { return horaIni; }
            set { horaIni = value; }
        }
        private DateTime horaFin;

        public DateTime HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }        
        #endregion

        public Horario()
        {

        }

        public Horario(int id)
        {
            this.id = id;
        }

        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM horario_trabajador WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idTrabajador = (int)dr["id_trabajador"];
                    lunes = (bool)dr["lunes"];
                    martes = (bool)dr["martes"];
                    miercoles = (bool)dr["miercoles"];
                    jueves = (bool)dr["jueves"];
                    viernes = (bool)dr["viernes"];
                    sabado = (bool)dr["sabado"];
                    domingo = (bool)dr["domingo"];
                    horaIni = DateTime.Parse(new DateTime().ToString("yyyy-MM-dd") + " " + dr["hora_ini"].ToString());
                    horaFin = DateTime.Parse(new DateTime().ToString("yyyy-MM-dd") + " " + dr["hora_fin"].ToString());
                }
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
                sql.CommandText = "INSERT INTO horario_trabajador (id_trabajador, lunes, martes, miercoles, jueves, viernes, sabado, domingo, hora_ini, hora_fin) " +
                    "VALUES (?id_trabajador, ?lunes, ?martes, ?miercoles, ?jueves, ?viernes, ?sabado, ?domingo, ?hora_ini, ?hora_fin)";
                sql.Parameters.AddWithValue("?id_trabajador", idTrabajador);
                sql.Parameters.AddWithValue("?lunes", lunes);
                sql.Parameters.AddWithValue("?martes", martes);
                sql.Parameters.AddWithValue("?miercoles", miercoles);
                sql.Parameters.AddWithValue("?jueves", jueves);
                sql.Parameters.AddWithValue("?viernes", viernes);
                sql.Parameters.AddWithValue("?sabado", sabado);
                sql.Parameters.AddWithValue("?domingo", domingo);
                sql.Parameters.AddWithValue("?hora_ini", horaIni);
                sql.Parameters.AddWithValue("?hora_fin", horaFin);
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
                sql.CommandText = "UPDATE horario_trabajador SET lunes=?lunes, martes=?martes, miercoles=?miercoles, jueves=?jueves, viernes=?viernes, " +
                    "sabado=?sabado, domingo=?domingo, hora_ini=?hora_ini, hora_fin=?hora_fin WHERE id=?id";
                sql.Parameters.AddWithValue("?lunes", lunes);
                sql.Parameters.AddWithValue("?martes", martes);
                sql.Parameters.AddWithValue("?miercoles", miercoles);
                sql.Parameters.AddWithValue("?jueves", jueves);
                sql.Parameters.AddWithValue("?viernes", viernes);
                sql.Parameters.AddWithValue("?sabado", sabado);
                sql.Parameters.AddWithValue("?domingo", domingo);
                sql.Parameters.AddWithValue("?hora_ini", horaIni);
                sql.Parameters.AddWithValue("?hora_fin", horaFin);
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
