using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Finansu_programele.Properties;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Finansu_programele
{
    public partial class MoreCharts : Form
    {
        private MainForm mainForm;
        private double targetSavingsPercentage = 0.2; // Numatytas taupymo tikslas (20%)

        public MoreCharts(MainForm form)
        {
            InitializeComponent();
            mainForm = form;


            var label = new Label
            {
                Text = "Pasirinkite algos efektyvumo %",
                Location = new Point(10, 10),
                Font = new Font("Arial", 10),
                AutoSize = true
            };
            Controls.Add(label);


            var numericUpDown = new NumericUpDown
            {
                Minimum = 0,
                Maximum = 100,
                Value = 20,
                DecimalPlaces = 1,
                Increment = 1,
                Location = new Point(label.Right + 10, 10),
                Width = 100
            };

            numericUpDown.ValueChanged += (s, e) =>
            {
                targetSavingsPercentage = (double)numericUpDown.Value / 100;
                InitializeSavingsEfficiencyChart();
            };

            Controls.Add(numericUpDown);
        }



        private void MoreCharts_Load(object sender, EventArgs e)
        {
            InitializeBarChart();
            InitializeLineChart();
            InitializeSavingsEfficiencyChart();
        }

        private void InitializeBarChart()
        {
            barChart.Series = new SeriesCollection();
            var currentMonth = mainForm.getMonthLabelId(); 
            var incomeNames = GetIncomeNames(currentMonth);
            var incomeAmounts = GetIncomeAmounts(currentMonth);

            for (int i = 0; i < incomeNames.Count; i++)
            {
                barChart.Series.Add(new ColumnSeries
                {
                    Title = incomeNames[i], 
                    Values = new ChartValues<double> { incomeAmounts[i] },
                    DataLabels = true,
                    LabelPoint = chartPoint => chartPoint.Y >= 1000 ? $"{chartPoint.Y / 1000:0.##}K €" : $"{chartPoint.Y:0.##} €"
                });
            }

           
            var currentMonthName = Data.months[currentMonth].monthName;

            barChart.AxisX.Add(new Axis
            {
                Title = $"Pajamų šaltiniai - {currentMonthName}",  
                Labels = new string[] { },   
                Separator = new Separator { Step = 1 }
            });

            barChart.AxisY.Add(new Axis
            {
                Title = "Suma (€)",
                LabelFormatter = value => value >= 1000 ? $"{value / 1000:0.##}K €" : $"{value:0.##} €"
            });
            barChart.DataTooltip = new DefaultTooltip
            {
                SelectionMode = TooltipSelectionMode.OnlySender
            };
        }


        private void InitializeLineChart()
        {
            lineChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Mėnesinės išlaidos",
                    Values = new ChartValues<double>(GetMonthlyExpenseTotals().Select(x => (double)x))
                }
            };

            lineChart.AxisX.Add(new Axis
            {
                Labels = GetMonthLabels().ToArray()
            });

            lineChart.AxisY.Add(new Axis
            {
                Title = "Suma (€)",
                LabelFormatter = value => value.ToString("C")
            });
        }

        private void InitializeSavingsEfficiencyChart()
        {
           
            var savingsEfficiencyValues = GetSavingsEfficiencyPercentages(targetSavingsPercentage);
            var monthLabels = GetMonthLabels();

            if (savingsEfficiencyValues == null || !savingsEfficiencyValues.Any() || !savingsEfficiencyValues.Any(v => v > 0))
            {
              
                savingsChart.Visible = false;

                var noSavingsMessageLabel = Controls.OfType<Label>().FirstOrDefault(l => l.Text.Contains("Nėra taupymo duomenų"));
                if (noSavingsMessageLabel == null)
                {
                    noSavingsMessageLabel = new Label
                    {
                        Text = "Nėra taupymo duomenų.\nPabandykite pradėti taupyti pagal 50/30/20 biudžeto metodą.",
                        Location = new Point(600, 250),
                        Font = new Font("Arial", 12),
                        ForeColor = Color.Red,
                        AutoSize = true
                    };
                    Controls.Add(noSavingsMessageLabel);
                }
            }
            else
            {
           
                savingsChart.Visible = true;

                var noSavingsMessageLabel = Controls.OfType<Label>().FirstOrDefault(l => l.Text.Contains("Nėra taupymo duomenų"));
                if (noSavingsMessageLabel != null)
                {
                    Controls.Remove(noSavingsMessageLabel);
                }

              
                savingsChart.Series.Clear();
                savingsChart.AxisX.Clear();
                savingsChart.AxisY.Clear();

            
                for (int i = 0; i < savingsEfficiencyValues.Count; i++)
                {
                    savingsChart.Series.Add(new ColumnSeries
                    {
                        Title = monthLabels[i],
                        Values = new ChartValues<double> { savingsEfficiencyValues[i] },
                        DataLabels = true,
                        LabelPoint = chartPoint => $"{chartPoint.Y:0.##}%"
                    });
                }

                savingsChart.AxisX.Add(new Axis
                {
                    Title = "Mėnesiai",         
                    Labels = new string[] { }, 
                    Separator = new Separator { Step = 1 }
                });


              


                
                savingsChart.AxisY.Add(new Axis
                {
                    Title = "Efektyvumas (%)",
                    LabelFormatter = value => $"{value:0.##}%"
                });

               
                savingsChart.DataTooltip = new DefaultTooltip
                {
                    SelectionMode = TooltipSelectionMode.OnlySender
                };

                
                double totalSaved = CalculateTotalSavedMoney();

                
                var totalSavingsLabel = new Label
                {
                    Text = $"Bendra sutaupyta suma: {totalSaved:C}",
                    Location = new Point(800, savingsChart.Bottom),
                    Font = new Font("Arial", 10),
                    AutoSize = true
                };
                Controls.Add(totalSavingsLabel);
            }
        }







        private List<double> GetSavingsEfficiencyPercentages(double targetSavingsPercentage)
        {
            var savingsEfficiency = new List<double>();

            foreach (var month in Data.months)
            {
                if (month.incomeAmount != null && month.expensePrice != null && month.expenseType != null)
                {
                    float incomeTotal = month.incomeAmount.Sum();
                    float savingsExpenses = 0;

               
                    for (int i = 0; i < month.expensePrice.Count; i++)
                    {
                        if (month.expenseType[i] == 2)  // Type 2 reiškia santaupas
                        {
                            savingsExpenses += month.expensePrice[i];
                        }
                    }

                 
                    double targetSavings = incomeTotal * targetSavingsPercentage;
                    double efficiency = targetSavings > 0 ? (savingsExpenses / targetSavings) * 100 : 0;

                    savingsEfficiency.Add(efficiency);
                }
                else
                {
                    savingsEfficiency.Add(0);
                }
            }

            return savingsEfficiency;
        }

        private double CalculateTotalSavedMoney()
        {
            double totalSaved = 0;

            foreach (var month in Data.months)
            {
                if (month.incomeAmount != null && month.expensePrice != null && month.expenseType != null)
                {
                   
                    for (int i = 0; i < month.expensePrice.Count; i++)
                    {
                        if (month.expenseType[i] == 2)  
                        {
                            totalSaved += month.expensePrice[i];
                        }
                    }
                }
            }

            return totalSaved;
        }








        private List<string> GetIncomeNames(int currentMonth)
        {
            return Data.months[currentMonth].incomeName;
        }

        private List<float> GetIncomeAmounts(int currentMonth)
        {
            return Data.months[currentMonth].incomeAmount;
        }

        private List<float> GetMonthlyExpenseTotals()
        {
            var monthlyExpenses = new List<float>();

            foreach (var month in Data.months)
            {
                if (month.expensePrice != null)
                {
                    float expenseTotal = month.expensePrice.Sum();
                    monthlyExpenses.Add(expenseTotal);
                }
                else
                {
                    monthlyExpenses.Add(0);
                }
            }

            return monthlyExpenses;
        }

        private List<string> GetMonthLabels()
        {
            return Data.months.Select(m => m.monthName).ToList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}