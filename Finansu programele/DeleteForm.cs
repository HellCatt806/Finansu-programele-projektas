using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finansu_programele.Properties;

namespace Finansu_programele
{
    public partial class DeleteForm : Form
    {
        MainForm mainForm;


        public DeleteForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            int currentMonth = mainForm.getMonthLabelId();
            int expenseCount = Data.months[currentMonth].expenseName.Count;
            int incomeCount = Data.months[currentMonth].incomeName.Count;

            deleteExpenseComboBox.Items.Add("--------");
            for (int i = 0; i < expenseCount; i++){
                deleteExpenseComboBox.Items.Add((Data.months[currentMonth].expenseName[i] + " " + Data.months[currentMonth].expensePrice[i] + "€"));
            }
            deleteIncomeComboBox.Items.Add("--------");
            for (int a = 0; a < incomeCount; a++){
                deleteIncomeComboBox.Items.Add((Data.months[currentMonth].incomeName[a] + " " + Data.months[currentMonth].incomeAmount[a] + "€"));
            }
            deleteExpenseComboBox.SelectedIndex = 0;
            deleteIncomeComboBox.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int currentMonth = mainForm.getMonthLabelId();
            int expenseSelectedIndex = deleteExpenseComboBox.SelectedIndex - 1;
            int incomeSelectedIndex =  deleteIncomeComboBox.SelectedIndex - 1;

            

            mainForm.clearIncomeExpensePanel();
            if (deleteExpenseComboBox.SelectedIndex != 0){

                Data.months[currentMonth].expenseName.RemoveAt(expenseSelectedIndex);
                Data.months[currentMonth].expensePrice.RemoveAt(expenseSelectedIndex);
                Data.months[currentMonth].expenseType.RemoveAt(expenseSelectedIndex);
            }
            if (deleteIncomeComboBox.SelectedIndex != 0){
                Data.months[currentMonth].incomeName.RemoveAt(incomeSelectedIndex);
                Data.months[currentMonth].incomeAmount.RemoveAt(incomeSelectedIndex);
            }

            int expenseCount = Data.months[currentMonth].expenseName.Count;
            int incomeCount = Data.months[currentMonth].incomeName.Count;

            if (expenseCount > 0)
            {
                for (int i = 0; i < expenseCount; i++)
                {
                    mainForm.addExpense(Data.months[currentMonth].expenseName[i], Data.months[currentMonth].expensePrice[i], i);
                }
                mainForm.updateExpensesIncomeTotal(currentMonth);

                mainForm.enableCartesianChart1();
            }
            if (incomeCount > 0)
            {
                for (int a = 0; a < incomeCount; a++)
                {
                    mainForm.addIncome(Data.months[currentMonth].incomeName[a], Data.months[currentMonth].incomeAmount[a], a);
                }
                mainForm.updateExpensesIncomeTotal(currentMonth);

                mainForm.enableCartesianChart1();
            }
            if (expenseCount == 0 && incomeCount == 0)
            {
                mainForm.disableCartesianChart1();
            }
            mainForm.PopulatePieChart();
            this.Close();
        }

        private void deleteExpenseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteIncomeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
