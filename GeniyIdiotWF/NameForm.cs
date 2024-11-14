﻿using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWF
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            startInformationLable.Text=StartInformation.Get(nameTextBox.Text);
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                startInformationLable.Text = "Create name";
            }
            else
            {
                Close();
            }
            
        }

        private void NameForm_Load(object sender, EventArgs e)
        {

        }

        private void startInformationLable_Click(object sender, EventArgs e)
        {

        }
    }
}
