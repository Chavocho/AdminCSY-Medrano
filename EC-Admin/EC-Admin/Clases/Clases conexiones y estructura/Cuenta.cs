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
        #endregion

        public Cuenta()
        {

        }

        public Cuenta(int id)
        {
            this.id = id;
        }

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

        public void Insertar()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO cuenta (clabe, banco, beneficiario, sucursal, num_cuenta) " +
                    "VALUES (?clabe, ?banco, ?beneficiario, ?sucursal, ?num_cuenta)";
                sql.Parameters.AddWithValue("?clabe", clabe);
                sql.Parameters.AddWithValue("?banco", banco);
                sql.Parameters.AddWithValue("?beneficiario", beneficiario);
                sql.Parameters.AddWithValue("?sucursal", sucursal);
                sql.Parameters.AddWithValue("?num_cuenta", numCuenta);
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
                sql.CommandText = "UPDATE cuenta SET clabe=?clabe, banco=?banco, beneficiario=?beneficiario, " +
                    "sucursal=?sucursal, num_cuenta=?num_cuenta WHERE id=?id";
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
