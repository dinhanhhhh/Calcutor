﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click_1(object sender, EventArgs e)
        {

          

            if (txtA.Text != string.Empty && txtB.Text != String.Empty )

            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a + b;
                txtKetQua.Text = c.ToString();
            }

           

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a - b;
                txtKetQua.Text = c.ToString();
        }
        
    }
}
