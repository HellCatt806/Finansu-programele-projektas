namespace Finansu_programele
{
    partial class AddExpensesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpensesForm));
            this.label1 = new System.Windows.Forms.Label();
            this.expenseTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expenseTypeOption = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.expenseAmounttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pridėti išlaidas";
            // 
            // expenseTextBox
            // 
            this.expenseTextBox.Location = new System.Drawing.Point(349, 79);
            this.expenseTextBox.Name = "expenseTextBox";
            this.expenseTextBox.Size = new System.Drawing.Size(161, 26);
            this.expenseTextBox.TabIndex = 1;
            this.expenseTextBox.TextChanged += new System.EventHandler(this.expenseTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Išlaidos pavadinimas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Išlaidos rušis";
            // 
            // expenseTypeOption
            // 
            this.expenseTypeOption.FormattingEnabled = true;
            this.expenseTypeOption.Items.AddRange(new object[] {
            "Maistas",
            "Transportas",
            "Taupymas",
            "Skolos",
            "Mokesčiai",
            "Buitinės išlaidos",
            "Švietimas (mokslai)",
            "Kita"});
            this.expenseTypeOption.Location = new System.Drawing.Point(349, 160);
            this.expenseTypeOption.Name = "expenseTypeOption";
            this.expenseTypeOption.Size = new System.Drawing.Size(161, 28);
            this.expenseTypeOption.TabIndex = 4;
            this.expenseTypeOption.SelectedIndexChanged += new System.EventHandler(this.expenseTypeOption_SelectedIndexChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(91, 220);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 46);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Atšaukti";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(376, 220);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(105, 46);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "Gerai";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Išlaidos kiekis";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // expenseAmounttextBox
            // 
            this.expenseAmounttextBox.Location = new System.Drawing.Point(349, 117);
            this.expenseAmounttextBox.Name = "expenseAmounttextBox";
            this.expenseAmounttextBox.Size = new System.Drawing.Size(161, 26);
            this.expenseAmounttextBox.TabIndex = 8;
            // 
            // AddExpensesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(567, 287);
            this.Controls.Add(this.expenseAmounttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.expenseTypeOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expenseTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddExpensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pridėti Išlaidas";
            this.Load += new System.EventHandler(this.AddExpensesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expenseTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expenseTypeOption;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expenseAmounttextBox;
    }
}