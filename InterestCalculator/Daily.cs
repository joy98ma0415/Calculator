using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Daily : Form
    {
        public Daily()
        {
            InitializeComponent();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            decimal Principal, Rate, Total, Interest;
            int Years;
            float InterestRate;
            double dailyRate;
            int Period = 0;

            try
            {
                Principal = decimal.Parse(textBoxPrincipal.Text);
                InterestRate = float.Parse(textBoxInterest.Text) / 100.0f;
                Years = int.Parse(textBoxYearsRate.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("輸入格式錯誤，請重新輸入！");
                return;
            }

            dailyRate = InterestRate / 365;
            Period = Years * 365;
            Rate = Principal * (decimal)Math.Pow((1 + dailyRate), (double)Period);
            Total = (decimal)Rate;
            Interest = Total - Principal;

            label1.Visible = true;
            labelResult.Text = string.Format(
                "1. 存款金額： {0:N0}  元 " + "\r\n" + "\r\n" +
                "2. 年 利 率： {1}  % " + "\r\n" + "\r\n" +
                "3. 存    期： {2}  年 " + "\r\n" + "\r\n" +
                "4. 利    息： {4:N0}  元 " + "\r\n" + "\r\n" +
                "5. 計算方式： Daily " + "\r\n" + "\r\n" +
                "6. 結算金額： {3:F2}  元 ", Principal, InterestRate, Years, Total, Interest);

            buttonCalculator.Visible = false;
            buttonExit.Visible = true;
            textBoxPrincipal.Clear();
            textBoxYearsRate.Clear();
            textBoxInterest.Clear();
        }

        private void AnnuallyCalculator_Click(object sender, EventArgs e)
        {
            Annually object1 = new Annually();
            this.Visible = false;
            object1.Visible = true;
        }

        private void SemiAnnually_Click(object sender, EventArgs e)
        {
            SemiAnnually object2 = new SemiAnnually();
            this.Visible = false;
            object2.Visible = true;
        }

        private void Quarterly_Click(object sender, EventArgs e)
        {
            Quarterly object3 = new Quarterly();
            this.Visible = false;
            object3.Visible = true;
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("利息計算器 by 馬顥心");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CalculateProject.MainForm main = new CalculateProject.MainForm();
            this.Visible = false;
            main.Visible = true;
        }
    }
}