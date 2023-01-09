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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Sims3Init sims3Init = new Sims3Init();
            SystemInfo sysInfo = new SystemInfo();

            StringBuilder dynamicAvoidance = new StringBuilder();

            sims3Init.Backup();

            numMemoryLimit.Value = Decimal.Parse(sims3Init.ReadProperty("MemoryUsageLimit"));

            dynamicAvoidance.Append("DynamicAvoidance_FieldRadius: " + sims3Init.ReadProperty("DynamicAvoidance_FieldRadius") + "\n");
            dynamicAvoidance.Append("DynamicAvoidance_InactiveFieldLength: " + sims3Init.ReadProperty("DynamicAvoidance_InactiveFieldLength") + "\n");
            dynamicAvoidance.Append("DynamicAvoidance_MinNonIntersectingDistance: " + sims3Init.ReadProperty("DynamicAvoidance_MinNonIntersectingDistance") + "\n");
            dynamicAvoidance.Append("DynamicAvoidance_FieldLengthPad: " + sims3Init.ReadProperty("DynamicAvoidance_FieldLengthPad") + "\n");
            dynamicAvoidance.Append("DynamicAvoidance_StopDistanceMultiplier: " + sims3Init.ReadProperty("DynamicAvoidance_StopDistanceMultiplier") + "\n");

            // Console.WriteLine(sims3Init.fileContent);

            richTextBox1.Text = sims3Init.fileContent;

            sysInfo.ReadGPUInfo();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
