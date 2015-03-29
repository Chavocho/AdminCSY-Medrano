namespace EC_Admin.Forms
{
    partial class frmEditarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.lblELimiteCredito = new System.Windows.Forms.Label();
            this.cboTipoCredito = new System.Windows.Forms.ComboBox();
            this.lblETipoCredito = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblECorreo = new System.Windows.Forms.Label();
            this.lblETelefono02 = new System.Windows.Forms.Label();
            this.lblELada02 = new System.Windows.Forms.Label();
            this.lblETelefono01 = new System.Windows.Forms.Label();
            this.txtLada02 = new System.Windows.Forms.TextBox();
            this.txtTelefono02 = new System.Windows.Forms.TextBox();
            this.txtLada01 = new System.Windows.Forms.TextBox();
            this.txtTelefono01 = new System.Windows.Forms.TextBox();
            this.lblELada01 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblECP = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEEstado = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblECiudad = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblEColonia = new System.Windows.Forms.Label();
            this.txtNumInt = new System.Windows.Forms.TextBox();
            this.lblENumInt = new System.Windows.Forms.Label();
            this.txtNumExt = new System.Windows.Forms.TextBox();
            this.lblENumExt = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblECalle = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.lblERFC = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblERazonSocial = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblENombre = new System.Windows.Forms.Label();
            this.lblESucursal = new System.Windows.Forms.Label();
            this.lblEDatosCliente = new System.Windows.Forms.Label();
            this.lblEContactos = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.CCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlContactos = new System.Windows.Forms.Panel();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.lblECuenta = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.pnlContactos.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAceptar.Location = new System.Drawing.Point(651, 387);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.cboCuenta);
            this.pnlDatos.Controls.Add(this.lblECuenta);
            this.pnlDatos.Controls.Add(this.txtLimiteCredito);
            this.pnlDatos.Controls.Add(this.lblELimiteCredito);
            this.pnlDatos.Controls.Add(this.cboTipoCredito);
            this.pnlDatos.Controls.Add(this.lblETipoCredito);
            this.pnlDatos.Controls.Add(this.txtCorreo);
            this.pnlDatos.Controls.Add(this.lblECorreo);
            this.pnlDatos.Controls.Add(this.lblETelefono02);
            this.pnlDatos.Controls.Add(this.lblELada02);
            this.pnlDatos.Controls.Add(this.lblETelefono01);
            this.pnlDatos.Controls.Add(this.txtLada02);
            this.pnlDatos.Controls.Add(this.txtTelefono02);
            this.pnlDatos.Controls.Add(this.txtLada01);
            this.pnlDatos.Controls.Add(this.txtTelefono01);
            this.pnlDatos.Controls.Add(this.lblELada01);
            this.pnlDatos.Controls.Add(this.txtCP);
            this.pnlDatos.Controls.Add(this.lblECP);
            this.pnlDatos.Controls.Add(this.txtEstado);
            this.pnlDatos.Controls.Add(this.lblEEstado);
            this.pnlDatos.Controls.Add(this.txtCiudad);
            this.pnlDatos.Controls.Add(this.lblECiudad);
            this.pnlDatos.Controls.Add(this.txtColonia);
            this.pnlDatos.Controls.Add(this.lblEColonia);
            this.pnlDatos.Controls.Add(this.txtNumInt);
            this.pnlDatos.Controls.Add(this.lblENumInt);
            this.pnlDatos.Controls.Add(this.txtNumExt);
            this.pnlDatos.Controls.Add(this.lblENumExt);
            this.pnlDatos.Controls.Add(this.txtCalle);
            this.pnlDatos.Controls.Add(this.lblECalle);
            this.pnlDatos.Controls.Add(this.txtRFC);
            this.pnlDatos.Controls.Add(this.lblERFC);
            this.pnlDatos.Controls.Add(this.cboSucursal);
            this.pnlDatos.Controls.Add(this.txtRazonSocial);
            this.pnlDatos.Controls.Add(this.lblERazonSocial);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblENombre);
            this.pnlDatos.Controls.Add(this.lblESucursal);
            this.pnlDatos.Location = new System.Drawing.Point(0, 25);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(813, 356);
            this.pnlDatos.TabIndex = 2;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.BackColor = System.Drawing.Color.White;
            this.txtLimiteCredito.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtLimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtLimiteCredito.Location = new System.Drawing.Point(12, 313);
            this.txtLimiteCredito.MaxLength = 15;
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(259, 29);
            this.txtLimiteCredito.TabIndex = 35;
            this.txtLimiteCredito.Text = "0.00";
            this.txtLimiteCredito.Visible = false;
            this.txtLimiteCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteCredito_KeyPress);
            // 
            // lblELimiteCredito
            // 
            this.lblELimiteCredito.AutoSize = true;
            this.lblELimiteCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblELimiteCredito.Location = new System.Drawing.Point(9, 292);
            this.lblELimiteCredito.Name = "lblELimiteCredito";
            this.lblELimiteCredito.Size = new System.Drawing.Size(110, 18);
            this.lblELimiteCredito.TabIndex = 34;
            this.lblELimiteCredito.Text = "Límite de crédito";
            this.lblELimiteCredito.Visible = false;
            // 
            // cboTipoCredito
            // 
            this.cboTipoCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboTipoCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoCredito.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboTipoCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboTipoCredito.FormattingEnabled = true;
            this.cboTipoCredito.Items.AddRange(new object[] {
            "Sin crédito",
            "Con crédito"});
            this.cboTipoCredito.Location = new System.Drawing.Point(542, 255);
            this.cboTipoCredito.Name = "cboTipoCredito";
            this.cboTipoCredito.Size = new System.Drawing.Size(259, 29);
            this.cboTipoCredito.TabIndex = 33;
            this.cboTipoCredito.SelectedIndexChanged += new System.EventHandler(this.cboTipoCredito_SelectedIndexChanged);
            // 
            // lblETipoCredito
            // 
            this.lblETipoCredito.AutoSize = true;
            this.lblETipoCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETipoCredito.Location = new System.Drawing.Point(539, 234);
            this.lblETipoCredito.Name = "lblETipoCredito";
            this.lblETipoCredito.Size = new System.Drawing.Size(99, 18);
            this.lblETipoCredito.TabIndex = 32;
            this.lblETipoCredito.Text = "Tipo de crédito";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCorreo.Location = new System.Drawing.Point(277, 255);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 29);
            this.txtCorreo.TabIndex = 31;
            // 
            // lblECorreo
            // 
            this.lblECorreo.AutoSize = true;
            this.lblECorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECorreo.Location = new System.Drawing.Point(274, 234);
            this.lblECorreo.Name = "lblECorreo";
            this.lblECorreo.Size = new System.Drawing.Size(121, 18);
            this.lblECorreo.TabIndex = 30;
            this.lblECorreo.Text = "Correo electrónico";
            // 
            // lblETelefono02
            // 
            this.lblETelefono02.AutoSize = true;
            this.lblETelefono02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETelefono02.Location = new System.Drawing.Point(70, 234);
            this.lblETelefono02.Name = "lblETelefono02";
            this.lblETelefono02.Size = new System.Drawing.Size(61, 18);
            this.lblETelefono02.TabIndex = 28;
            this.lblETelefono02.Text = "Teléfono";
            // 
            // lblELada02
            // 
            this.lblELada02.AutoSize = true;
            this.lblELada02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblELada02.Location = new System.Drawing.Point(9, 234);
            this.lblELada02.Name = "lblELada02";
            this.lblELada02.Size = new System.Drawing.Size(38, 18);
            this.lblELada02.TabIndex = 26;
            this.lblELada02.Text = "Lada";
            // 
            // lblETelefono01
            // 
            this.lblETelefono01.AutoSize = true;
            this.lblETelefono01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblETelefono01.Location = new System.Drawing.Point(600, 176);
            this.lblETelefono01.Name = "lblETelefono01";
            this.lblETelefono01.Size = new System.Drawing.Size(61, 18);
            this.lblETelefono01.TabIndex = 24;
            this.lblETelefono01.Text = "Teléfono";
            // 
            // txtLada02
            // 
            this.txtLada02.BackColor = System.Drawing.Color.White;
            this.txtLada02.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtLada02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtLada02.Location = new System.Drawing.Point(12, 255);
            this.txtLada02.MaxLength = 45;
            this.txtLada02.Name = "txtLada02";
            this.txtLada02.Size = new System.Drawing.Size(55, 29);
            this.txtLada02.TabIndex = 27;
            // 
            // txtTelefono02
            // 
            this.txtTelefono02.BackColor = System.Drawing.Color.White;
            this.txtTelefono02.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtTelefono02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTelefono02.Location = new System.Drawing.Point(73, 255);
            this.txtTelefono02.MaxLength = 45;
            this.txtTelefono02.Name = "txtTelefono02";
            this.txtTelefono02.Size = new System.Drawing.Size(198, 29);
            this.txtTelefono02.TabIndex = 29;
            // 
            // txtLada01
            // 
            this.txtLada01.BackColor = System.Drawing.Color.White;
            this.txtLada01.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtLada01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtLada01.Location = new System.Drawing.Point(542, 197);
            this.txtLada01.MaxLength = 45;
            this.txtLada01.Name = "txtLada01";
            this.txtLada01.Size = new System.Drawing.Size(55, 29);
            this.txtLada01.TabIndex = 23;
            // 
            // txtTelefono01
            // 
            this.txtTelefono01.BackColor = System.Drawing.Color.White;
            this.txtTelefono01.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtTelefono01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTelefono01.Location = new System.Drawing.Point(603, 197);
            this.txtTelefono01.MaxLength = 45;
            this.txtTelefono01.Name = "txtTelefono01";
            this.txtTelefono01.Size = new System.Drawing.Size(198, 29);
            this.txtTelefono01.TabIndex = 25;
            // 
            // lblELada01
            // 
            this.lblELada01.AutoSize = true;
            this.lblELada01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblELada01.Location = new System.Drawing.Point(539, 176);
            this.lblELada01.Name = "lblELada01";
            this.lblELada01.Size = new System.Drawing.Size(38, 18);
            this.lblELada01.TabIndex = 22;
            this.lblELada01.Text = "Lada";
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCP.Location = new System.Drawing.Point(277, 197);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(259, 29);
            this.txtCP.TabIndex = 21;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // lblECP
            // 
            this.lblECP.AutoSize = true;
            this.lblECP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECP.Location = new System.Drawing.Point(274, 176);
            this.lblECP.Name = "lblECP";
            this.lblECP.Size = new System.Drawing.Size(92, 18);
            this.lblECP.TabIndex = 20;
            this.lblECP.Text = "Código postal";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtEstado.Location = new System.Drawing.Point(12, 197);
            this.txtEstado.MaxLength = 45;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(259, 29);
            this.txtEstado.TabIndex = 19;
            // 
            // lblEEstado
            // 
            this.lblEEstado.AutoSize = true;
            this.lblEEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEEstado.Location = new System.Drawing.Point(9, 176);
            this.lblEEstado.Name = "lblEEstado";
            this.lblEEstado.Size = new System.Drawing.Size(50, 18);
            this.lblEEstado.TabIndex = 18;
            this.lblEEstado.Text = "Estado";
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.Color.White;
            this.txtCiudad.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCiudad.Location = new System.Drawing.Point(542, 139);
            this.txtCiudad.MaxLength = 45;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(259, 29);
            this.txtCiudad.TabIndex = 17;
            // 
            // lblECiudad
            // 
            this.lblECiudad.AutoSize = true;
            this.lblECiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECiudad.Location = new System.Drawing.Point(539, 118);
            this.lblECiudad.Name = "lblECiudad";
            this.lblECiudad.Size = new System.Drawing.Size(51, 18);
            this.lblECiudad.TabIndex = 16;
            this.lblECiudad.Text = "Ciudad";
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.Color.White;
            this.txtColonia.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtColonia.Location = new System.Drawing.Point(277, 139);
            this.txtColonia.MaxLength = 45;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(259, 29);
            this.txtColonia.TabIndex = 15;
            // 
            // lblEColonia
            // 
            this.lblEColonia.AutoSize = true;
            this.lblEColonia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEColonia.Location = new System.Drawing.Point(274, 118);
            this.lblEColonia.Name = "lblEColonia";
            this.lblEColonia.Size = new System.Drawing.Size(54, 18);
            this.lblEColonia.TabIndex = 14;
            this.lblEColonia.Text = "Colonia";
            // 
            // txtNumInt
            // 
            this.txtNumInt.BackColor = System.Drawing.Color.White;
            this.txtNumInt.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNumInt.Location = new System.Drawing.Point(145, 139);
            this.txtNumInt.MaxLength = 15;
            this.txtNumInt.Name = "txtNumInt";
            this.txtNumInt.Size = new System.Drawing.Size(126, 29);
            this.txtNumInt.TabIndex = 13;
            // 
            // lblENumInt
            // 
            this.lblENumInt.AutoSize = true;
            this.lblENumInt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumInt.Location = new System.Drawing.Point(140, 118);
            this.lblENumInt.Name = "lblENumInt";
            this.lblENumInt.Size = new System.Drawing.Size(105, 18);
            this.lblENumInt.TabIndex = 12;
            this.lblENumInt.Text = "Número interior";
            // 
            // txtNumExt
            // 
            this.txtNumExt.BackColor = System.Drawing.Color.White;
            this.txtNumExt.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNumExt.Location = new System.Drawing.Point(12, 139);
            this.txtNumExt.MaxLength = 15;
            this.txtNumExt.Name = "txtNumExt";
            this.txtNumExt.Size = new System.Drawing.Size(127, 29);
            this.txtNumExt.TabIndex = 11;
            // 
            // lblENumExt
            // 
            this.lblENumExt.AutoSize = true;
            this.lblENumExt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENumExt.Location = new System.Drawing.Point(9, 118);
            this.lblENumExt.Name = "lblENumExt";
            this.lblENumExt.Size = new System.Drawing.Size(108, 18);
            this.lblENumExt.TabIndex = 10;
            this.lblENumExt.Text = "Número exterior";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.White;
            this.txtCalle.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtCalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtCalle.Location = new System.Drawing.Point(542, 81);
            this.txtCalle.MaxLength = 45;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(259, 29);
            this.txtCalle.TabIndex = 9;
            // 
            // lblECalle
            // 
            this.lblECalle.AutoSize = true;
            this.lblECalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECalle.Location = new System.Drawing.Point(539, 60);
            this.lblECalle.Name = "lblECalle";
            this.lblECalle.Size = new System.Drawing.Size(37, 18);
            this.lblECalle.TabIndex = 8;
            this.lblECalle.Text = "Calle";
            // 
            // txtRFC
            // 
            this.txtRFC.BackColor = System.Drawing.Color.White;
            this.txtRFC.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtRFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRFC.Location = new System.Drawing.Point(277, 81);
            this.txtRFC.MaxLength = 13;
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(259, 29);
            this.txtRFC.TabIndex = 7;
            // 
            // lblERFC
            // 
            this.lblERFC.AutoSize = true;
            this.lblERFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblERFC.Location = new System.Drawing.Point(274, 60);
            this.lblERFC.Name = "lblERFC";
            this.lblERFC.Size = new System.Drawing.Size(34, 18);
            this.lblERFC.TabIndex = 6;
            this.lblERFC.Text = "RFC";
            // 
            // cboSucursal
            // 
            this.cboSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSucursal.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(12, 23);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(259, 29);
            this.cboSucursal.TabIndex = 1;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtRazonSocial.Location = new System.Drawing.Point(12, 81);
            this.txtRazonSocial.MaxLength = 45;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(259, 29);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // lblERazonSocial
            // 
            this.lblERazonSocial.AutoSize = true;
            this.lblERazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblERazonSocial.Location = new System.Drawing.Point(9, 60);
            this.lblERazonSocial.Name = "lblERazonSocial";
            this.lblERazonSocial.Size = new System.Drawing.Size(84, 18);
            this.lblERazonSocial.TabIndex = 4;
            this.lblERazonSocial.Text = "Razón social";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtNombre.Location = new System.Drawing.Point(542, 23);
            this.txtNombre.MaxLength = 45;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // lblENombre
            // 
            this.lblENombre.AutoSize = true;
            this.lblENombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblENombre.Location = new System.Drawing.Point(539, 2);
            this.lblENombre.Name = "lblENombre";
            this.lblENombre.Size = new System.Drawing.Size(58, 18);
            this.lblENombre.TabIndex = 2;
            this.lblENombre.Text = "Nombre";
            // 
            // lblESucursal
            // 
            this.lblESucursal.AutoSize = true;
            this.lblESucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblESucursal.Location = new System.Drawing.Point(9, 2);
            this.lblESucursal.Name = "lblESucursal";
            this.lblESucursal.Size = new System.Drawing.Size(60, 18);
            this.lblESucursal.TabIndex = 0;
            this.lblESucursal.Text = "Sucursal";
            // 
            // lblEDatosCliente
            // 
            this.lblEDatosCliente.AutoSize = true;
            this.lblEDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEDatosCliente.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEDatosCliente.ForeColor = System.Drawing.Color.White;
            this.lblEDatosCliente.Location = new System.Drawing.Point(0, 0);
            this.lblEDatosCliente.Name = "lblEDatosCliente";
            this.lblEDatosCliente.Size = new System.Drawing.Size(112, 22);
            this.lblEDatosCliente.TabIndex = 0;
            this.lblEDatosCliente.Text = "Datos cliente";
            this.lblEDatosCliente.Click += new System.EventHandler(this.lblEDatosCliente_Click);
            // 
            // lblEContactos
            // 
            this.lblEContactos.AutoSize = true;
            this.lblEContactos.BackColor = System.Drawing.Color.White;
            this.lblEContactos.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Bold);
            this.lblEContactos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblEContactos.Location = new System.Drawing.Point(112, 0);
            this.lblEContactos.Name = "lblEContactos";
            this.lblEContactos.Size = new System.Drawing.Size(90, 22);
            this.lblEContactos.TabIndex = 1;
            this.lblEContactos.Text = "Contactos";
            this.lblEContactos.Click += new System.EventHandler(this.lblEContactos_Click);
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.AllowUserToResizeColumns = false;
            this.dgvContactos.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvContactos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.dgvContactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvContactos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Corbel", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CID,
            this.CNombre,
            this.CTelefonos,
            this.CCorreo});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Corbel", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContactos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvContactos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvContactos.Location = new System.Drawing.Point(0, 0);
            this.dgvContactos.MultiSelect = false;
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContactos.RowHeadersVisible = false;
            this.dgvContactos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(813, 301);
            this.dgvContactos.TabIndex = 0;
            this.dgvContactos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_RowEnter);
            // 
            // CCorreo
            // 
            this.CCorreo.HeaderText = "Correo";
            this.CCorreo.Name = "CCorreo";
            this.CCorreo.Width = 200;
            // 
            // CTelefonos
            // 
            this.CTelefonos.HeaderText = "Teléfonos";
            this.CTelefonos.Name = "CTelefonos";
            this.CTelefonos.Width = 200;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CID
            // 
            this.CID.HeaderText = "ID";
            this.CID.Name = "CID";
            this.CID.Visible = false;
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
            this.btnNuevo.Location = new System.Drawing.Point(626, 307);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(175, 46);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo contacto";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(445, 307);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(175, 46);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Modificar contacto";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(264, 307);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 46);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar contacto";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlContactos
            // 
            this.pnlContactos.Controls.Add(this.btnEliminar);
            this.pnlContactos.Controls.Add(this.btnEditar);
            this.pnlContactos.Controls.Add(this.btnNuevo);
            this.pnlContactos.Controls.Add(this.dgvContactos);
            this.pnlContactos.Font = new System.Drawing.Font("Corbel", 9F);
            this.pnlContactos.Location = new System.Drawing.Point(0, 25);
            this.pnlContactos.Name = "pnlContactos";
            this.pnlContactos.Size = new System.Drawing.Size(813, 356);
            this.pnlContactos.TabIndex = 3;
            this.pnlContactos.Visible = false;
            // 
            // cboCuenta
            // 
            this.cboCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCuenta.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(277, 23);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(259, 29);
            this.cboCuenta.TabIndex = 40;
            // 
            // lblECuenta
            // 
            this.lblECuenta.AutoSize = true;
            this.lblECuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lblECuenta.Location = new System.Drawing.Point(274, 2);
            this.lblECuenta.Name = "lblECuenta";
            this.lblECuenta.Size = new System.Drawing.Size(52, 18);
            this.lblECuenta.TabIndex = 39;
            this.lblECuenta.Text = "Cuenta";
            // 
            // frmEditarCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 445);
            this.Controls.Add(this.lblEContactos);
            this.Controls.Add(this.lblEDatosCliente);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlContactos);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEditarCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar datos de";
            this.Load += new System.EventHandler(this.frmEditarCliente_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.pnlContactos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblEDatosCliente;
        private System.Windows.Forms.Label lblEContactos;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Label lblELimiteCredito;
        private System.Windows.Forms.ComboBox cboTipoCredito;
        private System.Windows.Forms.Label lblETipoCredito;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblECorreo;
        private System.Windows.Forms.Label lblETelefono02;
        private System.Windows.Forms.Label lblELada02;
        private System.Windows.Forms.Label lblETelefono01;
        private System.Windows.Forms.TextBox txtLada02;
        private System.Windows.Forms.TextBox txtTelefono02;
        private System.Windows.Forms.TextBox txtLada01;
        private System.Windows.Forms.TextBox txtTelefono01;
        private System.Windows.Forms.Label lblELada01;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblECP;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEEstado;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblECiudad;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblEColonia;
        private System.Windows.Forms.TextBox txtNumInt;
        private System.Windows.Forms.Label lblENumInt;
        private System.Windows.Forms.TextBox txtNumExt;
        private System.Windows.Forms.Label lblENumExt;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblECalle;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label lblERFC;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblERazonSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblENombre;
        private System.Windows.Forms.Label lblESucursal;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel pnlContactos;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.Label lblECuenta;
    }
}