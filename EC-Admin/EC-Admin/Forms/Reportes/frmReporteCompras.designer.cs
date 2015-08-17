namespace EC_Admin.Forms
{
    partial class frmReporteCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrEsperaCompra = new System.Windows.Forms.Timer(this.components);
            this.bgwBusquedaCompra = new System.ComponentModel.BackgroundWorker();
            this.tmrEsperaTrabajador = new System.Windows.Forms.Timer(this.components);
            this.bgwBusquedaTrabajador = new System.ComponentModel.BackgroundWorker();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.lblEFechaFin = new System.Windows.Forms.Label();
            this.lblEFechaInic = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.chbComprador = new System.Windows.Forms.CheckBox();
            this.lblEComprador = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboComprador = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblECompra = new System.Windows.Forms.Label();
            this.lblEProveedor = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.tmrEsperaDetallada = new System.Windows.Forms.Timer(this.components);
            this.bgwBusquedaDetallada = new System.ComponentModel.BackgroundWorker();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblComprador = new System.Windows.Forms.Label();
            this.lblVouchers = new System.Windows.Forms.Label();
            this.lblEVouchers = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblEEfectivo = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblEVentas = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblETotal = new System.Windows.Forms.Label();
            this.grbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrEsperaCompra
            // 
            this.tmrEsperaCompra.Interval = 300;
            // 
            // bgwBusquedaCompra
            // 
            this.bgwBusquedaCompra.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBusquedaCompra_DoWork);
            this.bgwBusquedaCompra.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBusquedaCompra_RunWorkerCompleted);
            // 
            // tmrEsperaTrabajador
            // 
            this.tmrEsperaTrabajador.Interval = 300;
            // 
            // bgwBusquedaTrabajador
            // 
            this.bgwBusquedaTrabajador.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBusquedaTrabajador_DoWork);
            this.bgwBusquedaTrabajador.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBusquedaTrabajador_RunWorkerCompleted);
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBusqueda.Controls.Add(this.lblEFechaFin);
            this.grbBusqueda.Controls.Add(this.lblEFechaInic);
            this.grbBusqueda.Controls.Add(this.dtpFechaFin);
            this.grbBusqueda.Controls.Add(this.chbComprador);
            this.grbBusqueda.Controls.Add(this.lblEComprador);
            this.grbBusqueda.Controls.Add(this.btnBuscar);
            this.grbBusqueda.Controls.Add(this.cboComprador);
            this.grbBusqueda.Controls.Add(this.dtpFechaInicio);
            this.grbBusqueda.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.grbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(984, 75);
            this.grbBusqueda.TabIndex = 5;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Búsqueda por fecha";
            // 
            // lblEFechaFin
            // 
            this.lblEFechaFin.AutoSize = true;
            this.lblEFechaFin.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaFin.Location = new System.Drawing.Point(240, 18);
            this.lblEFechaFin.Name = "lblEFechaFin";
            this.lblEFechaFin.Size = new System.Drawing.Size(82, 18);
            this.lblEFechaFin.TabIndex = 37;
            this.lblEFechaFin.Text = "Fecha de fin";
            // 
            // lblEFechaInic
            // 
            this.lblEFechaInic.AutoSize = true;
            this.lblEFechaInic.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFechaInic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaInic.Location = new System.Drawing.Point(3, 18);
            this.lblEFechaInic.Name = "lblEFechaInic";
            this.lblEFechaInic.Size = new System.Drawing.Size(98, 18);
            this.lblEFechaInic.TabIndex = 36;
            this.lblEFechaInic.Text = "Fecha de inicio";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Corbel", 11F);
            this.dtpFechaFin.Location = new System.Drawing.Point(252, 41);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(244, 25);
            this.dtpFechaFin.TabIndex = 35;
            // 
            // chbComprador
            // 
            this.chbComprador.AutoSize = true;
            this.chbComprador.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbComprador.Location = new System.Drawing.Point(500, 43);
            this.chbComprador.Name = "chbComprador";
            this.chbComprador.Size = new System.Drawing.Size(183, 22);
            this.chbComprador.TabIndex = 34;
            this.chbComprador.Text = "Búsqueda por comprador";
            this.chbComprador.UseVisualStyleBackColor = true;
            // 
            // lblEComprador
            // 
            this.lblEComprador.AutoSize = true;
            this.lblEComprador.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEComprador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEComprador.Location = new System.Drawing.Point(686, 18);
            this.lblEComprador.Name = "lblEComprador";
            this.lblEComprador.Size = new System.Drawing.Size(149, 18);
            this.lblEComprador.TabIndex = 33;
            this.lblEComprador.Text = "Seleccionar comprador";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(881, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Tag = "";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboComprador
            // 
            this.cboComprador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboComprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComprador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboComprador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComprador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboComprador.FormattingEnabled = true;
            this.cboComprador.Location = new System.Drawing.Point(689, 41);
            this.cboComprador.Name = "cboComprador";
            this.cboComprador.Size = new System.Drawing.Size(186, 28);
            this.cboComprador.TabIndex = 32;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Corbel", 11F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(6, 41);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(240, 25);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // lblECompra
            // 
            this.lblECompra.AutoSize = true;
            this.lblECompra.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblECompra.Location = new System.Drawing.Point(491, 90);
            this.lblECompra.Name = "lblECompra";
            this.lblECompra.Size = new System.Drawing.Size(102, 22);
            this.lblECompra.TabIndex = 30;
            this.lblECompra.Text = "Comprador:";
            // 
            // lblEProveedor
            // 
            this.lblEProveedor.AutoSize = true;
            this.lblEProveedor.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEProveedor.Location = new System.Drawing.Point(18, 90);
            this.lblEProveedor.Name = "lblEProveedor";
            this.lblEProveedor.Size = new System.Drawing.Size(95, 22);
            this.lblEProveedor.TabIndex = 29;
            this.lblEProveedor.Text = "Proveedor:";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToResizeColumns = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CVendedor,
            this.CCliente,
            this.CTotal,
            this.CTipoPago,
            this.CFecha,
            this.CTipoFolio,
            this.CFolio});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompras.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvCompras.Location = new System.Drawing.Point(10, 120);
            this.dgvCompras.MultiSelect = false;
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(984, 300);
            this.dgvCompras.TabIndex = 28;
            this.dgvCompras.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_RowEnter);
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CVendedor
            // 
            this.CVendedor.HeaderText = "Vendedor";
            this.CVendedor.Name = "CVendedor";
            this.CVendedor.Visible = false;
            // 
            // CCliente
            // 
            this.CCliente.HeaderText = "Cliente";
            this.CCliente.Name = "CCliente";
            this.CCliente.Visible = false;
            // 
            // CTotal
            // 
            dataGridViewCellStyle13.Format = "C2";
            this.CTotal.DefaultCellStyle = dataGridViewCellStyle13;
            this.CTotal.HeaderText = "Total";
            this.CTotal.Name = "CTotal";
            this.CTotal.Width = 150;
            // 
            // CTipoPago
            // 
            this.CTipoPago.HeaderText = "Tipo pago";
            this.CTipoPago.Name = "CTipoPago";
            this.CTipoPago.Width = 150;
            // 
            // CFecha
            // 
            this.CFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Format = "dd \' de \' MMMM \' del \' yyyy, hh:mm tt";
            this.CFecha.DefaultCellStyle = dataGridViewCellStyle14;
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            // 
            // CTipoFolio
            // 
            this.CTipoFolio.HeaderText = "Tipo folio";
            this.CTipoFolio.Name = "CTipoFolio";
            this.CTipoFolio.Width = 130;
            // 
            // CFolio
            // 
            this.CFolio.HeaderText = "Folio";
            this.CFolio.Name = "CFolio";
            this.CFolio.Width = 130;
            // 
            // pnlProductos
            // 
            this.pnlProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductos.AutoScroll = true;
            this.pnlProductos.BackColor = System.Drawing.Color.White;
            this.pnlProductos.Location = new System.Drawing.Point(10, 427);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(984, 204);
            this.pnlProductos.TabIndex = 31;
            // 
            // tmrEsperaDetallada
            // 
            this.tmrEsperaDetallada.Interval = 300;
            // 
            // bgwBusquedaDetallada
            // 
            this.bgwBusquedaDetallada.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBusquedaDetallada_DoWork);
            this.bgwBusquedaDetallada.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBusquedaDetallada_RunWorkerCompleted);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(94, 90);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(0, 21);
            this.lblProveedor.TabIndex = 29;
            // 
            // lblComprador
            // 
            this.lblComprador.AutoSize = true;
            this.lblComprador.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprador.Location = new System.Drawing.Point(599, 90);
            this.lblComprador.Name = "lblComprador";
            this.lblComprador.Size = new System.Drawing.Size(0, 21);
            this.lblComprador.TabIndex = 30;
            // 
            // lblVouchers
            // 
            this.lblVouchers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVouchers.AutoSize = true;
            this.lblVouchers.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVouchers.Location = new System.Drawing.Point(465, 666);
            this.lblVouchers.Name = "lblVouchers";
            this.lblVouchers.Size = new System.Drawing.Size(44, 20);
            this.lblVouchers.TabIndex = 39;
            this.lblVouchers.Text = "$0.00";
            // 
            // lblEVouchers
            // 
            this.lblEVouchers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEVouchers.AutoSize = true;
            this.lblEVouchers.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEVouchers.Location = new System.Drawing.Point(330, 666);
            this.lblEVouchers.Name = "lblEVouchers";
            this.lblEVouchers.Size = new System.Drawing.Size(129, 22);
            this.lblEVouchers.TabIndex = 38;
            this.lblEVouchers.Text = "Total vouchers:";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(465, 639);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(44, 20);
            this.lblEfectivo.TabIndex = 37;
            this.lblEfectivo.Text = "$0.00";
            // 
            // lblEEfectivo
            // 
            this.lblEEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEEfectivo.AutoSize = true;
            this.lblEEfectivo.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEEfectivo.Location = new System.Drawing.Point(338, 639);
            this.lblEEfectivo.Name = "lblEEfectivo";
            this.lblEEfectivo.Size = new System.Drawing.Size(121, 22);
            this.lblEEfectivo.TabIndex = 36;
            this.lblEEfectivo.Text = "Total efectivo:";
            // 
            // lblCompras
            // 
            this.lblCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.Location = new System.Drawing.Point(167, 666);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(17, 20);
            this.lblCompras.TabIndex = 35;
            this.lblCompras.Text = "0";
            // 
            // lblEVentas
            // 
            this.lblEVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEVentas.AutoSize = true;
            this.lblEVentas.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEVentas.Location = new System.Drawing.Point(12, 666);
            this.lblEVentas.Name = "lblEVentas";
            this.lblEVentas.Size = new System.Drawing.Size(165, 22);
            this.lblEVentas.TabIndex = 34;
            this.lblEVentas.Text = "Compras realizadas:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(167, 639);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "$0.00";
            // 
            // lblETotal
            // 
            this.lblETotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblETotal.AutoSize = true;
            this.lblETotal.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblETotal.Location = new System.Drawing.Point(51, 639);
            this.lblETotal.Name = "lblETotal";
            this.lblETotal.Size = new System.Drawing.Size(110, 22);
            this.lblETotal.TabIndex = 32;
            this.lblETotal.Text = "Total del día:";
            // 
            // frmReporteCompras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.lblVouchers);
            this.Controls.Add(this.lblEVouchers);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.lblEEfectivo);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.lblEVentas);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblETotal);
            this.Controls.Add(this.pnlProductos);
            this.Controls.Add(this.lblComprador);
            this.Controls.Add(this.lblECompra);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblEProveedor);
            this.Controls.Add(this.grbBusqueda);
            this.Controls.Add(this.dgvCompras);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1024, 736);
            this.Name = "frmReporteCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Compras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteCompras_Load);
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrEsperaCompra;
        private System.ComponentModel.BackgroundWorker bgwBusquedaCompra;
        private System.Windows.Forms.Timer tmrEsperaTrabajador;
        private System.ComponentModel.BackgroundWorker bgwBusquedaTrabajador;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.Label lblEFechaFin;
        private System.Windows.Forms.Label lblEFechaInic;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.CheckBox chbComprador;
        private System.Windows.Forms.Label lblEComprador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboComprador;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblECompra;
        private System.Windows.Forms.Label lblEProveedor;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFolio;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Timer tmrEsperaDetallada;
        private System.ComponentModel.BackgroundWorker bgwBusquedaDetallada;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblComprador;
        private System.Windows.Forms.Label lblVouchers;
        private System.Windows.Forms.Label lblEVouchers;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblEEfectivo;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Label lblEVentas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblETotal;
    }
}