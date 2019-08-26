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
    public partial class Ventana_2 : Form
    {
        public Ventana_2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true; 


        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion; 
            if(VisualC.Checked == true)
            {
                conteo++; 
            }
            if (rbt.Checked == true)
            {
                seleccion = "Tarjeta de credito";
            }
            else
            {
                seleccion = "PayPal"; 
            }
        }
    }
}
