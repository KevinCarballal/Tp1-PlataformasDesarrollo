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
            this.redSocial.agregarUsuario(this.usuario);
        }

        private void pasarLogin(Usuario user)
        {
            this.usuario = user;

            this.redSocial.agregarUsuario(this.usuario);
        }
        bool logueado = false;
        private void loguin(bool logueado)
        {

        }

    




        private void iniciarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 hijoLogin = new Form2(this.redSocial);
            hijoLogin.MdiParent = this;

            Form2 hijoMain = new Form2(this.redSocial);
            hijoMain.MdiParent = this;
            hijoMain.pasadoLogin += pasarLogin;
            

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

    
    

