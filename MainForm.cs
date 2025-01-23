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
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

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
            instance = this;
            funkcijos = new Functions(this); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeData(); 
            funkcijos.setMonthUIOnStart((DateTime.Now.Month) - 1);
        }

        private void InitializeData()
        {
            // Create and initialize months
            Data.months = new List<Data.month>
            {
                new Data.month("Sausis"),
                new Data.month("Vasaris"),
                new Data.month("Kovas"),
                new Data.month("Balandis"),
                new Data.month("Gegužė"),
                new Data.month("Birželis"),
                new Data.month("Liepa"),
                new Data.month("Rugpjūtis"),
                new Data.month("Rugsėjis"),
                new Data.month("Spalis"),
                new Data.month("Lapkritis"),
                new Data.month("Gruodis")
            };
        }

        private void closeProgramButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    funkcijos.SaveDataToFile(filePath);
                }
            }
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    funkcijos.LoadDataFromFile(filePath);
                }
            }
        }

        private void previousMonthButton_Click(object sender, EventArgs e)
        {
            int month = Functions.getMonthIdByName(monthLabel.Text) - 1;
            if (month >= 0)
            {
                funkcijos.changeMonth(month);
            }
            if ((month - 1) < 0)
            {
                previousMonthButton.Enabled = false;
            }
            if (month < 11)
            {
                nextMonthButton.Enabled = true;
            }
        }

        private void nextMonthButton_Click(object sender, EventArgs e)
        {
            int month = Functions.getMonthIdByName(monthLabel.Text) + 1;
            if (month <= 11)
            {
                funkcijos.changeMonth(month);
            }
            if ((month + 1) > 11)
            {
                nextMonthButton.Enabled = false;
            }
            if (month > 0)
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

        private void addIncomeButton_Click(object sender, EventArgs e)
        {
            AddIncomeForm PridetiPajamas = new AddIncomeForm(this);
            PridetiPajamas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(this);
            deleteForm.ShowDialog();
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
            int expenseCount = Data.months[currentMonth].expensePrice.Count;
            float expenseTotal = 0;
            for (int i = 0; i < expenseCount; i++)
            {
                expenseTotal += Data.months[currentMonth].expensePrice[i];
            }
            if (expenseTotal > 0)
            {
                expensesTotalLabel.Text = "Iš viso: " + expenseTotal.ToString("0.00") + "€";
            }

            int incomeCount = Data.months[currentMonth].incomeAmount.Count;
            float incomeTotal = 0;
            for (int a = 0; a < incomeCount; a++)
            {
                incomeTotal += Data.months[currentMonth].incomeAmount[a];
            }
            if (incomeTotal > 0)
            {
                incomeTotalLabel.Text = "Iš viso: " + incomeTotal.ToString("0.00") + "€";
            }
        }

        public void changeMonthNameLabel(string monthName)
        {
            monthLabel.Text = monthName;
        }

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

        public int getMonthLabelId()
        {
            return Functions.getMonthIdByName(monthLabel.Text);
        }

        public void disablePreviousMonthButton()
        {
            previousMonthButton.Enabled = false;
        }

        public void enablePreviousMonthButton()
        {
            previousMonthButton.Enabled = true;
        }

        public void disableNextMonthButton()
        {
            nextMonthButton.Enabled = false;
        }

        public void enableNextMonthButton()
        {
            nextMonthButton.Enabled = true;
        }

        public void disableCartesianChart1()
        {
            cartesianChart1.Visible = false;
        }

        public void enableCartesianChart1()
        {
            cartesianChart1.Visible = true;
        }

        public void PopulatePieChart()
        {
            int currentMonth = getMonthLabelId();
            int expenseCount = Data.months[currentMonth].expenseName.Count;

            if (expenseCount == 0)
            {
                cartesianChart1.Series.Clear();
                return;
            }

            List<int> usedTypes = new List<int>();
            List<float> expenseSum = new List<float> { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < expenseCount; i++)
            {
                if (Data.months[currentMonth].expenseType[i] >= 0)
                {
                    usedTypes.Add(Data.months[currentMonth].expenseType[i]);
                }
            }
            usedTypes = usedTypes.Distinct().ToList();

            for (int a = 0; a < expenseCount; a++)
            {
                expenseSum[Data.months[currentMonth].expenseType[a]] += Data.months[currentMonth].expensePrice[a];
            }

            var pieChartData = new List<Data.DataItem>();
            for (int b = 0; b < usedTypes.Count; b++)
            {
                pieChartData.Add(new Data.DataItem { Label = Functions.getExpensesTypeTextByID(usedTypes[b]), Value = expenseSum[usedTypes[b]] });
            }

            var seriesCollection = new SeriesCollection();
            foreach (var item in pieChartData)
            {
                seriesCollection.Add(new PieSeries
                {
                    Title = item.Label,
                    Values = new ChartValues<double> { item.Value },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.Y:0.##}€"
                });
            }

            cartesianChart1.Series = seriesCollection;
            cartesianChart1.LegendLocation = LegendLocation.Right;
        }

    }
}