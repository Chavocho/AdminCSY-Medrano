using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC_Admin
{
    public class Banco
    {
        
        #region Propiedades Banco
        private int id;
        private int idSucursal;
        private decimal voucher;
        private string descripcion;
        private MovimientoCaja tipoMovimiento;
        private int create_user;
        private DateTime createTime;
        private static bool estadoCaja;

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

        public decimal Voucher
        {
            get { return voucher; }
            set { voucher = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public MovimientoCaja TipoMovimiento
        {
            get { return tipoMovimiento; }
            set { tipoMovimiento = value; }
        }

        public int CreateUser
        {
            get { return create_user; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
        }
        #endregion

        #region Totales Banco
        private static decimal totalVou = -1;

        /// <summary>
        /// Obtiene el total de los vouchers que hay actualmente en banco
        /// </summary>
        public static decimal TotalVouchers
        {
            get
            {
                if (totalVou < 0)
                    Totales();
                return totalVou;
            }
        }
        
        /// <summary>
        /// Método que obtiene los totales de caja
        /// </summary>
        private static void Totales()
        {
            try
            {
                string sql = "SELECT SUM(voucher) AS v FROM banco WHERE id_sucursal='" + Config.idSucursal.ToString() + "'";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["v"] != DBNull.Value)
                        totalVou = (decimal)dr["v"];
                    else
                        totalVou = 0M;

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
        /// Inicializa la instancia de la clase Banco
        /// </summary>
        public Banco()
        {

        }

        /// <summary>
        /// Método que inserta un nuevo movimiento en la base de datos con los datos de las propiedades
        /// </summary>
        public void RegistrarMovimiento()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "INSERT INTO banco (id_sucursal, voucher, descripcion, tipo_movimiento, create_user, create_time) " +
                    "VALUES (?id_sucursal, ?voucher, ?descripcion, ?tipo_movimiento, ?create_user, NOW())";
                sql.Parameters.AddWithValue("?id_sucursal", idSucursal);
                sql.Parameters.AddWithValue("?voucher", voucher);
                sql.Parameters.AddWithValue("?descripcion", descripcion);
                sql.Parameters.AddWithValue("?tipo_movimiento", tipoMovimiento);
                sql.Parameters.AddWithValue("?create_user", Usuario.IDUsuarioActual);
                ConexionBD.EjecutarConsulta(sql);
                Totales();
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

