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
        private string dato;
        

        public Form1()
        {

            InitializeComponent();
            redSocial = new RedSocial();
           
     
            

        }
        private void TransfDelegado(string Usuario)
        {

            this.dato = Usuario;

            MessageBox.Show(this.dato);

        }


        private void iniciarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 hijoLogin = new Form2(this.dato);
            hijoLogin.MdiParent = this;
            hijoLogin.TrasfEvento += TransfDelegado;

            hijoLogin.Show();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hijoRegistrar = new Form3("hola");
            
            hijoRegistrar.MdiParent = this;
            hijoRegistrar.TrasfEvento += TransfDelegado;
            hijoRegistrar.Show();

        }
    }

    }

    
    

