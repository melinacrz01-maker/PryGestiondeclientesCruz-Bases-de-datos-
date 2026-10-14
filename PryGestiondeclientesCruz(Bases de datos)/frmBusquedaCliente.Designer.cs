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
            this.txtcodigodelclienteingresado = new System.Windows.Forms.TextBox();
            this.grbDatosClientes = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblcredito = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreclientee = new System.Windows.Forms.Label();
            this.lblDeudacliente = new System.Windows.Forms.Label();
            this.llblcreditocliente = new System.Windows.Forms.Label();
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
            // txtcodigodelclienteingresado
            // 
            this.txtcodigodelclienteingresado.Location = new System.Drawing.Point(153, 46);
            this.txtcodigodelclienteingresado.Name = "txtcodigodelclienteingresado";
            this.txtcodigodelclienteingresado.Size = new System.Drawing.Size(195, 20);
            this.txtcodigodelclienteingresado.TabIndex = 2;
            // 
            // grbDatosClientes
            // 
            this.grbDatosClientes.Controls.Add(this.llblcreditocliente);
            this.grbDatosClientes.Controls.Add(this.lblDeudacliente);
            this.grbDatosClientes.Controls.Add(this.lblNombreclientee);
            this.grbDatosClientes.Controls.Add(this.lblcredito);
            this.grbDatosClientes.Controls.Add(this.lblDeuda);
            this.grbDatosClientes.Controls.Add(this.lblNombre);
            this.grbDatosClientes.Controls.Add(this.label1);
            this.grbDatosClientes.Location = new System.Drawing.Point(15, 136);
            this.grbDatosClientes.Name = "grbDatosClientes";
            this.grbDatosClientes.Size = new System.Drawing.Size(386, 146);
            this.grbDatosClientes.TabIndex = 3;
            this.grbDatosClientes.TabStop = false;
            this.grbDatosClientes.Text = "Datos del cliente..";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.Location = new System.Drawing.Point(22, 68);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(57, 16);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblcredito
            // 
            this.lblcredito.AutoSize = true;
            this.lblcredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcredito.Location = new System.Drawing.Point(22, 104);
            this.lblcredito.Name = "lblcredito";
            this.lblcredito.Size = new System.Drawing.Size(126, 16);
            this.lblcredito.TabIndex = 3;
            this.lblcredito.Text = "Limite de credito:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 4;
            // 
            // lblNombreclientee
            // 
            this.lblNombreclientee.BackColor = System.Drawing.Color.SeaShell;
            this.lblNombreclientee.Enabled = false;
            this.lblNombreclientee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreclientee.Location = new System.Drawing.Point(94, 27);
            this.lblNombreclientee.Name = "lblNombreclientee";
            this.lblNombreclientee.Size = new System.Drawing.Size(135, 21);
            this.lblNombreclientee.TabIndex = 5;
            // 
            // lblDeudacliente
            // 
            this.lblDeudacliente.BackColor = System.Drawing.Color.SeaShell;
            this.lblDeudacliente.Enabled = false;
            this.lblDeudacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeudacliente.Location = new System.Drawing.Point(94, 68);
            this.lblDeudacliente.Name = "lblDeudacliente";
            this.lblDeudacliente.Size = new System.Drawing.Size(135, 21);
            this.lblDeudacliente.TabIndex = 6;
            // 
            // llblcreditocliente
            // 
            this.llblcreditocliente.BackColor = System.Drawing.Color.SeaShell;
            this.llblcreditocliente.Enabled = false;
            this.llblcreditocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblcreditocliente.Location = new System.Drawing.Point(156, 104);
            this.llblcreditocliente.Name = "llblcreditocliente";
            this.llblcreditocliente.Size = new System.Drawing.Size(135, 21);
            this.llblcreditocliente.TabIndex = 7;
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(413, 311);
            this.Controls.Add(this.grbDatosClientes);
            this.Controls.Add(this.txtcodigodelclienteingresado);
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
        private System.Windows.Forms.TextBox txtcodigodelclienteingresado;
        private System.Windows.Forms.GroupBox grbDatosClientes;
        private System.Windows.Forms.Label lblNombreclientee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcredito;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label llblcreditocliente;
        private System.Windows.Forms.Label lblDeudacliente;
    }
}