﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    class Cuenta
    {
        #region Propiedades
        private int id;
        private string clabe;
        private string banco;
        private string beneficiario;
        private string sucursal;
        private string numCuenta;
        private TipoCuenta tipoCuenta;
        private static int cant = -1;
        private static int cantProv = -1;
        private static int cantSuc = -1;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Clabe
        {
            get { return clabe; }
            set { clabe = value; }
        }

        public string Banco
        {
            get { return banco; }
            set { banco = value; }
        }

        public string Beneficiario
        {
            get { return beneficiario; }
            set { beneficiario = value; }
        }

        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

        public string NumeroCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }

        public static int Cantidad
        {
            get
            {
                if (cant < 0)
                    Cant();
                return cant;
            }
        }
       
        public TipoCuenta TipoCuenta
        {
            get { return tipoCuenta; }
            set { tipoCuenta = value; }
        }

        private int idSucursal;

        public int IDSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
        }

        public static int CantidadProv
        {
            get
            {
                if (cantProv < 0)
                    CantProveedor();
                return cantProv;
            }
        }

        public static int CantidadSuc
        {
            get
            {
                if (cantSuc < 0)
                    CantSucursal();
                return cantSuc;
            }
        }
        
        
        #endregion

        #region Cantidad

        /// <summary>
        /// Método que actualiza la cantidad de cuentas que hay en la base de datos
        /// </summary>
        private static void Cant()
        {
            try
            {
                string sql = "SELECT COUNT(id) AS c FROM cuenta";
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
        }

        private static void CantProveedor()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT COUNT(id) AS c FROM cuenta WHERE tipo=?tipo";
                sql.Parameters.AddWithValue("?tipo", TipoCuenta.Proveedor);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cantProv = int.Parse(dr["c"].ToString());
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

        private static void CantSucursal()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT COUNT(id) AS c FROM cuenta WHERE tipo=?tipo";
                sql.Parameters.AddWithValue("?tipo", TipoCuenta.Sucursal);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cantSuc = int.Parse(dr["c"].ToString());
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

        #endregion

        /// <summary>
        /// Inicializa la instancia de la clase Cuenta
        /// </summary>
        public Cuenta()
        {

        }

        /// <summary>
        /// Inicializa la instancia de la clase Cuenta con el ID asociado
        /// </summary>
        /// <param name="id">ID de la cuenta</param>
        public Cuenta(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Método que obtiene los datos de la cuenta y los guarda en las propiedades
        /// </summary>
        public void ObtenerDatos()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM cuenta WHERE id=?id";
                sql.Parameters.AddWithValue("?id", id);
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    idSucursal = (int)dr["id_sucursal"];
                    tipoCuenta = (TipoCuenta)Enum.Parse(typeof(TipoCuenta), dr["tipo"].ToString());
                    clabe = dr["clabe"].ToString();
                    banco = dr["banco"].ToString();
                    beneficiario = dr["beneficiario"].ToString();
                    sucursal = dr["sucursal"].ToString();
                    numCuenta = dr["num_cuenta"].ToString();
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
        /// Método que inserta los datos de las propiedades en la base de datos
        /// </summary>
        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO cuenta (id_sucursal, clabe, banco, beneficiario, sucursal, num_cuenta, tipo) " +
                    "VALUES (?id_sucursal, ?clabe, ?banco, ?beneficiario, ?sucursal, ?num_cuenta, ?tipo)";
                sql.Parameters.AddWithValue("?id_sucursal",Config.idSucursal);
                sql.Parameters.AddWithValue("?clabe", clabe);
                sql.Parameters.AddWithValue("?banco", banco);
                sql.Parameters.AddWithValue("?beneficiario", beneficiario);
                sql.Parameters.AddWithValue("?sucursal", sucursal);
                sql.Parameters.AddWithValue("?num_cuenta", numCuenta);
                sql.Parameters.AddWithValue("?tipo",tipoCuenta);
                this.id = ConexionBD.EjecutarConsulta(sql);
                Cant();
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
        /// Método que modifica los datos de la base de datos con los datos de las propiedades
        /// </summary>
        public void Editar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "UPDATE cuenta SET id_sucursal=?id_sucursal, clabe=?clabe, banco=?banco, beneficiario=?beneficiario, " +
                    "sucursal=?sucursal, num_cuenta=?num_cuenta WHERE id=?id";
                sql.Parameters.AddWithValue("?id_sucursal",Config.idSucursal);
                sql.Parameters.AddWithValue("?clabe", clabe);
                sql.Parameters.AddWithValue("?banco", banco);
                sql.Parameters.AddWithValue("?beneficiario", beneficiario);
                sql.Parameters.AddWithValue("?sucursal", sucursal);
                sql.Parameters.AddWithValue("?num_cuenta", numCuenta);
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
