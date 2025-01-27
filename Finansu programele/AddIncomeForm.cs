﻿using System;
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
    public partial class AddIncomeForm : Form
    {
        private MainForm mainform;
        public AddIncomeForm(MainForm form)
        {
            InitializeComponent();
            mainform = form;
        }

        private void AddIncomeForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void expenseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void expenseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int currentMonth = mainform.getMonthLabelId();
            Data.months[currentMonth].incomeName.Add(incomeNameTextBox.Text);
            Data.months[currentMonth].incomeAmount.Add(float.Parse(incomeAmountTextBox.Text));

            int lastIndex = Data.months[currentMonth].incomeName.Count - 1;
            string incomeName = Data.months[currentMonth].incomeName[lastIndex];
            float incomeAmount = Data.months[currentMonth].incomeAmount[lastIndex];

            mainform.addIncome(incomeName, incomeAmount, lastIndex);
            mainform.updateExpensesIncomeTotal(currentMonth);
            mainform.enableCartesianChart1();
            this.Close();
        }
    }
}
