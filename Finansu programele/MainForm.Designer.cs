using System.Windows.Forms;

namespace Finansu_programele
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem saveDataButton;
            System.Windows.Forms.ToolStripMenuItem loadDataButton;
            System.Windows.Forms.ToolStripMenuItem closeProgramButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veiksmaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthLabel = new System.Windows.Forms.Label();
            this.addExpensesButton = new System.Windows.Forms.Button();
            this.addIncomeButton = new System.Windows.Forms.Button();
            this.moreDiagramsButton = new System.Windows.Forms.Button();
            this.expensePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expensesLabel = new System.Windows.Forms.Label();
            this.expensesTotalLabelDefault = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tipsLabel = new System.Windows.Forms.Label();
            this.tipstextBox = new System.Windows.Forms.TextBox();
            this.previousMonthButton = new System.Windows.Forms.Button();
            this.nextMonthButton = new System.Windows.Forms.Button();
            this.incomePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.incomeLabelDefault = new System.Windows.Forms.Label();
            this.incomeTotalLabelDefault = new System.Windows.Forms.Label();
            this.expenseIncomeTotalPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            saveDataButton = new System.Windows.Forms.ToolStripMenuItem();
            loadDataButton = new System.Windows.Forms.ToolStripMenuItem();
            closeProgramButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.expensePanel.SuspendLayout();
            this.incomePanel.SuspendLayout();
            this.expenseIncomeTotalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveDataButton
            // 
            saveDataButton.Name = "saveDataButton";
            saveDataButton.Size = new System.Drawing.Size(270, 34);
            saveDataButton.Text = "Išsaugoti duomenis";
            saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // loadDataButton
            // 
            loadDataButton.Name = "loadDataButton";
            loadDataButton.Size = new System.Drawing.Size(270, 34);
            loadDataButton.Text = "Užkrauti duomenis";
            loadDataButton.Click += new System.EventHandler(this.loadDataButton_Click);
            // 
            // closeProgramButton
            // 
            closeProgramButton.Name = "closeProgramButton";
            closeProgramButton.Size = new System.Drawing.Size(270, 34);
            closeProgramButton.Text = "Uždaryti programą";
            closeProgramButton.Click += new System.EventHandler(this.closeProgramButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiksmaiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veiksmaiToolStripMenuItem
            // 
            this.veiksmaiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.veiksmaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            saveDataButton,
            loadDataButton,
            closeProgramButton});
            this.veiksmaiToolStripMenuItem.Name = "veiksmaiToolStripMenuItem";
            this.veiksmaiToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.veiksmaiToolStripMenuItem.Text = "Veiksmai";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(435, 9);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(159, 37);
            this.monthLabel.TabIndex = 3;
            this.monthLabel.Text = "Rugpjūtis";
            this.monthLabel.Click += new System.EventHandler(this.monthLabel_Click);
            // 
            // addExpensesButton
            // 
            this.addExpensesButton.BackColor = System.Drawing.Color.Peru;
            this.addExpensesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpensesButton.ForeColor = System.Drawing.Color.Black;
            this.addExpensesButton.Location = new System.Drawing.Point(131, 474);
            this.addExpensesButton.Name = "addExpensesButton";
            this.addExpensesButton.Size = new System.Drawing.Size(133, 39);
            this.addExpensesButton.TabIndex = 4;
            this.addExpensesButton.Text = "Pridėti išlaidas";
            this.addExpensesButton.UseVisualStyleBackColor = false;
            this.addExpensesButton.Click += new System.EventHandler(this.addExpensesButton_Click);
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addIncomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncomeButton.Location = new System.Drawing.Point(278, 474);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(144, 39);
            this.addIncomeButton.TabIndex = 5;
            this.addIncomeButton.Text = "Pridėti pajamas";
            this.addIncomeButton.UseVisualStyleBackColor = false;
            this.addIncomeButton.Click += new System.EventHandler(this.addIncomeButton_Click);
            // 
            // moreDiagramsButton
            // 
            this.moreDiagramsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreDiagramsButton.Location = new System.Drawing.Point(833, 474);
            this.moreDiagramsButton.Name = "moreDiagramsButton";
            this.moreDiagramsButton.Size = new System.Drawing.Size(171, 39);
            this.moreDiagramsButton.TabIndex = 6;
            this.moreDiagramsButton.Text = "Daugiau diagramų";
            this.moreDiagramsButton.UseVisualStyleBackColor = true;
            this.moreDiagramsButton.Click += new System.EventHandler(this.moreDiagramsButton_Click);
            // 
            // expensePanel
            // 
            this.expensePanel.AutoScroll = true;
            this.expensePanel.Controls.Add(this.label4);
            this.expensePanel.Controls.Add(this.label3);
            this.expensePanel.Controls.Add(this.label2);
            this.expensePanel.Controls.Add(this.expensesLabel);
            this.expensePanel.Location = new System.Drawing.Point(12, 56);
            this.expensePanel.Name = "expensePanel";
            this.expensePanel.Size = new System.Drawing.Size(252, 325);
            this.expensePanel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Higienos priemones 20eur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kuras 80eur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sporto salė 35eur";
            // 
            // expensesLabel
            // 
            this.expensesLabel.AutoSize = true;
            this.expensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensesLabel.Location = new System.Drawing.Point(17, 26);
            this.expensesLabel.Name = "expensesLabel";
            this.expensesLabel.Size = new System.Drawing.Size(71, 20);
            this.expensesLabel.TabIndex = 0;
            this.expensesLabel.Text = "Išlaidos";
            this.expensesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // expensesTotalLabelDefault
            // 
            this.expensesTotalLabelDefault.AutoSize = true;
            this.expensesTotalLabelDefault.Location = new System.Drawing.Point(17, 19);
            this.expensesTotalLabelDefault.Name = "expensesTotalLabelDefault";
            this.expensesTotalLabelDefault.Size = new System.Drawing.Size(111, 20);
            this.expensesTotalLabelDefault.TabIndex = 8;
            this.expensesTotalLabelDefault.Text = "Iš viso: 300eur";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(674, 56);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(324, 204);
            this.cartesianChart1.TabIndex = 8;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // tipsLabel
            // 
            this.tipsLabel.AutoSize = true;
            this.tipsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipsLabel.Location = new System.Drawing.Point(684, 295);
            this.tipsLabel.Name = "tipsLabel";
            this.tipsLabel.Size = new System.Drawing.Size(196, 25);
            this.tipsLabel.TabIndex = 9;
            this.tipsLabel.Text = "Taupymo patarimai";
            // 
            // tipstextBox
            // 
            this.tipstextBox.BackColor = System.Drawing.SystemColors.Control;
            this.tipstextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tipstextBox.Location = new System.Drawing.Point(531, 333);
            this.tipstextBox.Multiline = true;
            this.tipstextBox.Name = "tipstextBox";
            this.tipstextBox.ReadOnly = true;
            this.tipstextBox.Size = new System.Drawing.Size(479, 111);
            this.tipstextBox.TabIndex = 10;
            this.tipstextBox.Text = resources.GetString("tipstextBox.Text");
            // 
            // previousMonthButton
            // 
            this.previousMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousMonthButton.Location = new System.Drawing.Point(441, 474);
            this.previousMonthButton.Name = "previousMonthButton";
            this.previousMonthButton.Size = new System.Drawing.Size(178, 39);
            this.previousMonthButton.TabIndex = 11;
            this.previousMonthButton.Text = "Ankstesnis mėnesis";
            this.previousMonthButton.UseVisualStyleBackColor = true;
            this.previousMonthButton.Click += new System.EventHandler(this.previousMonthButton_Click);
            // 
            // nextMonthButton
            // 
            this.nextMonthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMonthButton.Location = new System.Drawing.Point(636, 474);
            this.nextMonthButton.Name = "nextMonthButton";
            this.nextMonthButton.Size = new System.Drawing.Size(178, 39);
            this.nextMonthButton.TabIndex = 12;
            this.nextMonthButton.Text = "Sekantis mėnesis";
            this.nextMonthButton.UseVisualStyleBackColor = true;
            this.nextMonthButton.Click += new System.EventHandler(this.nextMonthButton_Click);
            // 
            // incomePanel
            // 
            this.incomePanel.AutoScroll = true;
            this.incomePanel.Controls.Add(this.label1);
            this.incomePanel.Controls.Add(this.label5);
            this.incomePanel.Controls.Add(this.label6);
            this.incomePanel.Controls.Add(this.incomeLabelDefault);
            this.incomePanel.Location = new System.Drawing.Point(270, 56);
            this.incomePanel.Name = "incomePanel";
            this.incomePanel.Size = new System.Drawing.Size(255, 325);
            this.incomePanel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Higienos priemones 20eur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kuras 80eur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sporto salė 35eur";
            // 
            // incomeLabelDefault
            // 
            this.incomeLabelDefault.AutoSize = true;
            this.incomeLabelDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLabelDefault.Location = new System.Drawing.Point(17, 26);
            this.incomeLabelDefault.Name = "incomeLabelDefault";
            this.incomeLabelDefault.Size = new System.Drawing.Size(77, 20);
            this.incomeLabelDefault.TabIndex = 0;
            this.incomeLabelDefault.Text = "Pajamos";
            // 
            // incomeTotalLabelDefault
            // 
            this.incomeTotalLabelDefault.AutoSize = true;
            this.incomeTotalLabelDefault.Location = new System.Drawing.Point(275, 19);
            this.incomeTotalLabelDefault.Name = "incomeTotalLabelDefault";
            this.incomeTotalLabelDefault.Size = new System.Drawing.Size(111, 20);
            this.incomeTotalLabelDefault.TabIndex = 8;
            this.incomeTotalLabelDefault.Text = "Iš viso: 300eur";
            this.incomeTotalLabelDefault.Click += new System.EventHandler(this.incomeTotalLabelDefault_Click);
            // 
            // expenseIncomeTotalPanel
            // 
            this.expenseIncomeTotalPanel.Controls.Add(this.expensesTotalLabelDefault);
            this.expenseIncomeTotalPanel.Controls.Add(this.incomeTotalLabelDefault);
            this.expenseIncomeTotalPanel.Location = new System.Drawing.Point(12, 387);
            this.expenseIncomeTotalPanel.Name = "expenseIncomeTotalPanel";
            this.expenseIncomeTotalPanel.Size = new System.Drawing.Size(513, 55);
            this.expenseIncomeTotalPanel.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Keisti sarašą";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.expenseIncomeTotalPanel);
            this.Controls.Add(this.incomePanel);
            this.Controls.Add(this.nextMonthButton);
            this.Controls.Add(this.previousMonthButton);
            this.Controls.Add(this.tipstextBox);
            this.Controls.Add(this.tipsLabel);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.expensePanel);
            this.Controls.Add(this.moreDiagramsButton);
            this.Controls.Add(this.addIncomeButton);
            this.Controls.Add(this.addExpensesButton);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finansų programėlė";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.expensePanel.ResumeLayout(false);
            this.expensePanel.PerformLayout();
            this.incomePanel.ResumeLayout(false);
            this.incomePanel.PerformLayout();
            this.expenseIncomeTotalPanel.ResumeLayout(false);
            this.expenseIncomeTotalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veiksmaiToolStripMenuItem;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button addExpensesButton;
        private System.Windows.Forms.Button addIncomeButton;
        private System.Windows.Forms.Button moreDiagramsButton;
        private System.Windows.Forms.Panel expensePanel;
        private System.Windows.Forms.Label expensesLabel;
        private System.Windows.Forms.Label expensesTotalLabelDefault;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label tipsLabel;
        private System.Windows.Forms.TextBox tipstextBox;
        private Button previousMonthButton;
        private Button nextMonthButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel incomePanel;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label incomeTotalLabelDefault;
        private Label incomeLabelDefault;
        private Panel expenseIncomeTotalPanel;
        private Button button1;
    }
}

