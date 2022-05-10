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
    public partial class Form2 : Form
    {
        
      
        private RedSocial red;
        public List<Form2> usuarios;
        Form3 hijoRegistrar;
       
        public delegate void pasarLogin(Usuario usuario);
        public pasarLogin pasadoLogin;




        public Form2(RedSocial redSocial)
        {
            InitializeComponent();
            this.red = redSocial;          
        }

        public Form2(Usuario user)
        {
            InitializeComponent();
            
            label3.Text = user.Nombre;
            
            
            
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

            if (red.iniciarSesion(textBox1.Text, textBox2.Text))
            {
                label3.Text = "Inicio de sesión: OK";
            }
            else
            {
                label3.Text = "Inicio de sesión: NO";
            }
            
        }

        
    }
    

}