namespace apyAllia20263003
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.lblCafe = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.btnContador = new System.Windows.Forms.Button();
            this.cmbCafe = new System.Windows.Forms.ComboBox();
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // picFondo
            // 
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(-2, -3);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(503, 334);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // lblCafe
            // 
            this.lblCafe.AutoSize = true;
            this.lblCafe.BackColor = System.Drawing.Color.Transparent;
            this.lblCafe.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCafe.Location = new System.Drawing.Point(171, 65);
            this.lblCafe.Name = "lblCafe";
            this.lblCafe.Size = new System.Drawing.Size(181, 35);
            this.lblCafe.TabIndex = 1;
            this.lblCafe.Text = "Coffee del dia";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(290, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 25);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant.Location = new System.Drawing.Point(159, 209);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(115, 29);
            this.lblCant.TabIndex = 3;
            this.lblCant.Text = "Cantidad :";
            this.lblCant.Click += new System.EventHandler(this.lblCant_Click);
            // 
            // btnContador
            // 
            this.btnContador.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnContador.Location = new System.Drawing.Point(159, 150);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(193, 44);
            this.btnContador.TabIndex = 4;
            this.btnContador.Text = "Ok";
            this.btnContador.UseVisualStyleBackColor = true;
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // cmbCafe
            // 
            this.cmbCafe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCafe.FormattingEnabled = true;
            this.cmbCafe.Items.AddRange(new object[] {
            "Caramel",
            "Cafe IES",
            "Cafe con leche",
            "Cafe negro"});
            this.cmbCafe.Location = new System.Drawing.Point(159, 112);
            this.cmbCafe.Name = "cmbCafe";
            this.cmbCafe.Size = new System.Drawing.Size(193, 21);
            this.cmbCafe.TabIndex = 5;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Corbel", 18F);
            this.lblContador.Location = new System.Drawing.Point(274, 209);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 29);
            this.lblContador.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 329);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.cmbCafe);
            this.Controls.Add(this.btnContador);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCafe);
            this.Controls.Add(this.picFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafeteria IES";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Label lblCafe;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Button btnContador;
        private System.Windows.Forms.ComboBox cmbCafe;
        private System.Windows.Forms.Label lblContador;
    }
}