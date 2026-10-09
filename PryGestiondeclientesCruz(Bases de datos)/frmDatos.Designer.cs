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
            this.listDatos = new System.Windows.Forms.ListBox();
            this.btnListarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDatos
            // 
            this.listDatos.FormattingEnabled = true;
            this.listDatos.Location = new System.Drawing.Point(24, 35);
            this.listDatos.Name = "listDatos";
            this.listDatos.Size = new System.Drawing.Size(462, 355);
            this.listDatos.TabIndex = 0;
            // 
            // btnListarDatos
            // 
            this.btnListarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnListarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarDatos.ForeColor = System.Drawing.Color.Maroon;
            this.btnListarDatos.Location = new System.Drawing.Point(318, 412);
            this.btnListarDatos.Name = "btnListarDatos";
            this.btnListarDatos.Size = new System.Drawing.Size(168, 36);
            this.btnListarDatos.TabIndex = 1;
            this.btnListarDatos.Text = "Listar";
            this.btnListarDatos.UseVisualStyleBackColor = false;
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(518, 480);
            this.Controls.Add(this.btnListarDatos);
            this.Controls.Add(this.listDatos);
            this.ForeColor = System.Drawing.Color.PeachPuff;
            this.Name = "frmDatos";
            this.Text = "Datos de Clientes..";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDatos;
        private System.Windows.Forms.Button btnListarDatos;
    }
}