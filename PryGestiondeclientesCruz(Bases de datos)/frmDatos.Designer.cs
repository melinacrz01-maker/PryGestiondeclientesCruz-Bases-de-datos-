namespace PryGestiondeclientesCruz_Bases_de_datos_
{
    partial class frmDatos
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
            this.btnListarDatos = new System.Windows.Forms.Button();
            this.Dgvgrilladatos = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvgrilladatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarDatos
            // 
            this.btnListarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnListarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarDatos.ForeColor = System.Drawing.Color.Maroon;
            this.btnListarDatos.Location = new System.Drawing.Point(286, 412);
            this.btnListarDatos.Name = "btnListarDatos";
            this.btnListarDatos.Size = new System.Drawing.Size(168, 36);
            this.btnListarDatos.TabIndex = 1;
            this.btnListarDatos.Text = "Listar";
            this.btnListarDatos.UseVisualStyleBackColor = false;
            this.btnListarDatos.Click += new System.EventHandler(this.btnListarDatos_Click);
            // 
            // Dgvgrilladatos
            // 
            this.Dgvgrilladatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvgrilladatos.Location = new System.Drawing.Point(37, 46);
            this.Dgvgrilladatos.Name = "Dgvgrilladatos";
            this.Dgvgrilladatos.Size = new System.Drawing.Size(429, 319);
            this.Dgvgrilladatos.TabIndex = 2;
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnReporte.Location = new System.Drawing.Point(62, 412);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(168, 36);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(518, 480);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.Dgvgrilladatos);
            this.Controls.Add(this.btnListarDatos);
            this.ForeColor = System.Drawing.Color.PeachPuff;
            this.Name = "frmDatos";
            this.Text = "Datos de Clientes..";
            ((System.ComponentModel.ISupportInitialize)(this.Dgvgrilladatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListarDatos;
        private System.Windows.Forms.DataGridView Dgvgrilladatos;
        private System.Windows.Forms.Button btnReporte;
    }
}