namespace EC_Admin.Forms
{
    partial class frmReporteVentas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.grbFechas = new System.Windows.Forms.GroupBox();
            this.btnBuscarFechas = new System.Windows.Forms.Button();
            this.lblEFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblEFechaInicio = new System.Windows.Forms.Label();
            this.chbTrabajador = new System.Windows.Forms.CheckBox();
            this.lblEVendedorBusqueda = new System.Windows.Forms.Label();
            this.btnBuscarTrabajador = new System.Windows.Forms.Button();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.chrInformacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbInformacion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.grbFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrInformacion)).BeginInit();
            this.grbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFechas
            // 
            this.grbFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFechas.Controls.Add(this.btnBuscarFechas);
            this.grbFechas.Controls.Add(this.lblEFechaFin);
            this.grbFechas.Controls.Add(this.dtpFechaFin);
            this.grbFechas.Controls.Add(this.lblEFechaInicio);
            this.grbFechas.Controls.Add(this.chbTrabajador);
            this.grbFechas.Controls.Add(this.lblEVendedorBusqueda);
            this.grbFechas.Controls.Add(this.btnBuscarTrabajador);
            this.grbFechas.Controls.Add(this.cboVendedor);
            this.grbFechas.Controls.Add(this.dtpFechaInicio);
            this.grbFechas.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbFechas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.grbFechas.Location = new System.Drawing.Point(12, 12);
            this.grbFechas.Name = "grbFechas";
            this.grbFechas.Size = new System.Drawing.Size(984, 109);
            this.grbFechas.TabIndex = 2;
            this.grbFechas.TabStop = false;
            this.grbFechas.Text = "Búsqueda";
            // 
            // btnBuscarFechas
            // 
            this.btnBuscarFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarFechas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnBuscarFechas.FlatAppearance.BorderSize = 0;
            this.btnBuscarFechas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnBuscarFechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnBuscarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFechas.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnBuscarFechas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFechas.Location = new System.Drawing.Point(431, 70);
            this.btnBuscarFechas.Name = "btnBuscarFechas";
            this.btnBuscarFechas.Size = new System.Drawing.Size(97, 30);
            this.btnBuscarFechas.TabIndex = 38;
            this.btnBuscarFechas.Tag = "";
            this.btnBuscarFechas.Text = "Buscar";
            this.btnBuscarFechas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarFechas.UseVisualStyleBackColor = false;
            this.btnBuscarFechas.Click += new System.EventHandler(this.btnBuscarFechas_Click);
            // 
            // lblEFechaFin
            // 
            this.lblEFechaFin.AutoSize = true;
            this.lblEFechaFin.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaFin.Location = new System.Drawing.Point(267, 18);
            this.lblEFechaFin.Name = "lblEFechaFin";
            this.lblEFechaFin.Size = new System.Drawing.Size(82, 18);
            this.lblEFechaFin.TabIndex = 37;
            this.lblEFechaFin.Text = "Fecha de fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Corbel", 11F);
            this.dtpFechaFin.Location = new System.Drawing.Point(270, 39);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(258, 25);
            this.dtpFechaFin.TabIndex = 36;
            // 
            // lblEFechaInicio
            // 
            this.lblEFechaInicio.AutoSize = true;
            this.lblEFechaInicio.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaInicio.Location = new System.Drawing.Point(3, 18);
            this.lblEFechaInicio.Name = "lblEFechaInicio";
            this.lblEFechaInicio.Size = new System.Drawing.Size(98, 18);
            this.lblEFechaInicio.TabIndex = 35;
            this.lblEFechaInicio.Text = "Fecha de inicio";
            // 
            // chbTrabajador
            // 
            this.chbTrabajador.AutoSize = true;
            this.chbTrabajador.Font = new System.Drawing.Font("Corbel", 11F);
            this.chbTrabajador.Location = new System.Drawing.Point(534, 42);
            this.chbTrabajador.Name = "chbTrabajador";
            this.chbTrabajador.Size = new System.Drawing.Size(173, 22);
            this.chbTrabajador.TabIndex = 34;
            this.chbTrabajador.Text = "Búsqueda por vendedor";
            this.chbTrabajador.UseVisualStyleBackColor = true;
            // 
            // lblEVendedorBusqueda
            // 
            this.lblEVendedorBusqueda.AutoSize = true;
            this.lblEVendedorBusqueda.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEVendedorBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEVendedorBusqueda.Location = new System.Drawing.Point(717, 18);
            this.lblEVendedorBusqueda.Name = "lblEVendedorBusqueda";
            this.lblEVendedorBusqueda.Size = new System.Drawing.Size(139, 18);
            this.lblEVendedorBusqueda.TabIndex = 33;
            this.lblEVendedorBusqueda.Text = "Seleccionar vendedor";
            // 
            // btnBuscarTrabajador
            // 
            this.btnBuscarTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarTrabajador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnBuscarTrabajador.FlatAppearance.BorderSize = 0;
            this.btnBuscarTrabajador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnBuscarTrabajador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnBuscarTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTrabajador.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnBuscarTrabajador.ForeColor = System.Drawing.Color.White;
            this.btnBuscarTrabajador.Location = new System.Drawing.Point(881, 73);
            this.btnBuscarTrabajador.Name = "btnBuscarTrabajador";
            this.btnBuscarTrabajador.Size = new System.Drawing.Size(97, 30);
            this.btnBuscarTrabajador.TabIndex = 2;
            this.btnBuscarTrabajador.Tag = "";
            this.btnBuscarTrabajador.Text = "Buscar";
            this.btnBuscarTrabajador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarTrabajador.UseVisualStyleBackColor = false;
            this.btnBuscarTrabajador.Click += new System.EventHandler(this.btnBuscarTrabajador_Click);
            // 
            // cboVendedor
            // 
            this.cboVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVendedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(720, 39);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(258, 28);
            this.cboVendedor.TabIndex = 32;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Corbel", 11F);
            this.dtpFechaInicio.Location = new System.Drawing.Point(6, 39);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(258, 25);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // chrInformacion
            // 
            this.chrInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chrInformacion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrInformacion.Legends.Add(legend1);
            this.chrInformacion.Location = new System.Drawing.Point(12, 127);
            this.chrInformacion.Name = "chrInformacion";
            this.chrInformacion.Size = new System.Drawing.Size(984, 430);
            this.chrInformacion.TabIndex = 3;
            this.chrInformacion.Text = "Reporte de venta";
            // 
            // grbInformacion
            // 
            this.grbInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbInformacion.Controls.Add(this.label5);
            this.grbInformacion.Controls.Add(this.label6);
            this.grbInformacion.Controls.Add(this.label7);
            this.grbInformacion.Controls.Add(this.label8);
            this.grbInformacion.Controls.Add(this.label3);
            this.grbInformacion.Controls.Add(this.label4);
            this.grbInformacion.Controls.Add(this.label2);
            this.grbInformacion.Controls.Add(this.label1);
            this.grbInformacion.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbInformacion.Location = new System.Drawing.Point(12, 563);
            this.grbInformacion.Name = "grbInformacion";
            this.grbInformacion.Size = new System.Drawing.Size(984, 86);
            this.grbInformacion.TabIndex = 4;
            this.grbInformacion.TabStop = false;
            this.grbInformacion.Text = "Información";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(590, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13F);
            this.label6.Location = new System.Drawing.Point(437, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total de vouchers:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(590, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 13F);
            this.label8.Location = new System.Drawing.Point(444, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total de efectivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(157, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13F);
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ventas realizadas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(157, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13F);
            this.label1.Location = new System.Drawing.Point(98, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
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
            // frmReporteVentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.grbInformacion);
            this.Controls.Add(this.chrInformacion);
            this.Controls.Add(this.grbFechas);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporteVentas_Load);
            this.grbFechas.ResumeLayout(false);
            this.grbFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrInformacion)).EndInit();
            this.grbInformacion.ResumeLayout(false);
            this.grbInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFechas;
        private System.Windows.Forms.Label lblEFechaInicio;
        private System.Windows.Forms.CheckBox chbTrabajador;
        private System.Windows.Forms.Label lblEVendedorBusqueda;
        private System.Windows.Forms.Button btnBuscarTrabajador;
        private System.Windows.Forms.ComboBox cboVendedor;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnBuscarFechas;
        private System.Windows.Forms.Label lblEFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrInformacion;
        private System.Windows.Forms.GroupBox grbInformacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
    }
}