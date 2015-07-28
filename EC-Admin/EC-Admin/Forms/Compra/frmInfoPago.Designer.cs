namespace EC_Admin.Forms
{
    partial class frmInfoPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.grbCuentaOrigen = new System.Windows.Forms.GroupBox();
            this.lblBenefOrigen = new System.Windows.Forms.Label();
            this.lblSucOrigen = new System.Windows.Forms.Label();
            this.lblVoucher = new System.Windows.Forms.Label();
            this.lblCuentaOrigen = new System.Windows.Forms.Label();
            this.lblETotEfeCaj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBancoOrigen = new System.Windows.Forms.Label();
            this.lblETotEfeMos = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.grbCuentaDestino = new System.Windows.Forms.GroupBox();
            this.lblBenefDestino = new System.Windows.Forms.Label();
            this.lblSucDestino = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCuentaDestino = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBancoDestino = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCuentaOrigen = new System.Windows.Forms.Button();
            this.btnCuentaDestino = new System.Windows.Forms.Button();
            this.bgwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.tmrEspera = new System.Windows.Forms.Timer(this.components);
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CClabe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBeneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNumCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.grbCuentaOrigen.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.grbCuentaDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.AllowUserToResizeColumns = false;
            this.dgvCuentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvCuentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCuentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvCuentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCuentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CTipoCuenta,
            this.CClabe,
            this.CBanco,
            this.CBeneficiario,
            this.CSucursal,
            this.CNumCuenta});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCuentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvCuentas.Location = new System.Drawing.Point(12, 12);
            this.dgvCuentas.MultiSelect = false;
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCuentas.RowHeadersVisible = false;
            this.dgvCuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuentas.Size = new System.Drawing.Size(984, 265);
            this.dgvCuentas.TabIndex = 15;
            this.dgvCuentas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentas_RowEnter);
            // 
            // txtDato1
            // 
            this.txtDato1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDato1.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDato1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDato1.Location = new System.Drawing.Point(6, 46);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(307, 29);
            this.txtDato1.TabIndex = 19;
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblDato1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblDato1.Location = new System.Drawing.Point(6, 22);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(90, 18);
            this.lblDato1.TabIndex = 20;
            this.lblDato1.Text = "N° de cheque";
            // 
            // grbCuentaOrigen
            // 
            this.grbCuentaOrigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbCuentaOrigen.Controls.Add(this.lblBenefOrigen);
            this.grbCuentaOrigen.Controls.Add(this.lblSucOrigen);
            this.grbCuentaOrigen.Controls.Add(this.lblVoucher);
            this.grbCuentaOrigen.Controls.Add(this.lblCuentaOrigen);
            this.grbCuentaOrigen.Controls.Add(this.lblETotEfeCaj);
            this.grbCuentaOrigen.Controls.Add(this.label1);
            this.grbCuentaOrigen.Controls.Add(this.lblBancoOrigen);
            this.grbCuentaOrigen.Controls.Add(this.lblETotEfeMos);
            this.grbCuentaOrigen.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbCuentaOrigen.Location = new System.Drawing.Point(337, 283);
            this.grbCuentaOrigen.Name = "grbCuentaOrigen";
            this.grbCuentaOrigen.Size = new System.Drawing.Size(326, 141);
            this.grbCuentaOrigen.TabIndex = 21;
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
            // lblVoucher
            // 
            this.lblVoucher.AutoSize = true;
            this.lblVoucher.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblVoucher.Location = new System.Drawing.Point(10, 81);
            this.lblVoucher.Name = "lblVoucher";
            this.lblVoucher.Size = new System.Drawing.Size(64, 18);
            this.lblVoucher.TabIndex = 4;
            this.lblVoucher.Text = "Sucursal:";
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
            // lblETotEfeCaj
            // 
            this.lblETotEfeCaj.AutoSize = true;
            this.lblETotEfeCaj.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETotEfeCaj.Location = new System.Drawing.Point(10, 113);
            this.lblETotEfeCaj.Name = "lblETotEfeCaj";
            this.lblETotEfeCaj.Size = new System.Drawing.Size(84, 18);
            this.lblETotEfeCaj.TabIndex = 4;
            this.lblETotEfeCaj.Text = "Beneficiario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11F);
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de cuenta:";
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
            // lblETotEfeMos
            // 
            this.lblETotEfeMos.AutoSize = true;
            this.lblETotEfeMos.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETotEfeMos.Location = new System.Drawing.Point(10, 19);
            this.lblETotEfeMos.Name = "lblETotEfeMos";
            this.lblETotEfeMos.Size = new System.Drawing.Size(51, 18);
            this.lblETotEfeMos.TabIndex = 0;
            this.lblETotEfeMos.Text = "Banco:";
            // 
            // grbInfo
            // 
            this.grbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbInfo.Controls.Add(this.txtConcepto);
            this.grbInfo.Controls.Add(this.lblConcepto);
            this.grbInfo.Controls.Add(this.txtDato2);
            this.grbInfo.Controls.Add(this.lblDato2);
            this.grbInfo.Controls.Add(this.txtDato1);
            this.grbInfo.Controls.Add(this.lblDato1);
            this.grbInfo.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbInfo.Location = new System.Drawing.Point(12, 283);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(319, 250);
            this.grbInfo.TabIndex = 21;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Pago por Cheque";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConcepto.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtConcepto.Location = new System.Drawing.Point(6, 161);
            this.txtConcepto.Multiline = true;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(307, 83);
            this.txtConcepto.TabIndex = 19;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblConcepto.Location = new System.Drawing.Point(6, 136);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(120, 18);
            this.lblConcepto.TabIndex = 20;
            this.lblConcepto.Text = "Concepto de pago";
            // 
            // txtDato2
            // 
            this.txtDato2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDato2.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtDato2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtDato2.Location = new System.Drawing.Point(9, 102);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(307, 29);
            this.txtDato2.TabIndex = 19;
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblDato2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblDato2.Location = new System.Drawing.Point(6, 80);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(80, 18);
            this.lblDato2.TabIndex = 20;
            this.lblDato2.Text = "Beneficiario";
            // 
            // grbCuentaDestino
            // 
            this.grbCuentaDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbCuentaDestino.Controls.Add(this.lblBenefDestino);
            this.grbCuentaDestino.Controls.Add(this.lblSucDestino);
            this.grbCuentaDestino.Controls.Add(this.label4);
            this.grbCuentaDestino.Controls.Add(this.lblCuentaDestino);
            this.grbCuentaDestino.Controls.Add(this.label6);
            this.grbCuentaDestino.Controls.Add(this.label7);
            this.grbCuentaDestino.Controls.Add(this.lblBancoDestino);
            this.grbCuentaDestino.Controls.Add(this.label9);
            this.grbCuentaDestino.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbCuentaDestino.Location = new System.Drawing.Point(668, 283);
            this.grbCuentaDestino.Name = "grbCuentaDestino";
            this.grbCuentaDestino.Size = new System.Drawing.Size(327, 141);
            this.grbCuentaDestino.TabIndex = 21;
            this.grbCuentaDestino.TabStop = false;
            this.grbCuentaDestino.Text = "Información de cuenta destino";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11F);
            this.label4.Location = new System.Drawing.Point(10, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sucursal:";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11F);
            this.label6.Location = new System.Drawing.Point(10, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Beneficiario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 11F);
            this.label7.Location = new System.Drawing.Point(10, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "N° de cuenta:";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 11F);
            this.label9.Location = new System.Drawing.Point(10, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Banco:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Corbel", 13F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(796, 534);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(200, 60);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCuentaOrigen
            // 
            this.btnCuentaOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCuentaOrigen.FlatAppearance.BorderSize = 0;
            this.btnCuentaOrigen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCuentaOrigen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCuentaOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaOrigen.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnCuentaOrigen.ForeColor = System.Drawing.Color.White;
            this.btnCuentaOrigen.Location = new System.Drawing.Point(337, 430);
            this.btnCuentaOrigen.Name = "btnCuentaOrigen";
            this.btnCuentaOrigen.Size = new System.Drawing.Size(175, 46);
            this.btnCuentaOrigen.TabIndex = 57;
            this.btnCuentaOrigen.Text = "Asignar cuenta origen";
            this.btnCuentaOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCuentaOrigen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentaOrigen.UseVisualStyleBackColor = false;
            this.btnCuentaOrigen.Click += new System.EventHandler(this.btnCuentaOrigen_Click);
            // 
            // btnCuentaDestino
            // 
            this.btnCuentaDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnCuentaDestino.FlatAppearance.BorderSize = 0;
            this.btnCuentaDestino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnCuentaDestino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCuentaDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentaDestino.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnCuentaDestino.ForeColor = System.Drawing.Color.White;
            this.btnCuentaDestino.Location = new System.Drawing.Point(668, 430);
            this.btnCuentaDestino.Name = "btnCuentaDestino";
            this.btnCuentaDestino.Size = new System.Drawing.Size(175, 46);
            this.btnCuentaDestino.TabIndex = 57;
            this.btnCuentaDestino.Text = "Asignar cuenta destino";
            this.btnCuentaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCuentaDestino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentaDestino.UseVisualStyleBackColor = false;
            this.btnCuentaDestino.Click += new System.EventHandler(this.btnCuentaDestino_Click);
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
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CTipoCuenta
            // 
            this.CTipoCuenta.HeaderText = "Tipo de cuenta";
            this.CTipoCuenta.Name = "CTipoCuenta";
            this.CTipoCuenta.Width = 130;
            // 
            // CClabe
            // 
            this.CClabe.HeaderText = "Clabe";
            this.CClabe.Name = "CClabe";
            this.CClabe.Width = 130;
            // 
            // CBanco
            // 
            this.CBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CBanco.HeaderText = "Banco";
            this.CBanco.Name = "CBanco";
            // 
            // CBeneficiario
            // 
            this.CBeneficiario.HeaderText = "Beneficiario";
            this.CBeneficiario.Name = "CBeneficiario";
            this.CBeneficiario.Width = 200;
            // 
            // CSucursal
            // 
            this.CSucursal.HeaderText = "Sucursal";
            this.CSucursal.Name = "CSucursal";
            this.CSucursal.Width = 150;
            // 
            // CNumCuenta
            // 
            this.CNumCuenta.HeaderText = "Núm. de Cuenta";
            this.CNumCuenta.Name = "CNumCuenta";
            this.CNumCuenta.Width = 130;
            // 
            // frmInfoPago
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 606);
            this.Controls.Add(this.btnCuentaDestino);
            this.Controls.Add(this.btnCuentaOrigen);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.grbCuentaDestino);
            this.Controls.Add(this.grbCuentaOrigen);
            this.Controls.Add(this.dgvCuentas);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInfoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion de pago";
            this.Load += new System.EventHandler(this.frmInfoPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.grbCuentaOrigen.ResumeLayout(false);
            this.grbCuentaOrigen.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grbCuentaDestino.ResumeLayout(false);
            this.grbCuentaDestino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.GroupBox grbCuentaOrigen;
        private System.Windows.Forms.Label lblBenefOrigen;
        private System.Windows.Forms.Label lblSucOrigen;
        private System.Windows.Forms.Label lblVoucher;
        private System.Windows.Forms.Label lblCuentaOrigen;
        private System.Windows.Forms.Label lblETotEfeCaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBancoOrigen;
        private System.Windows.Forms.Label lblETotEfeMos;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.GroupBox grbCuentaDestino;
        private System.Windows.Forms.Label lblBenefDestino;
        private System.Windows.Forms.Label lblSucDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCuentaDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBancoDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCuentaOrigen;
        private System.Windows.Forms.Button btnCuentaDestino;
        private System.ComponentModel.BackgroundWorker bgwBusqueda;
        private System.Windows.Forms.Timer tmrEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CClabe;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBeneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumCuenta;
    }
}