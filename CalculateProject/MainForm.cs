using InterestCalculate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculator.CalculatorForm object1 = new Calculator.CalculatorForm();
            this.Visible = false;
            object1.Visible = true;
        }

        private void buttonArithmeticCalculate_Click(object sender, EventArgs e)
        {
            ArithmeticCalculator.Calculator object2 = new ArithmeticCalculator.Calculator();
            this.Visible = false;
            object2.Visible = true;
        }

        private void buttonInterestCalculate_Click(object sender, EventArgs e)
        {
            InterestMainForm object3 = new InterestMainForm();
            this.Visible = false;
            object3.Visible = true;
        }

        private void buttonLoanCalculate_Click(object sender, EventArgs e)
        {
            LoanCalculator.Form1 object4 = new LoanCalculator.Form1();
            this.Visible = false;
            object4.Visible = true;
        }

        private void buttonPCalculate_Click(object sender, EventArgs e)
        {
            PostageCalculate.Form1 object5 = new PostageCalculate.Form1();
            this.Visible = false;
            object5.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}