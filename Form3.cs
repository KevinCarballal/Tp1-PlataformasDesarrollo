﻿using System;
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
    public partial class Form3 : Form
    {
        private RedSocial miRed;
        public List<Form3> usuarios;
        
        public string[] argumentos;
        public delegate void TransfDelegado(Usuario usuarios);
        public TransfDelegado TrasfEvento;

        public Form3(string[] args)
        {
            InitializeComponent();
            argumentos = args;
            label7.Text = args[0];
            miRed = new RedSocial();
           
        }
        public Form3()
        {
            InitializeComponent();
            
            miRed = new RedSocial();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Usuario Aux = new Usuario(0,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            //miRed.agregarUsuario(0,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            miRed.agregarUsuario(Aux);
            
            Aux.Password = "";
            
            
            this.Hide();

            Form1 frm = new Form1();
            
            frm.Show();
        }
    }

}