using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otro_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra el formulario.
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            if(usuario.Text=="Juancho"&& clave.Text=="123tamarindo")
            {
                MessageBox.Show("Hola Don Juancho");
                this.Hide();
                Ventana_2 CursosVenta = new Ventana_2();
                CursosVenta.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Fuera de aqui infiltrado");
                usuario.Text  = "";
                clave.Text = "";
                usuario.Focus();
            }
                
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar==(int)Keys.Enter)
            {
                if (usuario.Text == "Juancho" && clave.Text == "123tamarindo")
                {
                    MessageBox.Show("Hola Don Juancho");
                    this.Hide();
                    Ventana_2 CursosVenta = new Ventana_2();
                    CursosVenta.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Fuera de aqui infiltrado");
                    usuario.Text = "";
                    clave.Text = "";
                    usuario.Focus();

                }
              
            }

        }
        
        }









    }
}
