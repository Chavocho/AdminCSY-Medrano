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
    public partial class frmConfigAlmacen : Form
    {
        #region Instancia
        private static frmConfigAlmacen frmInstancia;
        public static frmConfigAlmacen Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmConfigAlmacen();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmConfigAlmacen();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        public frmConfigAlmacen()
        {
            InitializeComponent();
        }
    }
}
