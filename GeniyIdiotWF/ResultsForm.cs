using GeniyIdiot;
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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void resutlsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            var results = UserResultsStorage.GetPacientsResults();
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.CountRightAnswer, result.Diagnose);
            }
            resultsDataGridView.AllowUserToAddRows = false;
        }
    }
}
