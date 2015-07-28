namespace EC_Admin.Forms
{
    partial class frmDetalladoCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlCompra = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblETotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblEDescuento = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblEImpuesto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblESubtotal = new System.Windows.Forms.Label();
            this.lblFolioFactura = new System.Windows.Forms.Label();
            this.lblEFolioFactura = new System.Windows.Forms.Label();
            this.lblFolioRemision = new System.Windows.Forms.Label();
            this.lblEFolioRemision = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblEFactura = new System.Windows.Forms.Label();
            this.lblRemision = new System.Windows.Forms.Label();
            this.lblERemision = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblETipoPago = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEFecha = new System.Windows.Forms.Label();
            this.pnlDetallada = new System.Windows.Forms.Panel();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.lblInfoPago = new System.Windows.Forms.Label();
            this.lblEDato1 = new System.Windows.Forms.Label();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.lblEDato2 = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblEConcepto = new System.Windows.Forms.Label();
            this.grbCuentaOrigen = new System.Windows.Forms.GroupBox();
            this.lblBenefOrigen = new System.Windows.Forms.Label();
            this.lblSucOrigen = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblCuentaOrigen = new System.Windows.Forms.Label();
            this.lblBenef = new System.Windows.Forms.Label();
            this.lblNCuenta = new System.Windows.Forms.Label();
            this.lblBancoOrigen = new System.Windows.Forms.Label();
            this.lblEBanco = new System.Windows.Forms.Label();
            this.grbCuentaDestino = new System.Windows.Forms.GroupBox();
            this.lblBenefDestino = new System.Windows.Forms.Label();
            this.lblSucDestino = new System.Windows.Forms.Label();
            this.lblSuc = new System.Windows.Forms.Label();
            this.lblCuentaDestino = new System.Windows.Forms.Label();
            this.lblBeneficiario = new System.Windows.Forms.Label();
            this.lblNCuent = new System.Windows.Forms.Label();
            this.lblBancoDestino = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.pnlCompra.SuspendLayout();
            this.grbCuentaOrigen.SuspendLayout();
            this.grbCuentaDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCompra
            // 
            this.pnlCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCompra.Controls.Add(this.grbCuentaDestino);
            this.pnlCompra.Controls.Add(this.grbCuentaOrigen);
            this.pnlCompra.Controls.Add(this.lblEConcepto);
            this.pnlCompra.Controls.Add(this.lblEDato2);
            this.pnlCompra.Controls.Add(this.lblEDato1);
            this.pnlCompra.Controls.Add(this.lblTotal);
            this.pnlCompra.Controls.Add(this.lblETotal);
            this.pnlCompra.Controls.Add(this.lblDescuento);
            this.pnlCompra.Controls.Add(this.lblEDescuento);
            this.pnlCompra.Controls.Add(this.lblImpuesto);
            this.pnlCompra.Controls.Add(this.lblEImpuesto);
            this.pnlCompra.Controls.Add(this.lblSubtotal);
            this.pnlCompra.Controls.Add(this.lblESubtotal);
            this.pnlCompra.Controls.Add(this.lblFolioFactura);
            this.pnlCompra.Controls.Add(this.lblConcepto);
            this.pnlCompra.Controls.Add(this.lblDato2);
            this.pnlCompra.Controls.Add(this.lblDato1);
            this.pnlCompra.Controls.Add(this.lblEFolioFactura);
            this.pnlCompra.Controls.Add(this.lblFolioRemision);
            this.pnlCompra.Controls.Add(this.lblInfoPago);
            this.pnlCompra.Controls.Add(this.lblEFolioRemision);
            this.pnlCompra.Controls.Add(this.lblFactura);
            this.pnlCompra.Controls.Add(this.lblEFactura);
            this.pnlCompra.Controls.Add(this.lblRemision);
            this.pnlCompra.Controls.Add(this.lblERemision);
            this.pnlCompra.Controls.Add(this.lblTipoPago);
            this.pnlCompra.Controls.Add(this.lblETipoPago);
            this.pnlCompra.Controls.Add(this.lblFecha);
            this.pnlCompra.Controls.Add(this.lblEFecha);
            this.pnlCompra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnlCompra.Location = new System.Drawing.Point(0, 0);
            this.pnlCompra.Name = "pnlCompra";
            this.pnlCompra.Size = new System.Drawing.Size(1008, 326);
            this.pnlCompra.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(918, 84);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(27, 19);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "---";
            // 
            // lblETotal
            // 
            this.lblETotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblETotal.AutoSize = true;
            this.lblETotal.Location = new System.Drawing.Point(873, 65);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(39, 19);
            this.lblETotal.TabIndex = 18;
            this.lblETotal.Text = "Total";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescuento.Location = new System.Drawing.Point(793, 84);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(27, 19);
            this.lblDescuento.TabIndex = 17;
            this.lblDescuento.Text = "---";
            // 
            // lblEDescuento
            // 
            this.lblEDescuento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEDescuento.AutoSize = true;
            this.lblEDescuento.Location = new System.Drawing.Point(713, 65);
            this.lblEDescuento.Name = "lblEDescuento";
            this.lblEDescuento.Size = new System.Drawing.Size(74, 19);
            this.lblEDescuento.TabIndex = 16;
            this.lblEDescuento.Text = "Descuento";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblImpuesto.Location = new System.Drawing.Point(637, 84);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(27, 19);
            this.lblImpuesto.TabIndex = 15;
            this.lblImpuesto.Text = "---";
            // 
            // lblEImpuesto
            // 
            this.lblEImpuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEImpuesto.AutoSize = true;
            this.lblEImpuesto.Location = new System.Drawing.Point(573, 65);
            this.lblEImpuesto.Name = "lblEImpuesto";
            this.lblEImpuesto.Size = new System.Drawing.Size(67, 19);
            this.lblEImpuesto.TabIndex = 14;
            this.lblEImpuesto.Text = "Impuesto";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubtotal.Location = new System.Drawing.Point(487, 84);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(27, 19);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "---";
            // 
            // lblESubtotal
            // 
            this.lblESubtotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblESubtotal.AutoSize = true;
            this.lblESubtotal.Location = new System.Drawing.Point(421, 65);
            this.lblESubtotal.Name = "lblESubtotal";
            this.lblESubtotal.Size = new System.Drawing.Size(60, 19);
            this.lblESubtotal.TabIndex = 12;
            this.lblESubtotal.Text = "Subtotal";
            // 
            // lblFolioFactura
            // 
            this.lblFolioFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFolioFactura.AutoSize = true;
            this.lblFolioFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFolioFactura.Location = new System.Drawing.Point(331, 84);
            this.lblFolioFactura.Name = "lblFolioFactura";
            this.lblFolioFactura.Size = new System.Drawing.Size(27, 19);
            this.lblFolioFactura.TabIndex = 11;
            this.lblFolioFactura.Text = "---";
            // 
            // lblEFolioFactura
            // 
            this.lblEFolioFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEFolioFactura.AutoSize = true;
            this.lblEFolioFactura.Location = new System.Drawing.Point(222, 65);
            this.lblEFolioFactura.Name = "lblEFolioFactura";
            this.lblEFolioFactura.Size = new System.Drawing.Size(103, 19);
            this.lblEFolioFactura.TabIndex = 10;
            this.lblEFolioFactura.Text = "Folio de factura";
            // 
            // lblFolioRemision
            // 
            this.lblFolioRemision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFolioRemision.AutoSize = true;
            this.lblFolioRemision.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFolioRemision.Location = new System.Drawing.Point(131, 84);
            this.lblFolioRemision.Name = "lblFolioRemision";
            this.lblFolioRemision.Size = new System.Drawing.Size(27, 19);
            this.lblFolioRemision.TabIndex = 9;
            this.lblFolioRemision.Text = "---";
            // 
            // lblEFolioRemision
            // 
            this.lblEFolioRemision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEFolioRemision.AutoSize = true;
            this.lblEFolioRemision.Location = new System.Drawing.Point(12, 65);
            this.lblEFolioRemision.Name = "lblEFolioRemision";
            this.lblEFolioRemision.Size = new System.Drawing.Size(113, 19);
            this.lblEFolioRemision.TabIndex = 8;
            this.lblEFolioRemision.Text = "Folio de remisión";
            // 
            // lblFactura
            // 
            this.lblFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFactura.Location = new System.Drawing.Point(918, 28);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(27, 19);
            this.lblFactura.TabIndex = 7;
            this.lblFactura.Text = "---";
            // 
            // lblEFactura
            // 
            this.lblEFactura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEFactura.AutoSize = true;
            this.lblEFactura.Location = new System.Drawing.Point(799, 9);
            this.lblEFactura.Name = "lblEFactura";
            this.lblEFactura.Size = new System.Drawing.Size(113, 19);
            this.lblEFactura.TabIndex = 6;
            this.lblEFactura.Text = "Se recibió factura";
            // 
            // lblRemision
            // 
            this.lblRemision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRemision.AutoSize = true;
            this.lblRemision.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRemision.Location = new System.Drawing.Point(713, 28);
            this.lblRemision.Name = "lblRemision";
            this.lblRemision.Size = new System.Drawing.Size(27, 19);
            this.lblRemision.TabIndex = 5;
            this.lblRemision.Text = "---";
            // 
            // lblERemision
            // 
            this.lblERemision.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblERemision.AutoSize = true;
            this.lblERemision.Location = new System.Drawing.Point(584, 9);
            this.lblERemision.Name = "lblERemision";
            this.lblERemision.Size = new System.Drawing.Size(123, 19);
            this.lblERemision.TabIndex = 4;
            this.lblERemision.Text = "Se recibió remisión";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoPago.Location = new System.Drawing.Point(421, 28);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(27, 19);
            this.lblTipoPago.TabIndex = 3;
            this.lblTipoPago.Text = "---";
            // 
            // lblETipoPago
            // 
            this.lblETipoPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblETipoPago.AutoSize = true;
            this.lblETipoPago.Location = new System.Drawing.Point(331, 9);
            this.lblETipoPago.Name = "lblETipoPago";
            this.lblETipoPago.Size = new System.Drawing.Size(84, 19);
            this.lblETipoPago.TabIndex = 2;
            this.lblETipoPago.Text = "Se pago con";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(62, 28);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(27, 19);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "---";
            // 
            // lblEFecha
            // 
            this.lblEFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEFecha.AutoSize = true;
            this.lblEFecha.Location = new System.Drawing.Point(12, 9);
            this.lblEFecha.Name = "lblEFecha";
            this.lblEFecha.Size = new System.Drawing.Size(44, 19);
            this.lblEFecha.TabIndex = 0;
            this.lblEFecha.Text = "Fecha";
            // 
            // pnlDetallada
            // 
            this.pnlDetallada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetallada.AutoScroll = true;
            this.pnlDetallada.BackColor = System.Drawing.Color.White;
            this.pnlDetallada.Location = new System.Drawing.Point(0, 332);
            this.pnlDetallada.Name = "pnlDetallada";
            this.pnlDetallada.Size = new System.Drawing.Size(1008, 203);
            this.pnlDetallada.TabIndex = 2;
            // 
            // tmrEspera
            // 
            this.tmrEspera.Interval = 300;
            // 
            // lblInfoPago
            // 
            this.lblInfoPago.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInfoPago.AutoSize = true;
            this.lblInfoPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPago.Location = new System.Drawing.Point(12, 123);
            this.lblInfoPago.Name = "lblInfoPago";
            this.lblInfoPago.Size = new System.Drawing.Size(137, 17);
            this.lblInfoPago.TabIndex = 8;
            this.lblInfoPago.Text = "Informacion de pago";
            // 
            // lblEDato1
            // 
            this.lblEDato1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEDato1.AutoSize = true;
            this.lblEDato1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEDato1.Location = new System.Drawing.Point(131, 171);
            this.lblEDato1.Name = "lblEDato1";
            this.lblEDato1.Size = new System.Drawing.Size(27, 19);
            this.lblEDato1.TabIndex = 20;
            this.lblEDato1.Text = "---";
            // 
            // lblDato1
            // 
            this.lblDato1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDato1.AutoSize = true;
            this.lblDato1.BackColor = System.Drawing.Color.Transparent;
            this.lblDato1.Location = new System.Drawing.Point(22, 171);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(75, 19);
            this.lblDato1.TabIndex = 10;
            this.lblDato1.Text = "N° cheque:";
            // 
            // lblDato2
            // 
            this.lblDato2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDato2.AutoSize = true;
            this.lblDato2.BackColor = System.Drawing.Color.Transparent;
            this.lblDato2.Location = new System.Drawing.Point(22, 216);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(74, 19);
            this.lblDato2.TabIndex = 10;
            this.lblDato2.Text = "Referencia:";
            // 
            // lblEDato2
            // 
            this.lblEDato2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEDato2.AutoSize = true;
            this.lblEDato2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEDato2.Location = new System.Drawing.Point(131, 216);
            this.lblEDato2.Name = "lblEDato2";
            this.lblEDato2.Size = new System.Drawing.Size(27, 19);
            this.lblEDato2.TabIndex = 20;
            this.lblEDato2.Text = "---";
            // 
            // lblConcepto
            // 
            this.lblConcepto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.BackColor = System.Drawing.Color.Transparent;
            this.lblConcepto.Location = new System.Drawing.Point(22, 265);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(71, 19);
            this.lblConcepto.TabIndex = 10;
            this.lblConcepto.Text = "Concepto:";
            this.lblConcepto.Visible = false;
            // 
            // lblEConcepto
            // 
            this.lblEConcepto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEConcepto.AutoSize = true;
            this.lblEConcepto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEConcepto.Location = new System.Drawing.Point(131, 265);
            this.lblEConcepto.Name = "lblEConcepto";
            this.lblEConcepto.Size = new System.Drawing.Size(27, 19);
            this.lblEConcepto.TabIndex = 20;
            this.lblEConcepto.Text = "---";
            this.lblEConcepto.Visible = false;
            // 
            // grbCuentaOrigen
            // 
            this.grbCuentaOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCuentaOrigen.Controls.Add(this.lblBenefOrigen);
            this.grbCuentaOrigen.Controls.Add(this.lblSucOrigen);
            this.grbCuentaOrigen.Controls.Add(this.lblSucursal);
            this.grbCuentaOrigen.Controls.Add(this.lblCuentaOrigen);
            this.grbCuentaOrigen.Controls.Add(this.lblBenef);
            this.grbCuentaOrigen.Controls.Add(this.lblNCuenta);
            this.grbCuentaOrigen.Controls.Add(this.lblBancoOrigen);
            this.grbCuentaOrigen.Controls.Add(this.lblEBanco);
            this.grbCuentaOrigen.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbCuentaOrigen.Location = new System.Drawing.Point(297, 171);
            this.grbCuentaOrigen.Name = "grbCuentaOrigen";
            this.grbCuentaOrigen.Size = new System.Drawing.Size(271, 134);
            this.grbCuentaOrigen.TabIndex = 22;
            this.grbCuentaOrigen.TabStop = false;
            this.grbCuentaOrigen.Text = "Información de cuenta origen";
            // 
            // lblBenefOrigen
            // 
            this.lblBenefOrigen.AutoSize = true;
            this.lblBenefOrigen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenefOrigen.Location = new System.Drawing.Point(124, 114);
            this.lblBenefOrigen.Name = "lblBenefOrigen";
            this.lblBenefOrigen.Size = new System.Drawing.Size(18, 17);
            this.lblBenefOrigen.TabIndex = 5;
            this.lblBenefOrigen.Text = "--";
            // 
            // lblSucOrigen
            // 
            this.lblSucOrigen.AutoSize = true;
            this.lblSucOrigen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucOrigen.Location = new System.Drawing.Point(124, 81);
            this.lblSucOrigen.Name = "lblSucOrigen";
            this.lblSucOrigen.Size = new System.Drawing.Size(18, 17);
            this.lblSucOrigen.TabIndex = 5;
            this.lblSucOrigen.Text = "--";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblSucursal.Location = new System.Drawing.Point(10, 81);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(64, 18);
            this.lblSucursal.TabIndex = 4;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblCuentaOrigen
            // 
            this.lblCuentaOrigen.AutoSize = true;
            this.lblCuentaOrigen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaOrigen.Location = new System.Drawing.Point(124, 49);
            this.lblCuentaOrigen.Name = "lblCuentaOrigen";
            this.lblCuentaOrigen.Size = new System.Drawing.Size(18, 17);
            this.lblCuentaOrigen.TabIndex = 1;
            this.lblCuentaOrigen.Text = "--";
            // 
            // lblBenef
            // 
            this.lblBenef.AutoSize = true;
            this.lblBenef.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblBenef.Location = new System.Drawing.Point(10, 113);
            this.lblBenef.Name = "lblBenef";
            this.lblBenef.Size = new System.Drawing.Size(84, 18);
            this.lblBenef.TabIndex = 4;
            this.lblBenef.Text = "Beneficiario:";
            // 
            // lblNCuenta
            // 
            this.lblNCuenta.AutoSize = true;
            this.lblNCuenta.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblNCuenta.Location = new System.Drawing.Point(10, 48);
            this.lblNCuenta.Name = "lblNCuenta";
            this.lblNCuenta.Size = new System.Drawing.Size(91, 18);
            this.lblNCuenta.TabIndex = 0;
            this.lblNCuenta.Text = "N° de cuenta:";
            // 
            // lblBancoOrigen
            // 
            this.lblBancoOrigen.AutoSize = true;
            this.lblBancoOrigen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancoOrigen.Location = new System.Drawing.Point(124, 19);
            this.lblBancoOrigen.Name = "lblBancoOrigen";
            this.lblBancoOrigen.Size = new System.Drawing.Size(18, 17);
            this.lblBancoOrigen.TabIndex = 1;
            this.lblBancoOrigen.Text = "--";
            // 
            // lblEBanco
            // 
            this.lblEBanco.AutoSize = true;
            this.lblEBanco.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEBanco.Location = new System.Drawing.Point(10, 19);
            this.lblEBanco.Name = "lblEBanco";
            this.lblEBanco.Size = new System.Drawing.Size(51, 18);
            this.lblEBanco.TabIndex = 0;
            this.lblEBanco.Text = "Banco:";
            // 
            // grbCuentaDestino
            // 
            this.grbCuentaDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCuentaDestino.Controls.Add(this.lblBenefDestino);
            this.grbCuentaDestino.Controls.Add(this.lblSucDestino);
            this.grbCuentaDestino.Controls.Add(this.lblSuc);
            this.grbCuentaDestino.Controls.Add(this.lblCuentaDestino);
            this.grbCuentaDestino.Controls.Add(this.lblBeneficiario);
            this.grbCuentaDestino.Controls.Add(this.lblNCuent);
            this.grbCuentaDestino.Controls.Add(this.lblBancoDestino);
            this.grbCuentaDestino.Controls.Add(this.lblBanco);
            this.grbCuentaDestino.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbCuentaDestino.Location = new System.Drawing.Point(574, 171);
            this.grbCuentaDestino.Name = "grbCuentaDestino";
            this.grbCuentaDestino.Size = new System.Drawing.Size(271, 134);
            this.grbCuentaDestino.TabIndex = 23;
            this.grbCuentaDestino.TabStop = false;
            this.grbCuentaDestino.Text = "Información de cuenta destino";
            this.grbCuentaDestino.Visible = false;
            // 
            // lblBenefDestino
            // 
            this.lblBenefDestino.AutoSize = true;
            this.lblBenefDestino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenefDestino.Location = new System.Drawing.Point(124, 114);
            this.lblBenefDestino.Name = "lblBenefDestino";
            this.lblBenefDestino.Size = new System.Drawing.Size(18, 17);
            this.lblBenefDestino.TabIndex = 5;
            this.lblBenefDestino.Text = "--";
            // 
            // lblSucDestino
            // 
            this.lblSucDestino.AutoSize = true;
            this.lblSucDestino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucDestino.Location = new System.Drawing.Point(124, 81);
            this.lblSucDestino.Name = "lblSucDestino";
            this.lblSucDestino.Size = new System.Drawing.Size(18, 17);
            this.lblSucDestino.TabIndex = 5;
            this.lblSucDestino.Text = "--";
            // 
            // lblSuc
            // 
            this.lblSuc.AutoSize = true;
            this.lblSuc.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblSuc.Location = new System.Drawing.Point(10, 81);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(64, 18);
            this.lblSuc.TabIndex = 4;
            this.lblSuc.Text = "Sucursal:";
            // 
            // lblCuentaDestino
            // 
            this.lblCuentaDestino.AutoSize = true;
            this.lblCuentaDestino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaDestino.Location = new System.Drawing.Point(124, 49);
            this.lblCuentaDestino.Name = "lblCuentaDestino";
            this.lblCuentaDestino.Size = new System.Drawing.Size(18, 17);
            this.lblCuentaDestino.TabIndex = 1;
            this.lblCuentaDestino.Text = "--";
            // 
            // lblBeneficiario
            // 
            this.lblBeneficiario.AutoSize = true;
            this.lblBeneficiario.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblBeneficiario.Location = new System.Drawing.Point(10, 113);
            this.lblBeneficiario.Name = "lblBeneficiario";
            this.lblBeneficiario.Size = new System.Drawing.Size(84, 18);
            this.lblBeneficiario.TabIndex = 4;
            this.lblBeneficiario.Text = "Beneficiario:";
            // 
            // lblNCuent
            // 
            this.lblNCuent.AutoSize = true;
            this.lblNCuent.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblNCuent.Location = new System.Drawing.Point(10, 48);
            this.lblNCuent.Name = "lblNCuent";
            this.lblNCuent.Size = new System.Drawing.Size(91, 18);
            this.lblNCuent.TabIndex = 0;
            this.lblNCuent.Text = "N° de cuenta:";
            // 
            // lblBancoDestino
            // 
            this.lblBancoDestino.AutoSize = true;
            this.lblBancoDestino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancoDestino.Location = new System.Drawing.Point(124, 19);
            this.lblBancoDestino.Name = "lblBancoDestino";
            this.lblBancoDestino.Size = new System.Drawing.Size(18, 17);
            this.lblBancoDestino.TabIndex = 1;
            this.lblBancoDestino.Text = "--";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblBanco.Location = new System.Drawing.Point(10, 19);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(51, 18);
            this.lblBanco.TabIndex = 0;
            this.lblBanco.Text = "Banco:";
            // 
            // frmDetalladoCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 535);
            this.Controls.Add(this.pnlDetallada);
            this.Controls.Add(this.pnlCompra);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.Name = "frmDetalladoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detallado de la compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDetalladoCompra_Load);
            this.pnlCompra.ResumeLayout(false);
            this.pnlCompra.PerformLayout();
            this.grbCuentaOrigen.ResumeLayout(false);
            this.grbCuentaOrigen.PerformLayout();
            this.grbCuentaDestino.ResumeLayout(false);
            this.grbCuentaDestino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCompra;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblETotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblEDescuento;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblEImpuesto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblESubtotal;
        private System.Windows.Forms.Label lblFolioFactura;
        private System.Windows.Forms.Label lblEFolioFactura;
        private System.Windows.Forms.Label lblFolioRemision;
        private System.Windows.Forms.Label lblEFolioRemision;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblEFactura;
        private System.Windows.Forms.Label lblRemision;
        private System.Windows.Forms.Label lblERemision;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblETipoPago;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEFecha;
        private System.Windows.Forms.Panel pnlDetallada;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.Label lblInfoPago;
        private System.Windows.Forms.Label lblEDato1;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.Label lblEConcepto;
        private System.Windows.Forms.Label lblEDato2;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.GroupBox grbCuentaOrigen;
        private System.Windows.Forms.Label lblBenefOrigen;
        private System.Windows.Forms.Label lblSucOrigen;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblCuentaOrigen;
        private System.Windows.Forms.Label lblBenef;
        private System.Windows.Forms.Label lblNCuenta;
        private System.Windows.Forms.Label lblBancoOrigen;
        private System.Windows.Forms.Label lblEBanco;
        private System.Windows.Forms.GroupBox grbCuentaDestino;
        private System.Windows.Forms.Label lblBenefDestino;
        private System.Windows.Forms.Label lblSucDestino;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.Label lblCuentaDestino;
        private System.Windows.Forms.Label lblBeneficiario;
        private System.Windows.Forms.Label lblNCuent;
        private System.Windows.Forms.Label lblBancoDestino;
        private System.Windows.Forms.Label lblBanco;
    }
}