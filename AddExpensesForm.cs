using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finansu_programele.Properties;

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
            int currentMonth = mainForminstance.getMonthLabelId();

            string normalizedInput = expenseAmounttextBox.Text.Replace(',', '.');

            Data.months[currentMonth].expenseName.Add(expenseTextBox.Text);
            Data.months[currentMonth].expensePrice.Add(float.Parse(normalizedInput, CultureInfo.InvariantCulture));
            Data.months[currentMonth].expenseType.Add(Functions.getExpensesTypeIdByText(expenseTypeOption.Text));

            int lastIndex = Data.months[currentMonth].expenseName.Count - 1;
            string expenseName = Data.months[currentMonth].expenseName[lastIndex];
            float expensePrice = Data.months[currentMonth].expensePrice[lastIndex];

            mainForminstance.addExpense(expenseName, expensePrice, lastIndex);
            mainForminstance.updateExpensesIncomeTotal(currentMonth);
            mainForminstance.enableCartesianChart1();
            mainForminstance.PopulatePieChart();
            this.Close();
        }

        private void expenseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddExpensesForm_Load(object sender, EventArgs e)
        {

        }

        private void expenseTypeOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
