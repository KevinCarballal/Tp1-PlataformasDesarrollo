using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1_PlataformasDesarrollo
{
    public partial class Form1 : Form
    {
        private RedSocial miRed;
        
        public Form1()
        {
            InitializeComponent();
            miRed = new RedSocial();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (miRed.iniciarSesion(textBox1.Text, textBox2.Text))
            {
                label3.Text = "Inicio de sesión: OK";
            }
            else
            {
                label3.Text = "Inicio de sesión: NO";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 frm = new Form2();

            frm.Show();
           
            /*Usuario Aux = new Usuario(textBox1.Text, textBox2.Text);
            miRed.agregarUsuario(textBox1.Text, textBox2.Text);
            miRed.agregarUsuario(Aux);
            Aux.Password = "";*/
        }
    }
    

}