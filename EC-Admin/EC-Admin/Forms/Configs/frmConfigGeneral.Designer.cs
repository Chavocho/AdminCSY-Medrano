namespace EC_Admin.Forms
{
    partial class frmConfigGeneral
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
            this.grbPOS = new System.Windows.Forms.GroupBox();
            this.lblEIVA = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbPOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPOS
            // 
            this.grbPOS.Controls.Add(this.lblEIVA);
            this.grbPOS.Controls.Add(this.txtIVA);
            this.grbPOS.Font = new System.Drawing.Font("Corbel", 9F);
            this.grbPOS.Location = new System.Drawing.Point(12, 12);
            this.grbPOS.Name = "grbPOS";
            this.grbPOS.Size = new System.Drawing.Size(505, 78);
            this.grbPOS.TabIndex = 1;
            this.grbPOS.TabStop = false;
            this.grbPOS.Text = "Punto de venta";
            // 
            // lblEIVA
            // 
            this.lblEIVA.AutoSize = true;
            this.lblEIVA.Font = new System.Drawing.Font("Corbel", 11F);
            this.lblEIVA.Location = new System.Drawing.Point(6, 18);
            this.lblEIVA.Name = "lblEIVA";
            this.lblEIVA.Size = new System.Drawing.Size(97, 18);
            this.lblEIVA.TabIndex = 6;
            this.lblEIVA.Text = "Valor del I.V.A.";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(6, 43);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(105, 27);
            this.txtIVA.TabIndex = 5;
            this.txtIVA.Text = "0";
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerosDecimal_KeyPress);
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
            this.btnAceptar.Location = new System.Drawing.Point(368, 203);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(149, 46);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmConfigGeneral
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grbPOS);
            this.Font = new System.Drawing.Font("Corbel", 11F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConfigGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración general";
            this.Load += new System.EventHandler(this.frmConfigGeneral_Load);
            this.grbPOS.ResumeLayout(false);
            this.grbPOS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPOS;
        private System.Windows.Forms.Label lblEIVA;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Button btnAceptar;
    }
}