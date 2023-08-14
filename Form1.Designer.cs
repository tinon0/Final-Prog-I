namespace Autos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstAutos = new System.Windows.Forms.ListBox();
            this.grpAutos = new System.Windows.Forms.GroupBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.grpAutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 296);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(116, 329);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(225, 329);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(329, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(432, 329);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 338);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstAutos
            // 
            this.lstAutos.FormattingEnabled = true;
            this.lstAutos.Location = new System.Drawing.Point(329, 5);
            this.lstAutos.Name = "lstAutos";
            this.lstAutos.Size = new System.Drawing.Size(178, 277);
            this.lstAutos.TabIndex = 5;
            this.lstAutos.SelectedIndexChanged += new System.EventHandler(this.lstAutos_SelectedIndexChanged);
            // 
            // grpAutos
            // 
            this.grpAutos.Controls.Add(this.cboColor);
            this.grpAutos.Controls.Add(this.cboMarca);
            this.grpAutos.Controls.Add(this.txtPrecio);
            this.grpAutos.Controls.Add(this.txtModelo);
            this.grpAutos.Controls.Add(this.txtPatente);
            this.grpAutos.Controls.Add(this.lblPrecio);
            this.grpAutos.Controls.Add(this.lblColor);
            this.grpAutos.Controls.Add(this.lblModelo);
            this.grpAutos.Controls.Add(this.lblMarca);
            this.grpAutos.Controls.Add(this.lblPatente);
            this.grpAutos.Location = new System.Drawing.Point(13, 22);
            this.grpAutos.Name = "grpAutos";
            this.grpAutos.Size = new System.Drawing.Size(287, 260);
            this.grpAutos.TabIndex = 0;
            this.grpAutos.TabStop = false;
            this.grpAutos.Text = "Completar:";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(125, 155);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(121, 21);
            this.cboColor.TabIndex = 8;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(125, 71);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(125, 192);
            this.txtPrecio.MaxLength = 4;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(125, 117);
            this.txtModelo.MaxLength = 4;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 6;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(125, 41);
            this.txtPatente.MaxLength = 50;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(19, 195);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(68, 13);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "Precio (U$D)";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(43, 155);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(43, 117);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(70, 13);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo (Año)";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(43, 74);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(43, 41);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 1;
            this.lblPatente.Text = "Patente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 373);
            this.ControlBox = false;
            this.Controls.Add(this.grpAutos);
            this.Controls.Add(this.lstAutos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Formulario Ingreso de Autos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAutos.ResumeLayout(false);
            this.grpAutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstAutos;
        private System.Windows.Forms.GroupBox grpAutos;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPatente;
    }
}

