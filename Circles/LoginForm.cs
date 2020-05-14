using System;
using System.Windows.Forms;

namespace Circles
{
    public partial class LoginForm : Form
    {
        private ToolTip toolTipAvg;
        private ToolTip toolTipMax;

        public LoginForm()
        {
            InitializeComponent();

            toolTipAvg = new ToolTip {InitialDelay = 200, ReshowDelay = 500};
            toolTipAvg.SetToolTip(AvgBar, AvgBar.Value.ToString());
            toolTipMax = new ToolTip {InitialDelay = 200, ReshowDelay = 500};
            toolTipMax.SetToolTip(MaxBar, MaxBar.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaxBar_Scroll(object sender, EventArgs e)
        {
            toolTipMax.SetToolTip(MaxBar, MaxBar.Value.ToString());
        }

        private void AvgBar_Scroll(object sender, EventArgs e)
        {
            toolTipAvg.SetToolTip(AvgBar, AvgBar.Value.ToString());
        }
    }
}