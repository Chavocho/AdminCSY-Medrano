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
    public partial class frmVentasDiarias : Form
    {
        #region Instancia
        private static frmVentasDiarias frmInstancia;
        public static frmVentasDiarias Instancia
        {
            get
            {
                if (frmInstancia == null)
                    frmInstancia = new frmVentasDiarias();
                else if (frmInstancia.IsDisposed)
                    frmInstancia = new frmVentasDiarias();
                return frmInstancia;
            }
            set
            {
                frmInstancia = value;
            }
        }
        #endregion

        int id;
        DataTable dt = new DataTable();
        DelegadoMensajes d = new DelegadoMensajes(FuncionesGenerales.Mensaje);
        CerrarFrmEspera c;

        List<int> codProductos = new List<int>();
        List<string> nombreProductos = new List<string>();
        List<decimal> cantProductos = new List<decimal>();
        List<decimal> precioProductos = new List<decimal>();
        List<decimal> descuentoProductos = new List<decimal>();
        List<Unidades> unidadesProductos = new List<Unidades>();

        public frmVentasDiarias()
        {
            InitializeComponent();
        }

        private void CerrarVenta()
        {
            tmrEsperaVenta.Enabled = false;
            FuncionesGenerales.frmEsperaClose();
        }

        private void BuscarVentas(DateTime fechaIni, DateTime fechaFin)
        {
            c = new CerrarFrmEspera(CerrarVenta);
            try
            {
                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT v.*, SUM(d.cant) AS cant FROM ventas AS v INNER JOIN venta_detallada AS d ON (v.id=d.id_venta) WHERE (v.create_time BETWEEN ?fecha_ini AND ?fecha_fin)";
                sql.Parameters.AddWithValue("?fecha_ini", fechaIni.ToString("yyyy-MM-dd") + " 00:00:00");
                sql.Parameters.AddWithValue("?fecha_fin", fechaFin.ToString("yyyy-MM-dd") + " 23:59:59");
                dt = ConexionBD.EjecutarConsultaSelect(sql);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas.", "Admin CSY", ex });
            }
        }

        private void BuscarVentaDetallada(int id)
        {
            try
            {
                codProductos.Clear();
                nombreProductos.Clear();
                cantProductos.Clear();
                precioProductos.Clear();
                descuentoProductos.Clear();
                unidadesProductos.Clear();

                MySqlCommand sql = new MySqlCommand();
                sql.CommandText = "SELECT v.*, p.nombre, p.codigo FROM venta_detallada AS v INNER JOIN producto AS p ON (v.id_producto=p.id) WHERE v.id_venta=?id_venta";
                sql.Parameters.AddWithValue("?id_venta", id);
                DataTable dtd = ConexionBD.EjecutarConsultaSelect(sql);
                foreach (DataRow dr in dtd.Rows)
                {
                    codProductos.Add((int)dr["codigo"]);
                    nombreProductos.Add(dr["nombre"].ToString());
                    cantProductos.Add((decimal)dr["cant"]);
                    precioProductos.Add((decimal)dr["precio"]);
                    descuentoProductos.Add((decimal)dr["descuento"]);
                    unidadesProductos.Add((Unidades)Enum.Parse(typeof(Unidades), dr["unidad"].ToString()));
                }
                LlenarProductos(dtd);
            }
            catch (MySqlException ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas. No se ha podido conectar con la base de datos.", "Admin CSY", ex });
            }
            catch (Exception ex)
            {
                this.Invoke(c);
                this.Invoke(d, new object[] { this, Mensajes.Error, "Ocurrió un error al buscar las ventas.", "Admin CSY", ex });
            }
        }

        private void LlenarDataTable()
        {
            try
            {
                dgvVentas.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    TipoPago t = (TipoPago)Enum.Parse(typeof(TipoPago), dr["tipo_pago"].ToString());
                    string tipoPago = "", tipoFolio = "", folio = "";
                    switch (t)
                    {
                        case TipoPago.Efectivo:
                            tipoPago = "Efectivo";
                            break;
                        case TipoPago.Cheque:
                            tipoPago = "Cheque";
                            break;
                        case TipoPago.Crédito:
                            tipoPago = "Crédito";
                            break;
                        case TipoPago.Débito:
                            tipoPago = "Débito";
                            break;
                        case TipoPago.Transferencia:
                            tipoPago = "Transferencia";
                            break;
                    }
                    if ((bool)dr["factura"] == false)
                    {
                        tipoFolio = "Remisión";
                        folio = dr["id"].ToString();
                    }
                    else
                    {
                        tipoFolio = "Factura";
                        folio = dr["folio_factura"].ToString();
                    }
                    dgvVentas.Rows.Add(new object[] { dr["id"], dr["total"], dr["cant"], tipoPago, dr["create_time"], tipoFolio, folio});
                }
            }
            catch (Exception ex)
            {
                FuncionesGenerales.Mensaje(this, Mensajes.Error, "Ocurrió un error al mostrar los datos de las ventas.", "Admin CSY", ex);
                throw ex;
            }
        }

        private void LlenarProductos(DataTable dt)
        {
            try
            {
                Graphics g = this.CreateGraphics();
                int y = 10;
                int salto = (int)g.MeasureString("A", new Font("Corbel", 13F, FontStyle.Bold)).Height + 5;
                int posCod = 10;
                int posNom = 175;
                int posCant = (pnlProductos.Width / 3) * 2;
                int posPrecio = (pnlProductos.Width / 3) * 2 + 100;
                int posDesc = (pnlProductos.Width / 3) * 2 + 200;
                int posUnidad = (pnlProductos.Width / 3) * 2 + 300;

                Label lblECodProd = new Label();
                Label lblENomProd = new Label();
                Label lblECantProd = new Label();
                Label lblEPrecioProd = new Label();
                Label lblEDescProd = new Label();
                Label lblEUnidadProd = new Label();

                Label lblCodProd = new Label();
                Label lblNomProd = new Label();
                Label lblCantProd = new Label();
                Label lblPrecioProd = new Label();
                Label lblDescProd = new Label();
                Label lblUnidadProd = new Label();

                lblECodProd.Name = "lblECodProd";
                lblENomProd.Name = "lblENomProd";
                lblECantProd.Name = "lblECantProd";
                lblEPrecioProd.Name = "lblEPrecioProd";
                lblEDescProd.Name = "lblEDescProd";
                lblEUnidadProd.Name = "lblEUnidadProd";

                lblECodProd.Text = "Código";
                lblENomProd.Text = "Nombre";
                lblECantProd.Text = "Cantidad";
                lblEPrecioProd.Text = "Precio";
                lblEDescProd.Text = "Descuento";
                lblEUnidadProd.Text = "Unidad";

                lblECodProd.Location = new Point(posCod, y);
                lblENomProd.Location = new Point(posNom, y);
                lblECantProd.Location = new Point(posCant, y);
                lblEPrecioProd.Location = new Point(posPrecio, y);
                lblEDescProd.Location = new Point(posDesc, y);
                lblEUnidadProd.Location = new Point(posUnidad, y);

                lblECodProd.Font = lblENomProd.Font = lblECantProd.Font = lblEPrecioProd.Font = lblEDescProd.Font = lblEUnidadProd.Font = new Font("Corbel", 13F, FontStyle.Bold);

                pnlProductos.Controls.Add(lblECodProd);
                pnlProductos.Controls.Add(lblENomProd);
                pnlProductos.Controls.Add(lblECantProd);
                pnlProductos.Controls.Add(lblEPrecioProd);
                pnlProductos.Controls.Add(lblEDescProd);
                pnlProductos.Controls.Add(lblEUnidadProd);

                y += salto;

                foreach (DataRow dr in dt.Rows)
                {
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmVentasDiarias_Load(object sender, EventArgs e)
        {
        }
    }
}
