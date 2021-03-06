﻿namespace EC_Admin.Forms
{
    partial class frmCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCaja = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEfectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVouchers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFechas = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.grbFolio = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.grbTotales = new System.Windows.Forms.GroupBox();
            this.lblTotEfeCaj = new System.Windows.Forms.Label();
            this.lblETotEfeCaj = new System.Windows.Forms.Label();
            this.lblTotEfeMos = new System.Windows.Forms.Label();
            this.lblETotEfeMos = new System.Windows.Forms.Label();
            this.btnAbrirCerrar = new System.Windows.Forms.Button();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.btnCortes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotVouMos = new System.Windows.Forms.Label();
            this.lblVoucher = new System.Windows.Forms.Label();
            this.lblTotVouCaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.grbFechas.SuspendLayout();
            this.grbFolio.SuspendLayout();
            this.grbTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCaja
            // 
            this.dgvCaja.AllowUserToAddRows = false;
            this.dgvCaja.AllowUserToDeleteRows = false;
            this.dgvCaja.AllowUserToResizeColumns = false;
            this.dgvCaja.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvCaja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCaja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CFecha,
            this.CDescripcion,
            this.CEfectivo,
            this.CVouchers,
            this.CTipoMovimiento});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCaja.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCaja.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCaja.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvCaja.Location = new System.Drawing.Point(12, 74);
            this.dgvCaja.MultiSelect = false;
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCaja.RowHeadersVisible = false;
            this.dgvCaja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaja.Size = new System.Drawing.Size(1054, 467);
            this.dgvCaja.TabIndex = 13;
            this.dgvCaja.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaja_RowEnter);
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CFecha
            // 
            dataGridViewCellStyle15.Format = "dd \' de \' MMMM \' del \' yyyy, hh:mm tt";
            this.CFecha.DefaultCellStyle = dataGridViewCellStyle15;
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            this.CFecha.Width = 200;
            // 
            // CDescripcion
            // 
            this.CDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcion.HeaderText = "Descripción";
            this.CDescripcion.Name = "CDescripcion";
            // 
            // CEfectivo
            // 
            dataGridViewCellStyle16.Format = "C2";
            this.CEfectivo.DefaultCellStyle = dataGridViewCellStyle16;
            this.CEfectivo.HeaderText = "Efectivo";
            this.CEfectivo.Name = "CEfectivo";
            // 
            // CVouchers
            // 
            dataGridViewCellStyle17.Format = "C2";
            this.CVouchers.DefaultCellStyle = dataGridViewCellStyle17;
            this.CVouchers.HeaderText = "Vouchers";
            this.CVouchers.Name = "CVouchers";
            // 
            // CTipoMovimiento
            // 
            this.CTipoMovimiento.HeaderText = "Tipo movimiento";
            this.CTipoMovimiento.Name = "CTipoMovimiento";
            this.CTipoMovimiento.Width = 150;
            // 
            // grbFechas
            // 
            this.grbFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFechas.Controls.Add(this.btnBuscar);
            this.grbFechas.Controls.Add(this.dtpFechaFin);
            this.grbFechas.Controls.Add(this.dtpFechaInicio);
            this.grbFechas.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.grbFechas.Location = new System.Drawing.Point(178, 12);
            this.grbFechas.Name = "grbFechas";
            this.grbFechas.Size = new System.Drawing.Size(621, 56);
            this.grbFechas.TabIndex = 14;
            this.grbFechas.TabStop = false;
            this.grbFechas.Text = "Búsqueda por fechas";
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
            this.btnBuscar.Location = new System.Drawing.Point(518, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Corbel", 11F);
            this.dtpFechaFin.Location = new System.Drawing.Point(262, 25);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(250, 25);
            this.dtpFechaFin.TabIndex = 1;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Corbel", 11F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(6, 25);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(250, 25);
            this.dtpFechaInicio.TabIndex = 0;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechas_ValueChanged);
            // 
            // grbFolio
            // 
            this.grbFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFolio.Controls.Add(this.txtBusqueda);
            this.grbFolio.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbFolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.grbFolio.Location = new System.Drawing.Point(805, 12);
            this.grbFolio.Name = "grbFolio";
            this.grbFolio.Size = new System.Drawing.Size(261, 56);
            this.grbFolio.TabIndex = 15;
            this.grbFolio.TabStop = false;
            this.grbFolio.Text = "Búsqueda por folio";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtBusqueda.Location = new System.Drawing.Point(6, 21);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(249, 27);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            // 
            // btnSalida
            // 
            this.btnSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSalida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnSalida.ForeColor = System.Drawing.Color.White;
            this.btnSalida.Location = new System.Drawing.Point(866, 625);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(200, 60);
            this.btnSalida.TabIndex = 17;
            this.btnSalida.Text = "Salida (F3)";
            this.btnSalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(660, 625);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(200, 60);
            this.btnEntrada.TabIndex = 16;
            this.btnEntrada.Text = "Entrada (F2)";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // grbTotales
            // 
            this.grbTotales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbTotales.Controls.Add(this.lblTotVouCaj);
            this.grbTotales.Controls.Add(this.lblTotEfeCaj);
            this.grbTotales.Controls.Add(this.lblVoucher);
            this.grbTotales.Controls.Add(this.lblTotVouMos);
            this.grbTotales.Controls.Add(this.lblETotEfeCaj);
            this.grbTotales.Controls.Add(this.label1);
            this.grbTotales.Controls.Add(this.lblTotEfeMos);
            this.grbTotales.Controls.Add(this.lblETotEfeMos);
            this.grbTotales.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbTotales.Location = new System.Drawing.Point(12, 547);
            this.grbTotales.Name = "grbTotales";
            this.grbTotales.Size = new System.Drawing.Size(572, 72);
            this.grbTotales.TabIndex = 18;
            this.grbTotales.TabStop = false;
            this.grbTotales.Text = "Información de caja";
            // 
            // lblTotEfeCaj
            // 
            this.lblTotEfeCaj.AutoSize = true;
            this.lblTotEfeCaj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotEfeCaj.Location = new System.Drawing.Point(401, 18);
            this.lblTotEfeCaj.Name = "lblTotEfeCaj";
            this.lblTotEfeCaj.Size = new System.Drawing.Size(40, 17);
            this.lblTotEfeCaj.TabIndex = 5;
            this.lblTotEfeCaj.Text = "$0.00";
            // 
            // lblETotEfeCaj
            // 
            this.lblETotEfeCaj.AutoSize = true;
            this.lblETotEfeCaj.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETotEfeCaj.Location = new System.Drawing.Point(280, 18);
            this.lblETotEfeCaj.Name = "lblETotEfeCaj";
            this.lblETotEfeCaj.Size = new System.Drawing.Size(108, 18);
            this.lblETotEfeCaj.TabIndex = 4;
            this.lblETotEfeCaj.Text = "Efectivo en caja:";
            // 
            // lblTotEfeMos
            // 
            this.lblTotEfeMos.AutoSize = true;
            this.lblTotEfeMos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotEfeMos.Location = new System.Drawing.Point(153, 19);
            this.lblTotEfeMos.Name = "lblTotEfeMos";
            this.lblTotEfeMos.Size = new System.Drawing.Size(40, 17);
            this.lblTotEfeMos.TabIndex = 1;
            this.lblTotEfeMos.Text = "$0.00";
            // 
            // lblETotEfeMos
            // 
            this.lblETotEfeMos.AutoSize = true;
            this.lblETotEfeMos.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETotEfeMos.Location = new System.Drawing.Point(10, 19);
            this.lblETotEfeMos.Name = "lblETotEfeMos";
            this.lblETotEfeMos.Size = new System.Drawing.Size(124, 18);
            this.lblETotEfeMos.TabIndex = 0;
            this.lblETotEfeMos.Text = "Efectivo mostrado:";
            // 
            // btnAbrirCerrar
            // 
            this.btnAbrirCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAbrirCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAbrirCerrar.FlatAppearance.BorderSize = 0;
            this.btnAbrirCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnAbrirCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAbrirCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCerrar.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnAbrirCerrar.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCerrar.Location = new System.Drawing.Point(12, 625);
            this.btnAbrirCerrar.Name = "btnAbrirCerrar";
            this.btnAbrirCerrar.Size = new System.Drawing.Size(200, 60);
            this.btnAbrirCerrar.TabIndex = 19;
            this.btnAbrirCerrar.Text = "Abrir caja (F1)";
            this.btnAbrirCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCerrar.UseVisualStyleBackColor = false;
            this.btnAbrirCerrar.Click += new System.EventHandler(this.btnAbrirCerrar_Click);
            // 
            // bgwBusqueda
            // 
            this.bgwBusqueda.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBusqueda_DoWork);
            this.bgwBusqueda.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBusqueda_RunWorkerCompleted);
            // 
            // tmrEspera
            // 
            this.tmrEspera.Interval = 300;
            this.tmrEspera.Tick += new System.EventHandler(this.tmrEspera_Tick);
            // 
            // btnCortes
            // 
            this.btnCortes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCortes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCortes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCortes.FlatAppearance.BorderSize = 0;
            this.btnCortes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCortes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCortes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCortes.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnCortes.ForeColor = System.Drawing.Color.White;
            this.btnCortes.Location = new System.Drawing.Point(866, 547);
            this.btnCortes.Name = "btnCortes";
            this.btnCortes.Size = new System.Drawing.Size(200, 60);
            this.btnCortes.TabIndex = 20;
            this.btnCortes.Text = "Cortes de caja (F4)";
            this.btnCortes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCortes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCortes.UseVisualStyleBackColor = false;
            this.btnCortes.Click += new System.EventHandler(this.btnCortes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11F);
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vouchers mostrados:";
            // 
            // lblTotVouMos
            // 
            this.lblTotVouMos.AutoSize = true;
            this.lblTotVouMos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotVouMos.Location = new System.Drawing.Point(153, 43);
            this.lblTotVouMos.Name = "lblTotVouMos";
            this.lblTotVouMos.Size = new System.Drawing.Size(40, 17);
            this.lblTotVouMos.TabIndex = 1;
            this.lblTotVouMos.Text = "$0.00";
            // 
            // lblVoucher
            // 
            this.lblVoucher.AutoSize = true;
            this.lblVoucher.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblVoucher.Location = new System.Drawing.Point(280, 42);
            this.lblVoucher.Name = "lblVoucher";
            this.lblVoucher.Size = new System.Drawing.Size(115, 18);
            this.lblVoucher.TabIndex = 4;
            this.lblVoucher.Text = "Vouchers en caja:";
            // 
            // lblTotVouCaj
            // 
            this.lblTotVouCaj.AutoSize = true;
            this.lblTotVouCaj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotVouCaj.Location = new System.Drawing.Point(401, 42);
            this.lblTotVouCaj.Name = "lblTotVouCaj";
            this.lblTotVouCaj.Size = new System.Drawing.Size(40, 17);
            this.lblTotVouCaj.TabIndex = 5;
            this.lblTotVouCaj.Text = "$0.00";
            // 
            // frmCaja
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 697);
            this.Controls.Add(this.btnCortes);
            this.Controls.Add(this.btnAbrirCerrar);
            this.Controls.Add(this.grbTotales);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.grbFechas);
            this.Controls.Add(this.grbFolio);
            this.Controls.Add(this.dgvCaja);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.KeyPreview = true;
            this.Name = "frmCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCaja_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCaja_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.grbFechas.ResumeLayout(false);
            this.grbFolio.ResumeLayout(false);
            this.grbFolio.PerformLayout();
            this.grbTotales.ResumeLayout(false);
            this.grbTotales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaja;
        private System.Windows.Forms.GroupBox grbFechas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.GroupBox grbFolio;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.GroupBox grbTotales;
        private System.Windows.Forms.Label lblTotEfeCaj;
        private System.Windows.Forms.Label lblETotEfeCaj;
        private System.Windows.Forms.Label lblTotEfeMos;
        private System.Windows.Forms.Label lblETotEfeMos;
        private System.Windows.Forms.Button btnAbrirCerrar;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVouchers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoMovimiento;
        private System.Windows.Forms.Button btnCortes;
        private System.Windows.Forms.Label lblTotVouCaj;
        private System.Windows.Forms.Label lblVoucher;
        private System.Windows.Forms.Label lblTotVouMos;
        private System.Windows.Forms.Label label1;
    }
}