namespace EC_Admin.Forms.Traspasos
{
    partial class frmTraspasos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblETipoPrecio = new System.Windows.Forms.Label();
            this.cboTipoPrecio = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblEFechaFin = new System.Windows.Forms.Label();
            this.lblEFechaIni = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToResizeColumns = false;
            this.dgvCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CFecha,
            this.CTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Corbel", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompras.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCompras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvCompras.Location = new System.Drawing.Point(193, 65);
            this.dgvCompras.MultiSelect = false;
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(803, 384);
            this.dgvCompras.TabIndex = 4;
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
            // 
            // CFecha
            // 
            this.CFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CFecha.HeaderText = "Fecha";
            this.CFecha.Name = "CFecha";
            // 
            // CTotal
            // 
            dataGridViewCellStyle7.Format = "C2";
            this.CTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.CTotal.HeaderText = "Total";
            this.CTotal.Name = "CTotal";
            this.CTotal.Width = 150;
            // 
            // lblETipoPrecio
            // 
            this.lblETipoPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblETipoPrecio.AutoSize = true;
            this.lblETipoPrecio.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblETipoPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETipoPrecio.Location = new System.Drawing.Point(243, 9);
            this.lblETipoPrecio.Name = "lblETipoPrecio";
            this.lblETipoPrecio.Size = new System.Drawing.Size(115, 18);
            this.lblETipoPrecio.TabIndex = 41;
            this.lblETipoPrecio.Text = "Buscar traspasos:";
            this.lblETipoPrecio.Visible = false;
            // 
            // cboTipoPrecio
            // 
            this.cboTipoPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPrecio.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboTipoPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboTipoPrecio.FormattingEnabled = true;
            this.cboTipoPrecio.Items.AddRange(new object[] {
            "Precio normal",
            "Precio medio mayoreo",
            "Precio mayoreo"});
            this.cboTipoPrecio.Location = new System.Drawing.Point(246, 30);
            this.cboTipoPrecio.Name = "cboTipoPrecio";
            this.cboTipoPrecio.Size = new System.Drawing.Size(220, 29);
            this.cboTipoPrecio.TabIndex = 40;
            this.cboTipoPrecio.Visible = false;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd \'de\' MMMM \'del\' yyyy";
            this.dtpFechaFin.Font = new System.Drawing.Font("Corbel", 13F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(737, 30);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(259, 29);
            this.dtpFechaFin.TabIndex = 45;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.CustomFormat = "dd \'de\' MMMM \'del\' yyyy";
            this.dtpFechaIni.Font = new System.Drawing.Font("Corbel", 13F);
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIni.Location = new System.Drawing.Point(472, 30);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(259, 29);
            this.dtpFechaIni.TabIndex = 43;
            // 
            // lblEFechaFin
            // 
            this.lblEFechaFin.AutoSize = true;
            this.lblEFechaFin.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaFin.Location = new System.Drawing.Point(734, 9);
            this.lblEFechaFin.Name = "lblEFechaFin";
            this.lblEFechaFin.Size = new System.Drawing.Size(82, 18);
            this.lblEFechaFin.TabIndex = 44;
            this.lblEFechaFin.Text = "Fecha de fin";
            // 
            // lblEFechaIni
            // 
            this.lblEFechaIni.AutoSize = true;
            this.lblEFechaIni.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEFechaIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaIni.Location = new System.Drawing.Point(469, 9);
            this.lblEFechaIni.Name = "lblEFechaIni";
            this.lblEFechaIni.Size = new System.Drawing.Size(98, 18);
            this.lblEFechaIni.TabIndex = 42;
            this.lblEFechaIni.Text = "Fecha de inicio";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(12, 65);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 46);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "Nuevo traspaso";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Location = new System.Drawing.Point(12, 117);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(175, 46);
            this.btnDetalle.TabIndex = 47;
            this.btnDetalle.Text = "Detalles de traspaso";
            this.btnDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalle.UseVisualStyleBackColor = false;
            // 
            // frmTraspasos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.lblEFechaFin);
            this.Controls.Add(this.lblEFechaIni);
            this.Controls.Add(this.lblETipoPrecio);
            this.Controls.Add(this.cboTipoPrecio);
            this.Controls.Add(this.dgvCompras);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.MinimumSize = new System.Drawing.Size(1024, 500);
            this.Name = "frmTraspasos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traspasos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.Label lblETipoPrecio;
        private System.Windows.Forms.ComboBox cboTipoPrecio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblEFechaFin;
        private System.Windows.Forms.Label lblEFechaIni;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDetalle;
    }
}