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
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTituloLimite = new System.Windows.Forms.Label();
            this.lblTituloDeuda = new System.Windows.Forms.Label();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.btnBuscar.BackColor = System.Drawing.Color.MistyRose;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Purple;
            this.btnBuscar.Location = new System.Drawing.Point(202, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 28);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(153, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(195, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // grbDatosClientes
            // 
            this.grbDatosClientes.BackColor = System.Drawing.Color.Ivory;
            this.grbDatosClientes.Controls.Add(this.txtLimite);
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
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(156, 104);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.ReadOnly = true;
            this.txtLimite.Size = new System.Drawing.Size(135, 20);
            this.txtLimite.TabIndex = 7;
            // 
            // lblDeuda
            // 
            this.lblDeuda.BackColor = System.Drawing.Color.MistyRose;
            this.lblDeuda.Enabled = false;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.Location = new System.Drawing.Point(94, 68);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(135, 21);
            this.lblDeuda.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.MistyRose;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(94, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(135, 21);
            this.lblNombre.TabIndex = 5;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MistyRose;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnEliminar.Location = new System.Drawing.Point(30, 300);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 33);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MistyRose;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnModificar.Location = new System.Drawing.Point(159, 300);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 33);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MistyRose;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnGuardar.Location = new System.Drawing.Point(287, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 33);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 353);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.grbDatosClientes);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodigocliente);
            this.Name = "frmBusquedaCliente";
            this.Text = "Busqueda de Cliente";
            this.Load += new System.EventHandler(this.frmBusquedaCliente_Load);
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
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
    }
}