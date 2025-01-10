using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

using System.Collections.Generic; // Required for List


namespace Finansu_programele
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public MainForm()
        {
            InitializeComponent();
            Functions functions = new Functions(this);
            functions.setMonthUI(DateTime.Now.Month);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void closeProgramButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            //TODO: save file
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            //TODO: load file
        }

        private void monthLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void previousMonthButton_Click(object sender, EventArgs e)
        {
            //TODO: praeitas menesis mygtukas
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            //TODO: sekantis menesis mygtukas
        }

        private void moreDiagramsButton_Click(object sender, EventArgs e)
        {
            //TODO: daugiau diagramu mygtukass
        }

        private void addExpensesButton_Click(object sender, EventArgs e)
        {
            AddExpensesForm PridetiIslaidas = new AddExpensesForm(this);
            PridetiIslaidas.ShowDialog();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void AddExpenses(string expenseName, float expensePrice, int expenseType)
        {
            Label label12 = new Label();
            label12.Text = expenseName + " " + expensePrice + "€";                 // Set the label's text
            label12.Location = new System.Drawing.Point(17, 72);
            label12.Size = new System.Drawing.Size(135, 20);
            //label12.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular); // Optional styling
            label12.AutoSize = true;
            label12.TabIndex = 11;


            panel1.Controls.Add(label12); // Add the label to the form's controls
        }
        public void EditExpenses(string expenseName, Label labelName)
        {
            labelName.Text = expenseName;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addIncomeButton_Click(object sender, EventArgs e)
        {
            AddIncomeForm PridetiPajamas = new AddIncomeForm(this);
            PridetiPajamas.ShowDialog();
        }
        public void changeMonthNameLabel(string monthName)
        {
            monthLabel.Text = monthName;
        }
        //Clears all labels in Income/Expenses UI
        public void clearIncomeExpensePanel()
        {
            this.panel1.Controls.Clear();
        }
    }
}
