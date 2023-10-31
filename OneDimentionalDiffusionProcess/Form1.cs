using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneDimentionalDiffusionProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();

            Graphics gg = CreateGraphics();
            SolidBrush sb = new SolidBrush(Color.Blue);

            Density obj = new Density(gg, this, sb);
        }
    }
}
