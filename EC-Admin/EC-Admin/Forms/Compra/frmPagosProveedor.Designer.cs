namespace EC_Admin.Forms
{
    partial class frmPagosProveedor
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
            this.btnRelizarPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelizarPago
            // 
            this.btnRelizarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelizarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnRelizarPago.FlatAppearance.BorderSize = 0;
            this.btnRelizarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnRelizarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRelizarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelizarPago.Font = new System.Drawing.Font("Corbel", 11F);
            this.btnRelizarPago.ForeColor = System.Drawing.Color.White;
            this.btnRelizarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelizarPago.Location = new System.Drawing.Point(12, 27);
            this.btnRelizarPago.Name = "btnRelizarPago";
            this.btnRelizarPago.Size = new System.Drawing.Size(150, 46);
            this.btnRelizarPago.TabIndex = 16;
            this.btnRelizarPago.Text = "Realizar Pago";
            this.btnRelizarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelizarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRelizarPago.UseVisualStyleBackColor = false;
            // 
            // frmPagosProveedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 448);
            this.Controls.Add(this.btnRelizarPago);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPagosProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos a Proveedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelizarPago;
    }
}