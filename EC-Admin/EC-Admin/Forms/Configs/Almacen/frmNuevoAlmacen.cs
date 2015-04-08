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
    public partial class frmNuevoAlmacen : Form
    {
        private int idTrabajador;

        public int IDTrabajador
        {
            get { return idTrabajador; }
            set
            {
                idTrabajador = value;
            }
        }

        public string NombreTrabajador
        {
            get { return lblJefeAlmacen.Text; }
            set { lblJefeAlmacen.Text = value; }
        }
        
        public frmNuevoAlmacen()
        {
            InitializeComponent();
        }

        private void Insertar()
        {
            try
            {
                Almacen a = new Almacen();
                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
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
