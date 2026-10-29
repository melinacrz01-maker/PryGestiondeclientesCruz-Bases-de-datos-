namespace PryGestiondeclientesCruz_Bases_de_datos_
{
    partial class frmAgregar
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
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnAgregarSQL = new System.Windows.Forms.Button();
            this.grbDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grbDatosCliente.Controls.Add(this.cmbCiudad);
            this.grbDatosCliente.Controls.Add(this.txtLimite);
            this.grbDatosCliente.Controls.Add(this.txtNombre);
            this.grbDatosCliente.Controls.Add(this.lblCiudad);
            this.grbDatosCliente.Controls.Add(this.lblLimite);
            this.grbDatosCliente.Controls.Add(this.lblNombre);
            this.grbDatosCliente.Location = new System.Drawing.Point(15, 25);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(386, 160);
            this.grbDatosCliente.TabIndex = 0;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos del cliente..";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(156, 114);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(180, 21);
            this.cmbCiudad.TabIndex = 5;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(156, 74);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(180, 20);
            this.txtLimite.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(22, 115);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(60, 16);
            this.lblCiudad.TabIndex = 4;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(22, 75);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(126, 16);
            this.lblLimite.TabIndex = 2;
            this.lblLimite.Text = "Limite de credito:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Navy;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Location = new System.Drawing.Point(80, 205);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(104, 38);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            //
            // btnAgregarSQL
            //
            this.btnAgregarSQL.BackColor = System.Drawing.Color.Navy;
            this.btnAgregarSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSQL.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarSQL.Location = new System.Drawing.Point(230, 205);
            this.btnAgregarSQL.Name = "btnAgregarSQL";
            this.btnAgregarSQL.Size = new System.Drawing.Size(104, 38);
            this.btnAgregarSQL.TabIndex = 2;
            this.btnAgregarSQL.Text = "Agregar SQL";
            this.btnAgregarSQL.UseVisualStyleBackColor = false;
            this.btnAgregarSQL.Click += new System.EventHandler(this.btnAgregarSQL_Click);
            //
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(413, 255);
            this.Controls.Add(this.btnAgregarSQL);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.grbDatosCliente);
            this.Name = "frmAgregar";
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnAgregarSQL;
    }
}
