using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            double Principal, Interest, yearsRate;

            try
            {
                Principal = Convert.ToDouble(textBoxPrincipal.Text);
                Interest = Convert.ToDouble(textBoxInterest.Text);
                yearsRate = Convert.ToDouble(textBoxYearsRate.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("格式輸入有誤，請重新輸入");
                return;
            }

            double Monthly, monthRate, payment, total, paymentInterest;
            Monthly = yearsRate * 12;
            monthRate = Interest / 12;
            payment = Principal * (monthRate / 100) / (1 - Math.Pow((1.0 + (monthRate / 100)), -Monthly));
            total = Monthly * payment;
            paymentInterest = total - Principal;

            textBoxResult.Text = "本金：$" + string.Format("{0:n}", Principal) + "\r\n" + Environment.NewLine +
                "月數：" + Monthly + "\r\n" + Environment.NewLine +
                "月利率：" + string.Format("{0:n}", monthRate) + "%" + "\r\n" + Environment.NewLine +
                "月付額：" + string.Format("{0:n}", payment) + "\r\n" + Environment.NewLine +
                "總共還款金額：$" + string.Format("{0:n}", total) + "\r\n" + Environment.NewLine +
                "還款利息：$" + string.Format("{0:n}", paymentInterest) + "\r\n" + Environment.NewLine +
                "----------------------------------------------------------------" + Environment.NewLine +
                "0月餘額：$" + string.Format("{0:n}", Principal) + Environment.NewLine;
            string t = textBoxResult.Text;
            int i;
            for (i = 1; i <= Monthly; i++)
            {
                Principal = Principal * (1 + (monthRate / 100)) - payment;
                t += i + "月餘額：$";
                t += string.Format("{0:n}", Principal);
                t += "\r\n";
            }
            textBoxResult.Text = t;

            buttonCalculator.Visible = false;
            buttonExit.Visible = true;
            textBoxPrincipal.Clear();
            textBoxYearsRate.Clear();
            textBoxInterest.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CalculateProject.MainForm main = new CalculateProject.MainForm();
            this.Visible = false;
            main.Visible = true;
        }
    }
}