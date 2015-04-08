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
    public partial class frmEditarAlmacen : Form
    {
        private int idTrabajador;

        public int IDTrabajador
        {
            get { return idTrabajador; }
            set { idTrabajador = value; }
        }
        
        public frmEditarAlmacen()
        {
            InitializeComponent();
        }
    }
}
