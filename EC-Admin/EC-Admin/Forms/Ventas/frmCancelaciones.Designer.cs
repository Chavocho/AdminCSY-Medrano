namespace EC_Admin.Forms
{
    partial class frmCancelaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbFechas = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.grbFolio = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFechas.SuspendLayout();
            this.grbFolio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFechas
            // 
            this.grbFechas.Controls.Add(this.btnBuscar);
            this.grbFechas.Controls.Add(this.dtpFechaFin);
            this.grbFechas.Controls.Add(this.dtpFechaInicio);
            this.grbFechas.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.grbFechas.Location = new System.Drawing.Point(108, 12);
            this.grbFechas.Name = "grbFechas";
            this.grbFechas.Size = new System.Drawing.Size(621, 56);
            this.grbFechas.TabIndex = 2;
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
            this.grbFolio.Controls.Add(this.txtBusqueda);
            this.grbFolio.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbFolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.grbFolio.Location = new System.Drawing.Point(735, 12);
            this.grbFolio.Name = "grbFolio";
            this.grbFolio.Size = new System.Drawing.Size(261, 56);
            this.grbFolio.TabIndex = 3;
            this.grbFolio.TabStop = false;
            this.grbFolio.Text = "Búsqueda por folio";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtBusqueda.Location = new System.Drawing.Point(6, 21);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(249, 29);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CCliente,
            this.CVendedor,
            this.CTotal,
            this.CTipoPago,
            this.CFecha});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvVentas.Location = new System.Drawing.Point(12, 74);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(984, 323);
            this.dgvVentas.TabIndex = 13;
            this.dgvVentas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_RowEnter);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(846, 403);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Cancelar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            // CID
            // 
            this.CID.HeaderText = "Folio";
            this.CID.Name = "CID";
            // 
            // CCliente
            // 
            this.CCliente.HeaderText = "Cliente";
            this.CCliente.Name = "CCliente";
            this.CCliente.Width = 220;
            // 
            // CVendedor
            // 
            this.CVendedor.HeaderText = "Vendedor";
            this.CVendedor.Name = "CVendedor";
            this.CVendedor.Width = 220;
            // 
            // CTotal
            // 
            dataGridViewCellStyle28.Format = "C2";
            this.CTotal.DefaultCellStyle = dataGridViewCellStyle28;
            this.CTotal.HeaderText = "Total de venta";
            this.CTotal.Name = "CTotal";
            this.CTotal.Width = 120;
            // 
            // CTipoPago
            // 
            this.CTipoPago.HeaderText = "Tipo de pago";
            this.CTipoPago.Name = "CTipoPago";
            this.CTipoPago.Width = 120;
            // 
            // CFecha
            // 
            this.CFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle29.Format = "dd \'de\' MMMM \'del\' yyyy ";
            this.CFecha.DefaultCellStyle = dataGridViewCellStyle29;
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            // 
            // frmCancelaciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.grbFechas);
            this.Controls.Add(this.grbFolio);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmCancelaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar ventas";
            this.grbFechas.ResumeLayout(false);
            this.grbFolio.ResumeLayout(false);
            this.grbFolio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFechas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.GroupBox grbFolio;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnAceptar;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
    }
}