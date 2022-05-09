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
     
        

        private RedSocial redSocial;
        private Usuario usuario;
        

        public Form1()
        {

            InitializeComponent();
            redSocial = new RedSocial();
           
     
            

        }
        private void TransfDelegado(Usuario Aux)
        {
            this.usuario = Aux;
           

        }


        private void iniciarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 hijoLogin = new Form2();
            hijoLogin.MdiParent = this;
            hijoLogin.Show();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hijoRegistrar = new Form3(new string[] { "hola" });
            
            hijoRegistrar.MdiParent = this;
            hijoRegistrar.Show();

        }
    }

    }

    
    

