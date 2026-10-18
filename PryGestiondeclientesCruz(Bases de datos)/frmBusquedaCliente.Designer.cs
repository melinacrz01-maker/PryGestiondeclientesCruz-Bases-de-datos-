namespace PryGestiondeclientesCruz_Bases_de_datos_
{
    partial class frmBusquedaCliente
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
            this.lblCodigocliente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grbDatosClientes = new System.Windows.Forms.GroupBox();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.lblTituloDeuda = new System.Windows.Forms.Label();
            this.lblTituloLimite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.grbDatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigocliente
            // 
            this.lblCodigocliente.AutoSize = true;
            this.lblCodigocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigocliente.Location = new System.Drawing.Point(12, 47);
            this.lblCodigocliente.Name = "lblCodigocliente";
            this.lblCodigocliente.Size = new System.Drawing.Size(135, 16);
            this.lblCodigocliente.TabIndex = 0;
            this.lblCodigocliente.Text = "Còdigo del Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(202, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(153, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(195, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // grbDatosClientes
            // 
            this.grbDatosClientes.Controls.Add(this.lblLimite);
            this.grbDatosClientes.Controls.Add(this.lblDeuda);
            this.grbDatosClientes.Controls.Add(this.lblNombre);
            this.grbDatosClientes.Controls.Add(this.lblTituloLimite);
            this.grbDatosClientes.Controls.Add(this.lblTituloDeuda);
            this.grbDatosClientes.Controls.Add(this.lblTituloNombre);
            this.grbDatosClientes.Controls.Add(this.label1);
            this.grbDatosClientes.Location = new System.Drawing.Point(15, 136);
            this.grbDatosClientes.Name = "grbDatosClientes";
            this.grbDatosClientes.Size = new System.Drawing.Size(386, 146);
            this.grbDatosClientes.TabIndex = 3;
            this.grbDatosClientes.TabStop = false;
            this.grbDatosClientes.Text = "Datos del cliente..";
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.Location = new System.Drawing.Point(22, 32);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(66, 16);
            this.lblTituloNombre.TabIndex = 1;
            this.lblTituloNombre.Text = "Nombre:";
            // 
            // lblTituloDeuda
            // 
            this.lblTituloDeuda.AutoSize = true;
            this.lblTituloDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDeuda.Location = new System.Drawing.Point(22, 68);
            this.lblTituloDeuda.Name = "lblTituloDeuda";
            this.lblTituloDeuda.Size = new System.Drawing.Size(57, 16);
            this.lblTituloDeuda.TabIndex = 2;
            this.lblTituloDeuda.Text = "Deuda:";
            // 
            // lblTituloLimite
            // 
            this.lblTituloLimite.AutoSize = true;
            this.lblTituloLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLimite.Location = new System.Drawing.Point(22, 104);
            this.lblTituloLimite.Name = "lblTituloLimite";
            this.lblTituloLimite.Size = new System.Drawing.Size(126, 16);
            this.lblTituloLimite.TabIndex = 3;
            this.lblTituloLimite.Text = "Limite de credito:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.SeaShell;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(94, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(135, 21);
            this.lblNombre.TabIndex = 5;
            // 
            // lblDeuda
            // 
            this.lblDeuda.BackColor = System.Drawing.Color.SeaShell;
            this.lblDeuda.Enabled = false;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.Location = new System.Drawing.Point(94, 68);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(135, 21);
            this.lblDeuda.TabIndex = 6;
            // 
            // lblLimite
            // 
            this.lblLimite.BackColor = System.Drawing.Color.SeaShell;
            this.lblLimite.Enabled = false;
            this.lblLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimite.Location = new System.Drawing.Point(156, 104);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(135, 21);
            this.lblLimite.TabIndex = 7;
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(413, 311);
            this.Controls.Add(this.grbDatosClientes);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodigocliente);
            this.Name = "frmBusquedaCliente";
            this.Text = "Busqueda de Cliente";
            this.grbDatosClientes.ResumeLayout(false);
            this.grbDatosClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigocliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox grbDatosClientes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloLimite;
        private System.Windows.Forms.Label lblTituloDeuda;
        private System.Windows.Forms.Label lblTituloNombre;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblDeuda;
    }
}