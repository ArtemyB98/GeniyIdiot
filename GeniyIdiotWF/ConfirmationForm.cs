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
    public partial class ConfirmationForm : Form
    {
        public bool Answer;
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {

        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Answer = true;
            Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Answer = false;
            Close();
        }

        private void confirmationLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
