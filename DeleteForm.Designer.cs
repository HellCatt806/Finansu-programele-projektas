namespace Finansu_programele
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.okButton = new System.Windows.Forms.Button();
            this.deleteExpenseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteIncomeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(241, 271);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(114, 40);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Gerai";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // deleteExpenseComboBox
            // 
            this.deleteExpenseComboBox.FormattingEnabled = true;
            this.deleteExpenseComboBox.Location = new System.Drawing.Point(428, 81);
            this.deleteExpenseComboBox.Name = "deleteExpenseComboBox";
            this.deleteExpenseComboBox.Size = new System.Drawing.Size(155, 28);
            this.deleteExpenseComboBox.TabIndex = 1;
            this.deleteExpenseComboBox.SelectedIndexChanged += new System.EventHandler(this.deleteExpenseComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasirinkite kurią išlaidą ištrinti:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pasirinkite kurią pajamą norite ištrinti:";
            // 
            // deleteIncomeComboBox
            // 
            this.deleteIncomeComboBox.FormattingEnabled = true;
            this.deleteIncomeComboBox.Location = new System.Drawing.Point(428, 158);
            this.deleteIncomeComboBox.Name = "deleteIncomeComboBox";
            this.deleteIncomeComboBox.Size = new System.Drawing.Size(155, 28);
            this.deleteIncomeComboBox.TabIndex = 3;
            this.deleteIncomeComboBox.SelectedIndexChanged += new System.EventHandler(this.deleteIncomeComboBox_SelectedIndexChanged);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteIncomeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteExpenseComboBox);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finansų programėlė";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox deleteExpenseComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox deleteIncomeComboBox;
    }
}