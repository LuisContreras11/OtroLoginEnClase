namespace Otro_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.TextBox();
            this.inicio = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA SUPER SECRETO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(116, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(138, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave:";
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.usuario.Location = new System.Drawing.Point(212, 135);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(370, 23);
            this.usuario.TabIndex = 3;
            this.usuario.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // clave
            // 
            this.clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.clave.Location = new System.Drawing.Point(212, 179);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(370, 23);
            this.clave.TabIndex = 4;
            this.clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Clave_KeyPress);
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(207, 287);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(112, 40);
            this.inicio.TabIndex = 5;
            this.inicio.Text = "&Iniciar";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(465, 287);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(112, 40);
            this.salir.TabIndex = 6;
            this.salir.Text = "&Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox clave;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.Button salir;
    }
}

