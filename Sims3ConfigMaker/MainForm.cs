using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sims3ConfigMaker.src.model;

namespace Sims3ConfigMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sims3Init sims3Init = new Sims3Init();

            numMemoryLimit.Value = Decimal.Parse(sims3Init.ReadProperty("MemoryUsageLimit"));

            Console.WriteLine(sims3Init.fileContent);

            lblLoad.Text = sims3Init.fileContent;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
