using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finansu_programele
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
