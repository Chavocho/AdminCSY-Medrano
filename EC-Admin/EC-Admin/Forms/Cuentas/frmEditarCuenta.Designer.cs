namespace EC_Admin.Forms
{
    partial class frmEditarCuenta
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.lblENumCuenta = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.lblESucursal = new System.Windows.Forms.Label();
            this.txtBeneficiario = new System.Windows.Forms.TextBox();
            this.lblEBeneficiario = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.lblEBanco = new System.Windows.Forms.Label();
            this.txtClabe = new System.Windows.Forms.TextBox();
            this.lblEClabe = new System.Windows.Forms.Label();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblETipoCuenta = new System.Windows.Forms.Label();
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
            this.btnAceptar.Location = new System.Drawing.Point(388, 207);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCuenta.Location = new System.Drawing.Point(14, 147);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(259, 27);
            this.txtNumCuenta.TabIndex = 9;
            this.txtNumCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // lblENumCuenta
            // 
            this.lblENumCuenta.AutoSize = true;
            this.lblENumCuenta.Location = new System.Drawing.Point(11, 126);
            this.lblENumCuenta.Name = "lblENumCuenta";
            this.lblENumCuenta.Size = new System.Drawing.Size(121, 18);
            this.lblENumCuenta.TabIndex = 8;
            this.lblENumCuenta.Text = "Número de cuenta";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSucursal.Location = new System.Drawing.Point(279, 89);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(259, 27);
            this.txtSucursal.TabIndex = 7;
            // 
            // lblESucursal
            // 
            this.lblESucursal.AutoSize = true;
            this.lblESucursal.Location = new System.Drawing.Point(276, 68);
            this.lblESucursal.Name = "lblESucursal";
            this.lblESucursal.Size = new System.Drawing.Size(60, 18);
            this.lblESucursal.TabIndex = 6;
            this.lblESucursal.Text = "Sucursal";
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeneficiario.Location = new System.Drawing.Point(14, 89);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.Size = new System.Drawing.Size(259, 27);
            this.txtBeneficiario.TabIndex = 5;
            // 
            // lblEBeneficiario
            // 
            this.lblEBeneficiario.AutoSize = true;
            this.lblEBeneficiario.Location = new System.Drawing.Point(11, 68);
            this.lblEBeneficiario.Name = "lblEBeneficiario";
            this.lblEBeneficiario.Size = new System.Drawing.Size(80, 18);
            this.lblEBeneficiario.TabIndex = 4;
            this.lblEBeneficiario.Text = "Beneficiario";
            // 
            // txtBanco
            // 
            this.txtBanco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanco.Location = new System.Drawing.Point(279, 31);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(259, 27);
            this.txtBanco.TabIndex = 3;
            // 
            // lblEBanco
            // 
            this.lblEBanco.AutoSize = true;
            this.lblEBanco.Location = new System.Drawing.Point(276, 10);
            this.lblEBanco.Name = "lblEBanco";
            this.lblEBanco.Size = new System.Drawing.Size(47, 18);
            this.lblEBanco.TabIndex = 2;
            this.lblEBanco.Text = "Banco";
            // 
            // txtClabe
            // 
            this.txtClabe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClabe.Location = new System.Drawing.Point(14, 31);
            this.txtClabe.Name = "txtClabe";
            this.txtClabe.Size = new System.Drawing.Size(259, 27);
            this.txtClabe.TabIndex = 1;
            this.txtClabe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // lblEClabe
            // 
            this.lblEClabe.AutoSize = true;
            this.lblEClabe.Location = new System.Drawing.Point(11, 10);
            this.lblEClabe.Name = "lblEClabe";
            this.lblEClabe.Size = new System.Drawing.Size(42, 18);
            this.lblEClabe.TabIndex = 0;
            this.lblEClabe.Text = "Clabe";
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.cboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoCuenta.Font = new System.Drawing.Font("Corbel", 13F);
            this.cboTipoCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Items.AddRange(new object[] {
            "Sucursal",
            "Cliente",
            "Proveedor"});
            this.cboTipoCuenta.Location = new System.Drawing.Point(277, 147);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(259, 29);
            this.cboTipoCuenta.TabIndex = 14;
            this.cboTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cboTipoCuenta_SelectedIndexChanged);
            // 
            // lblETipoCuenta
            // 
            this.lblETipoCuenta.AutoSize = true;
            this.lblETipoCuenta.Location = new System.Drawing.Point(277, 128);
            this.lblETipoCuenta.Name = "lblETipoCuenta";
            this.lblETipoCuenta.Size = new System.Drawing.Size(99, 18);
            this.lblETipoCuenta.TabIndex = 13;
            this.lblETipoCuenta.Text = "Tipo de Cuenta";
            // 
            // frmEditarCuenta
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 265);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.lblETipoCuenta);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNumCuenta);
            this.Controls.Add(this.lblENumCuenta);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.lblESucursal);
            this.Controls.Add(this.txtBeneficiario);
            this.Controls.Add(this.lblEBeneficiario);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.lblEBanco);
            this.Controls.Add(this.txtClabe);
            this.Controls.Add(this.lblEClabe);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar cuenta";
            this.Load += new System.EventHandler(this.frmEditarCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Label lblENumCuenta;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Label lblESucursal;
        private System.Windows.Forms.TextBox txtBeneficiario;
        private System.Windows.Forms.Label lblEBeneficiario;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label lblEBanco;
        private System.Windows.Forms.TextBox txtClabe;
        private System.Windows.Forms.Label lblEClabe;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.Label lblETipoCuenta;
    }
}