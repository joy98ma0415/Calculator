using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculate
{
    public partial class InterestMainForm : Form
    {
        public InterestMainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("利息計算器 by 馬顥心");
        }

        private void AnnuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Annually object1 = new Annually();
            this.Visible = false;
            object1.Visible = true;
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Daily object2 = new Daily();
            this.Visible = false;
            object2.Visible = true;
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monthly object3 = new Monthly();
            this.Visible = false;
            object3.Visible = true;
        }

        private void quarterlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quarterly object4 = new Quarterly();
            this.Visible = false;
            object4.Visible = true;
        }

        private void semiAnnuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SemiAnnually object5 = new SemiAnnually();
            this.Visible = false;
            object5.Visible = true;
        }
    }
}