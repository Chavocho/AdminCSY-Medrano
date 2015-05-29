﻿namespace EC_Admin.Forms
{
    partial class frmVentasDiarias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbFechas = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.lblECliente = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblEVendedor = new System.Windows.Forms.Label();
            this.bgwBusquedaVentas = new System.ComponentModel.BackgroundWorker();
            this.bgwBusquedaDetallada = new System.ComponentModel.BackgroundWorker();
            this.tmrEsperaVenta = new System.Windows.Forms.Timer(this.components);
            this.tmrEsperaDetallada = new System.Windows.Forms.Timer(this.components);
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFechas
            // 
            this.grbFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFechas.Controls.Add(this.btnBuscar);
            this.grbFechas.Controls.Add(this.dtpFechaInicio);
            this.grbFechas.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.grbFechas.Location = new System.Drawing.Point(625, 12);
            this.grbFechas.Name = "grbFechas";
            this.grbFechas.Size = new System.Drawing.Size(371, 56);
            this.grbFechas.TabIndex = 1;
            this.grbFechas.TabStop = false;
            this.grbFechas.Text = "Búsqueda por fecha";
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
            this.btnBuscar.Location = new System.Drawing.Point(268, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Corbel", 11F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(6, 25);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(250, 25);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CVendedor,
            this.CCliente,
            this.CTotal,
            this.CTipoPago,
            this.CFecha,
            this.CTipoFolio,
            this.CFolio});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvVentas.Location = new System.Drawing.Point(12, 74);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(984, 401);
            this.dgvVentas.TabIndex = 4;
            this.dgvVentas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_RowEnter);
            // 
            // pnlProductos
            // 
            this.pnlProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductos.AutoScroll = true;
            this.pnlProductos.BackColor = System.Drawing.Color.White;
            this.pnlProductos.Location = new System.Drawing.Point(12, 481);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(984, 204);
            this.pnlProductos.TabIndex = 10;
            // 
            // lblECliente
            // 
            this.lblECliente.AutoSize = true;
            this.lblECliente.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblECliente.Location = new System.Drawing.Point(31, 12);
            this.lblECliente.Name = "lblECliente";
            this.lblECliente.Size = new System.Drawing.Size(70, 22);
            this.lblECliente.TabIndex = 12;
            this.lblECliente.Text = "Cliente:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblCliente.Location = new System.Drawing.Point(107, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 22);
            this.lblCliente.TabIndex = 13;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Corbel", 13F);
            this.lblVendedor.Location = new System.Drawing.Point(107, 40);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(0, 22);
            this.lblVendedor.TabIndex = 15;
            // 
            // lblEVendedor
            // 
            this.lblEVendedor.AutoSize = true;
            this.lblEVendedor.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEVendedor.Location = new System.Drawing.Point(12, 40);
            this.lblEVendedor.Name = "lblEVendedor";
            this.lblEVendedor.Size = new System.Drawing.Size(89, 22);
            this.lblEVendedor.TabIndex = 14;
            this.lblEVendedor.Text = "Vendedor:";
            // 
            // bgwBusquedaVentas
            // 
            this.bgwBusquedaVentas.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBusquedaVentas_DoWork);
            this.bgwBusquedaVentas.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBusquedaVentas_RunWorkerCompleted);
            // 
            // bgwBusquedaDetallada
            // 
            this.bgwBusquedaDetallada.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBusquedaDetallada_DoWork);
            this.bgwBusquedaDetallada.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwBusquedaDetallada_RunWorkerCompleted);
            // 
            // tmrEsperaVenta
            // 
            this.tmrEsperaVenta.Interval = 300;
            this.tmrEsperaVenta.Tick += new System.EventHandler(this.tmrEsperaVenta_Tick);
            // 
            // tmrEsperaDetallada
            // 
            this.tmrEsperaDetallada.Interval = 300;
            this.tmrEsperaDetallada.Tick += new System.EventHandler(this.tmrEsperaDetallada_Tick);
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
            dataGridViewCellStyle3.Format = "C2";
            this.CTotal.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Format = "dd \' de \' MMMM \' del \' yyyy, hh:mm tt";
            this.CFecha.DefaultCellStyle = dataGridViewCellStyle4;
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
            // frmVentasDiarias
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 697);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblEVendedor);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblECliente);
            this.Controls.Add(this.pnlProductos);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.grbFechas);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.Name = "frmVentasDiarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas diarias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbFechas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFechas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Label lblECliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblEVendedor;
        private System.ComponentModel.BackgroundWorker bgwBusquedaVentas;
        private System.ComponentModel.BackgroundWorker bgwBusquedaDetallada;
        private System.Windows.Forms.Timer tmrEsperaVenta;
        private System.Windows.Forms.Timer tmrEsperaDetallada;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFolio;
    }
}