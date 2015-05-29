namespace EC_Admin.Forms
{
    partial class frmNuevaPromocion
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
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblECantidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEPrecio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblEFechaIni = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblEProducto = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblEFechaFin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtApellidos.Location = new System.Drawing.Point(277, 139);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(259, 29);
            this.txtApellidos.TabIndex = 15;
            // 
            // lblECantidad
            // 
            this.lblECantidad.AutoSize = true;
            this.lblECantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECantidad.Location = new System.Drawing.Point(274, 118);
            this.lblECantidad.Name = "lblECantidad";
            this.lblECantidad.Size = new System.Drawing.Size(63, 18);
            this.lblECantidad.TabIndex = 14;
            this.lblECantidad.Text = "Cantidad";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNombre.Location = new System.Drawing.Point(12, 139);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 29);
            this.txtNombre.TabIndex = 13;
            // 
            // lblEPrecio
            // 
            this.lblEPrecio.AutoSize = true;
            this.lblEPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEPrecio.Location = new System.Drawing.Point(9, 118);
            this.lblEPrecio.Name = "lblEPrecio";
            this.lblEPrecio.Size = new System.Drawing.Size(47, 18);
            this.lblEPrecio.TabIndex = 12;
            this.lblEPrecio.Text = "Precio";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(386, 211);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Crear";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // lblEFechaIni
            // 
            this.lblEFechaIni.AutoSize = true;
            this.lblEFechaIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaIni.Location = new System.Drawing.Point(9, 65);
            this.lblEFechaIni.Name = "lblEFechaIni";
            this.lblEFechaIni.Size = new System.Drawing.Size(98, 18);
            this.lblEFechaIni.TabIndex = 21;
            this.lblEFechaIni.Text = "Fecha de inicio";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Corbel", 13F);
            this.checkBox1.Location = new System.Drawing.Point(12, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(296, 26);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Promoción hasta agotar existencias";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblEProducto
            // 
            this.lblEProducto.AutoSize = true;
            this.lblEProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEProducto.Location = new System.Drawing.Point(12, 9);
            this.lblEProducto.Name = "lblEProducto";
            this.lblEProducto.Size = new System.Drawing.Size(70, 18);
            this.lblEProducto.TabIndex = 23;
            this.lblEProducto.Text = "Producto:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblProducto.Location = new System.Drawing.Point(88, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(0, 18);
            this.lblProducto.TabIndex = 24;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(439, 30);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(97, 30);
            this.btnProducto.TabIndex = 25;
            this.btnProducto.Text = "Buscar producto";
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Visible = false;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.CustomFormat = "dd \'de\' MMMM \'del\' yyyy";
            this.dtpFechaIni.Font = new System.Drawing.Font("Corbel", 13F);
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIni.Location = new System.Drawing.Point(12, 86);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(259, 29);
            this.dtpFechaIni.TabIndex = 26;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd \'de\' MMMM \'del\' yyyy";
            this.dtpFechaFin.Font = new System.Drawing.Font("Corbel", 13F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(277, 86);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(259, 29);
            this.dtpFechaFin.TabIndex = 28;
            // 
            // lblEFechaFin
            // 
            this.lblEFechaFin.AutoSize = true;
            this.lblEFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEFechaFin.Location = new System.Drawing.Point(274, 65);
            this.lblEFechaFin.Name = "lblEFechaFin";
            this.lblEFechaFin.Size = new System.Drawing.Size(82, 18);
            this.lblEFechaFin.TabIndex = 27;
            this.lblEFechaFin.Text = "Fecha de fin";
            // 
            // frmNuevaPromocion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 269);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.lblEFechaFin);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblEProducto);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblEFechaIni);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblECantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEPrecio);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNuevaPromocion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear promoción";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblECantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblEFechaIni;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblEProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblEFechaFin;
    }
}