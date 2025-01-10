using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finansu_programele
{
    public partial class AddExpensesForm : Form
    {
        private MainForm mainForminstance;
        public AddExpensesForm(MainForm form)
        {
            InitializeComponent();
            mainForminstance = form;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            mainForminstance.AddExpenses(expenseTextBox.Text);
            //TODO: update total expenses
            this.Close();
        }

        private void expenseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
