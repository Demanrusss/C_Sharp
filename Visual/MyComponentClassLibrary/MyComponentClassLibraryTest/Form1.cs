﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyComponentClassLibrary;

namespace MyComponentClassLibraryTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createNewFormButton_Click(object sender, EventArgs e)
        {
            Bevel newForm = new Bevel();
        }

        private void bevel1_Load(object sender, EventArgs e)
        {

        }
    }
}
