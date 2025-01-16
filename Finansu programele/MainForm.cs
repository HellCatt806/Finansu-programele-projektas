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

using System.Collections.Generic;   // Required for List
using Finansu_programele.Properties;

using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Windows.Documents;
using System.Data.OleDb;
using System.Globalization;


namespace Finansu_programele
{
    public partial class MainForm : Form
    {
        public static MainForm instance;
        private Functions funkcijos;

        private Label expensesTotalLabel;
        private Label incomeTotalLabel;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            funkcijos = new Functions(this);
            funkcijos.setMonthUIOnStart((DateTime.Now.Month) - 1);
            InitializeData();
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
            //TODO: 
            int month = Functions.getMonthIdByName(monthLabel.Text) - 1;
            if (month >= 0)
            {
                funkcijos.changeMonth(month);
            }
            if((month - 1) < 0)
            {
                previousMonthButton.Enabled = false;
            }
            if(month < 11)
            {
                nextMonthButton.Enabled = true;
            }
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            //TODO: sekantis menesis mygtukas
            int month = Functions.getMonthIdByName(monthLabel.Text) + 1;
            if(month <= 11)
            {
                funkcijos.changeMonth(month);
            }
            if ((month + 1) > 11)
            {
                nextMonthButton.Enabled = false;
            }
            if(month > 0)
            {
                previousMonthButton.Enabled = true;
            }
        }

        private void moreDiagramsButton_Click(object sender, EventArgs e)
        {
            MoreCharts moreCharts = new MoreCharts(this);
            moreCharts.ShowDialog();
            
        }

        private void addExpensesButton_Click(object sender, EventArgs e)
        {
            AddExpensesForm PridetiIslaidas = new AddExpensesForm(this);
            PridetiIslaidas.ShowDialog();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void addExpense(string expenseName, float expensePrice, int expenseIndex)
        {

            string expensePriceFormatted = expensePrice.ToString("0.00", CultureInfo.InvariantCulture);
            expensePriceFormatted = expensePriceFormatted.Replace('.', ',');
            Label newExpenseLabel = new Label();
            newExpenseLabel.Text = expenseName + " " + expensePriceFormatted + "€";
            newExpenseLabel.Location = new System.Drawing.Point(17, (70 + (expenseIndex * 30)));
            newExpenseLabel.Size = new System.Drawing.Size(135, 20);
            newExpenseLabel.AutoSize = true;
            newExpenseLabel.TabIndex = 11;
            expensePanel.Controls.Add(newExpenseLabel);
            newExpenseLabel.Name = "expenseLabel" + expenseIndex.ToString();

            expensePanel.PerformLayout();
        }
        public void addIncome(string incomeName, float incomeAmount, int incomeIndex)
        {
            Label newIncomeLabel = new Label();
            newIncomeLabel.Text = incomeName + " " + incomeAmount + "€";
            newIncomeLabel.Location = new System.Drawing.Point(17, (70 + (incomeIndex * 30)));
            newIncomeLabel.Size = new System.Drawing.Size(135, 20);
            newIncomeLabel.AutoSize = true;
            newIncomeLabel.TabIndex = 11;
            incomePanel.Controls.Add(newIncomeLabel);
            newIncomeLabel.Name = "incomeLabel" + incomeIndex.ToString();
            incomePanel.PerformLayout();
        }
        public void updateExpensesIncomeTotal(int currentMonth)
        {
            int expenseCount = Data.months[currentMonth].expensePrice.Count();
            float expenseTotal = 0;
            for (int i = 0; i < expenseCount; i++)
            {
                expenseTotal += Data.months[currentMonth].expensePrice[i];
            }
            if(expenseTotal > 0)
            {
                expensesTotalLabel.Text = "Iš viso: " + expenseTotal.ToString() + "€";
            }
            
            int incomeCount = Data.months[currentMonth].incomeAmount.Count();
            float incomeTotal = 0;
            for (int a = 0; a < incomeCount; a++)
            {
                incomeTotal += Data.months[currentMonth].incomeAmount[a];
            }
            if (incomeTotal > 0)
            {
                incomeTotalLabel.Text = "Iš viso: " + incomeTotal.ToString() + "€";
            }
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
            this.expensePanel.Controls.Clear();
            this.incomePanel.Controls.Clear();
            this.expenseIncomeTotalPanel.Controls.Clear();

            Label expensesLabel = new Label();
            expensesLabel.AutoSize = true;
            expensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expensesLabel.Location = new System.Drawing.Point(17, 26);
            expensesLabel.Name = "expensesLabel";
            expensesLabel.Size = new System.Drawing.Size(71, 20);
            expensesLabel.TabIndex = 0;
            expensesLabel.Text = "Išlaidos";
            expensePanel.Controls.Add(expensesLabel);

            Label incomeLabel = new Label();
            incomeLabel.AutoSize = true;
            incomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            incomeLabel.Location = new System.Drawing.Point(17, 26);
            incomeLabel.Name = "incomeLabel";
            incomeLabel.Size = new System.Drawing.Size(77, 20);
            incomeLabel.TabIndex = 0;
            incomeLabel.Text = "Pajamos";
            incomePanel.Controls.Add(incomeLabel);

            expensesTotalLabel = new Label();
            expensesTotalLabel.AutoSize = true;
            expensesTotalLabel.Location = new System.Drawing.Point(17, 19);
            expensesTotalLabel.Name = "expensesTotalLabel";
            expensesTotalLabel.Size = new System.Drawing.Size(111, 20);
            expensesTotalLabel.TabIndex = 8;
            expensesTotalLabel.Text = "Iš viso:";
            expenseIncomeTotalPanel.Controls.Add(expensesTotalLabel);

            incomeTotalLabel = new Label();
            incomeTotalLabel.AutoSize = true;
            incomeTotalLabel.Location = new System.Drawing.Point(275, 19);
            incomeTotalLabel.Name = "incomeTotalLabel";
            incomeTotalLabel.Size = new System.Drawing.Size(111, 20);
            incomeTotalLabel.TabIndex = 8;
            incomeTotalLabel.Text = "Iš viso:";
            expenseIncomeTotalPanel.Controls.Add(incomeTotalLabel);
        }

        private void InitializeData()
        {
            //Creates month struct
            Data.month january = new Data.month("Sausis");
            Data.month february = new Data.month("Vasaris");
            Data.month march = new Data.month("Kovas");
            Data.month april = new Data.month("Balandis");
            Data.month may = new Data.month("Gegužė");
            Data.month june = new Data.month("Birželis");
            Data.month july = new Data.month("Liepa");
            Data.month august = new Data.month("Rugpjūtis");
            Data.month september = new Data.month("Rugsėjis");
            Data.month october = new Data.month("Spalis");
            Data.month november = new Data.month("Lapkritis");
            Data.month december = new Data.month("Gruodis");

            //Initializes month struct
            january.InitializeValues();
            february.InitializeValues();
            march.InitializeValues();
            april.InitializeValues();
            may.InitializeValues();
            june.InitializeValues();
            july.InitializeValues();
            august.InitializeValues();
            september.InitializeValues();
            october.InitializeValues();
            november.InitializeValues();
            december.InitializeValues();

            //Adds month struct to list of months
            Data.months.Add(january);
            Data.months.Add(february);
            Data.months.Add(march);
            Data.months.Add(april);
            Data.months.Add(may);
            Data.months.Add(june);
            Data.months.Add(july);
            Data.months.Add(august);
            Data.months.Add(september);
            Data.months.Add(october);
            Data.months.Add(november);
            Data.months.Add(december);
        }
        public int getMonthLabelId()
        {
            return Functions.getMonthIdByName(monthLabel.Text);
        }

        private void incomeTotalLabelDefault_Click(object sender, EventArgs e)
        {

        }
        public void disablePreviousMonthButton(){
            previousMonthButton.Enabled = false;
        }
        public void enablePreviousMonthButton() { 
            previousMonthButton.Enabled=true;
        }
        public void disableNextMonthButton() {
            nextMonthButton.Enabled=false;
        }
        public void enableNextMonthButton() {
            nextMonthButton.Enabled = true;
        }
        public void disableCartesianChart1(){
            cartesianChart1.Visible = false;
        }
        public void enableCartesianChart1(){
            cartesianChart1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(this);
            deleteForm.ShowDialog();
        }
        public void PopulatePieChart()
        {
            int currentMonth = getMonthLabelId();
            int expenseCount = Data.months[currentMonth].expenseName.Count();

            List<int> usedTypes = new List<int>();
            List<float> expenseSum = new List<float> { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < expenseCount; i++){
                if (Data.months[currentMonth].expenseType[i] >= 0){
                    usedTypes.Add(Data.months[currentMonth].expenseType[i]);
                }
            }
            usedTypes = usedTypes.Distinct().ToList();
            for (int a = 0; a < expenseCount; a++){
                expenseSum[Data.months[currentMonth].expenseType[a]] += Data.months[currentMonth].expensePrice[a];
            }

            var pieChartData = new List<DataItem>();
            for (int b = 0; b < usedTypes.Count(); b++){
                pieChartData.Add(new DataItem { Label = Functions.getExpensesTypeTextByID(usedTypes[b]), Value = expenseSum[usedTypes[b]] });
            }

            // Create the series collection
            var seriesCollection = new SeriesCollection();

            foreach (var item in pieChartData)
            {
                seriesCollection.Add(new PieSeries
                {
                    Title = item.Label,
                    Values = new ChartValues<double> { item.Value },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.Y:0.##}€" // Format to 2 decimal places
                });
            }

            // Assign the series collection to the chart
            cartesianChart1.Series = seriesCollection;

            // Optionally, set the legend position
            cartesianChart1.LegendLocation = LegendLocation.Right;
        }
    }
}
