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
        private void TransfDelegado(string dato)
        {
            this.dato = dato;
            
            label4.Text = dato;

        }

        private void pasarUsuario(Usuario user)
        {
            this.usuario = user;

            MessageBox.Show(user.Nombre, user.Password);

        }

        private void pasarLogin(Usuario user)
        {
            this.usuario = user;

            MessageBox.Show(user.Nombre, user.Password);

        }


        private void iniciarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 hijoLogin = new Form2(usuario);
            hijoLogin.MdiParent = this;
            hijoLogin.pasadoLogin += pasarLogin;

            hijoLogin.Show();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 hijoRegistrar = new Form3(usuario, redSocial);
            
            hijoRegistrar.MdiParent = this;
            hijoRegistrar.pasado += pasarUsuario;
            hijoRegistrar.Show();

        }
    }

    }

    
    

