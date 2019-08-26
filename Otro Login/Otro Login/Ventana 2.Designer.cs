namespace Otro_Login
{
    partial class Ventana_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VisualC = new System.Windows.Forms.CheckBox();
            this.VisualB = new System.Windows.Forms.CheckBox();
            this.rbt = new System.Windows.Forms.RadioButton();
            this.rbp = new System.Windows.Forms.RadioButton();
            this.comprar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso en Venta ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formas de Pago ";
            // 
            // VisualC
            // 
            this.VisualC.AutoSize = true;
            this.VisualC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualC.Location = new System.Drawing.Point(85, 107);
            this.VisualC.Name = "VisualC";
            this.VisualC.Size = new System.Drawing.Size(132, 29);
            this.VisualC.TabIndex = 2;
            this.VisualC.Text = "Visual C#";
            this.VisualC.UseVisualStyleBackColor = true;
            // 
            // VisualB
            // 
            this.VisualB.AutoSize = true;
            this.VisualB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualB.Location = new System.Drawing.Point(85, 168);
            this.VisualB.Name = "VisualB";
            this.VisualB.Size = new System.Drawing.Size(148, 28);
            this.VisualB.TabIndex = 3;
            this.VisualB.Text = "Visual Basic ";
            this.VisualB.UseVisualStyleBackColor = true;
            // 
            // rbt
            // 
            this.rbt.AutoSize = true;
            this.rbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt.Location = new System.Drawing.Point(400, 107);
            this.rbt.Name = "rbt";
            this.rbt.Size = new System.Drawing.Size(201, 28);
            this.rbt.TabIndex = 4;
            this.rbt.TabStop = true;
            this.rbt.Text = "Tarjeta de Credito ";
            this.rbt.UseVisualStyleBackColor = true;
            // 
            // rbp
            // 
            this.rbp.AutoSize = true;
            this.rbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbp.Location = new System.Drawing.Point(400, 153);
            this.rbp.Name = "rbp";
            this.rbp.Size = new System.Drawing.Size(97, 28);
            this.rbp.TabIndex = 5;
            this.rbp.TabStop = true;
            this.rbp.Text = "PayPal ";
            this.rbp.UseVisualStyleBackColor = true;
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(95, 227);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(122, 89);
            this.comprar.TabIndex = 6;
            this.comprar.Text = "&Comprar";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(400, 227);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(122, 89);
            this.cerrar.TabIndex = 7;
            this.cerrar.Text = "&Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Ventana_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.rbp);
            this.Controls.Add(this.rbt);
            this.Controls.Add(this.VisualB);
            this.Controls.Add(this.VisualC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ventana_2";
            this.Text = "Cursos de Programacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox VisualC;
        private System.Windows.Forms.CheckBox VisualB;
        private System.Windows.Forms.RadioButton rbt;
        private System.Windows.Forms.RadioButton rbp;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.Button cerrar;
    }
}