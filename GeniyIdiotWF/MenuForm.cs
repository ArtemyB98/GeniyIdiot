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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            var newGame = new GameForm();
            Hide();
            newGame.ShowDialog();
            Show();
        }

        private void userResultsButton_Click(object sender, EventArgs e)
        {
            var pecientResults = new ResultsForm();
            Hide();
            pecientResults.ShowDialog();
            Show();
        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            var option = new OptionForm();
            Hide();
            option.ShowDialog();
            Show();
        }

        private void exitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
