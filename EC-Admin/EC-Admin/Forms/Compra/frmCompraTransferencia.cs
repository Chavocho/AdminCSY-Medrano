using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC_Admin.Forms
{
    public partial class frmPagosProveedor : Form
    {
        public frmPagosProveedor()
        {
            InitializeComponent();
        }
        private void LlenaCuentaOrigen()
        {
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT * FROM cuenta WHERE tipo=0";
                DataTable dt = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dt.Rows)
                {
                    cboCuentaOrigen.Items.Add(dr["num_cuenta"].ToString() + "/" + dr["banco"].ToString());
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

        private void frmPagosProveedor_Load(object sender, EventArgs e)
        {
            LlenaCuentaOrigen();
        }
    }
}
