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
    public partial class MoreCharts : Form
    {
        private MainForm mainform;
        public MoreCharts(MainForm form)
        {
            InitializeComponent();
            mainform = form;
        }

        private void MoreCharts_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
