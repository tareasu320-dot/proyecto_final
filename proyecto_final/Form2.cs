﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void contactarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Form4();
            formulario.Show();

        }

        private void ingresoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Form3();
            formulario.Show();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form formulario = new Form1();
            formulario.Show();

        }
    }
}
