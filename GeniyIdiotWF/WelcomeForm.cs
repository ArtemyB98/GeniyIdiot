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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
        }
    }
}
