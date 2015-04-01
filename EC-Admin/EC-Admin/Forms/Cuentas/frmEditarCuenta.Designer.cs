﻿namespace EC_Admin.Forms
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
            this.btnAceptar.Location = new System.Drawing.Point(388, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 46);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Modificar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtNumCuenta.Location = new System.Drawing.Point(14, 147);
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(259, 29);
            this.txtNumCuenta.TabIndex = 29;
            // 
            // lblENumCuenta
            // 
            this.lblENumCuenta.AutoSize = true;
            this.lblENumCuenta.Location = new System.Drawing.Point(11, 126);
            this.lblENumCuenta.Name = "lblENumCuenta";
            this.lblENumCuenta.Size = new System.Drawing.Size(121, 18);
            this.lblENumCuenta.TabIndex = 28;
            this.lblENumCuenta.Text = "Número de cuenta";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtSucursal.Location = new System.Drawing.Point(279, 89);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(259, 29);
            this.txtSucursal.TabIndex = 27;
            // 
            // lblESucursal
            // 
            this.lblESucursal.AutoSize = true;
            this.lblESucursal.Location = new System.Drawing.Point(276, 68);
            this.lblESucursal.Name = "lblESucursal";
            this.lblESucursal.Size = new System.Drawing.Size(60, 18);
            this.lblESucursal.TabIndex = 26;
            this.lblESucursal.Text = "Sucursal";
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBeneficiario.Location = new System.Drawing.Point(14, 89);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.Size = new System.Drawing.Size(259, 29);
            this.txtBeneficiario.TabIndex = 25;
            // 
            // lblEBeneficiario
            // 
            this.lblEBeneficiario.AutoSize = true;
            this.lblEBeneficiario.Location = new System.Drawing.Point(11, 68);
            this.lblEBeneficiario.Name = "lblEBeneficiario";
            this.lblEBeneficiario.Size = new System.Drawing.Size(80, 18);
            this.lblEBeneficiario.TabIndex = 24;
            this.lblEBeneficiario.Text = "Beneficiario";
            // 
            // txtBanco
            // 
            this.txtBanco.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtBanco.Location = new System.Drawing.Point(279, 31);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(259, 29);
            this.txtBanco.TabIndex = 23;
            // 
            // lblEBanco
            // 
            this.lblEBanco.AutoSize = true;
            this.lblEBanco.Location = new System.Drawing.Point(276, 10);
            this.lblEBanco.Name = "lblEBanco";
            this.lblEBanco.Size = new System.Drawing.Size(47, 18);
            this.lblEBanco.TabIndex = 22;
            this.lblEBanco.Text = "Banco";
            // 
            // txtClabe
            // 
            this.txtClabe.Font = new System.Drawing.Font("Corbel", 13F);
            this.txtClabe.Location = new System.Drawing.Point(14, 31);
            this.txtClabe.Name = "txtClabe";
            this.txtClabe.Size = new System.Drawing.Size(259, 29);
            this.txtClabe.TabIndex = 21;
            // 
            // lblEClabe
            // 
            this.lblEClabe.AutoSize = true;
            this.lblEClabe.Location = new System.Drawing.Point(11, 10);
            this.lblEClabe.Name = "lblEClabe";
            this.lblEClabe.Size = new System.Drawing.Size(42, 18);
            this.lblEClabe.TabIndex = 20;
            this.lblEClabe.Text = "Clabe";
            // 
            // frmEditarCuenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 265);
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
    }
}