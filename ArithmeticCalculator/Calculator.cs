using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string input = "";

        ///<summary>
        ///輸入函數
        ///</summary>
        ///<param name="c">輸入的字符</param>
        private void Input(char c)
        {
            input += c;
        }

        ///<summary>
        ///顯示函數
        ///</summary>
        private void ShowMessage()
        {
            textBoxOutput.Text = input;
        }

        #region 輸入

        private void buttonOne_Click(object sender, EventArgs e)
        {
            Input('1');
            ShowMessage();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Input('2');
            ShowMessage();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            Input('3');
            ShowMessage();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            Input('4');
            ShowMessage();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            Input('5');
            ShowMessage();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            Input('6');
            ShowMessage();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            Input('7');
            ShowMessage();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            Input('8');
            ShowMessage();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            Input('9');
            ShowMessage();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            Input('0');
            ShowMessage();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Input('+');
            ShowMessage();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Input('-');
            ShowMessage();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Input('✖');
            ShowMessage();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Input('÷');
            ShowMessage();
        }

        private void buttonSpot_Click(object sender, EventArgs e)
        {
            Input('.');
            ShowMessage();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            input = "";
            textBoxOutput.Clear();
            ShowMessage();
            textBoxOutput.ReadOnly = false;
            buttonEuqal.Enabled = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (input.Length != 0)
                {
                    textBoxOutput.Text = textBoxOutput.Text.Substring(0, textBoxOutput.Text.Length - 1);
                }
            }
            catch
            {
                MessageBox.Show("Error! Please No numbers need to be clear.");
            }
        }

        private void buttonClearError_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = string.Empty;
        }

        #endregion 輸入

        ///<summary>
        ///判斷運算優先級
        ///</summary>
        ///<param name = "sign"></param>
        ///<returns></returns>
        ///
        private int GetSignpriority(char sign)
        {
            switch (sign)
            {
                case '+':
                case '-':
                    return 1;

                case '✖':
                case '÷':
                    return 2;
            }
            return -1;
        }

        ///<summary>
        ///分析後綴表達式
        ///</summary>
        ///<param name="obj">用戶輸入的訊息</param>
        ///<returns></returns>
        private int PostifixExpression(string obj)
        {
            if (obj == "+")
            {
                return '+';
            }
            else if (obj == "-")
            {
                return '-';
            }
            else if (obj == "✖")
            {
                return '✖';
            }
            else if (obj == "÷")
            {
                return '÷';
            }
            else
            {
                return '0';
            }
        }

        ///<summary>
        ///計算表達式結果
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="e"></param>
        private void buttonEuqal_Click(object sender, EventArgs e)
        {
            buttonEuqal.Enabled = false;
            Stack<double> temStack = new Stack<double>();
            Queue<string> postifixExpressionQueue = new Queue<string>();
            Stack<char> SignStack = new Stack<char>();

            string tempString = "";
            int objType;
            double tempDouble;

            try
            {
                #region 中綴式表達式轉後綴式表達式

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] <= '9' && input[i] >= '0' || input[i] == '.')
                    {
                        tempString += input[i];
                    }
                    else
                    {
                        if (tempString.Length > 0)
                        {
                            postifixExpressionQueue.Enqueue(tempString);
                            tempString = "";
                        }
                        if (SignStack.Count == 0)
                        {
                            SignStack.Push(input[i]);
                        }
                        else
                        {
                            #region 判斷運算式優先級

                            if (GetSignpriority(input[i]) > GetSignpriority(SignStack.Peek()))
                            {
                                SignStack.Push(input[i]);
                            }
                            else
                            {
                                while (true)
                                {
                                    postifixExpressionQueue.Enqueue(Convert.ToString(SignStack.Pop()));
                                    if (SignStack.Count == 0 || GetSignpriority(input[i]) > GetSignpriority(SignStack.Peek()))
                                        break;
                                }
                                SignStack.Push(input[i]);
                            }

                            #endregion 判斷運算式優先級
                        }
                    }
                }///end for

                if (tempString.Length > 0)
                {
                    postifixExpressionQueue.Enqueue(tempString);
                    tempString = "";
                }
                while (SignStack.Count > 0)
                {
                    postifixExpressionQueue.Enqueue(Convert.ToString(SignStack.Pop()));
                }

                #endregion 中綴式表達式轉後綴式表達式

                SignStack.Clear();
                tempString = "";

                #region 計算後綴式表達

                while (postifixExpressionQueue.Count > 0)
                {
                    objType = PostifixExpression(postifixExpressionQueue.Peek());
                    switch (objType)
                    {
                        case '0':
                            temStack.Push(Convert.ToDouble(postifixExpressionQueue.Dequeue()));
                            break;

                        case '+':
                            postifixExpressionQueue.Dequeue();
                            temStack.Push(temStack.Pop() + temStack.Pop());
                            break;

                        case '-':
                            postifixExpressionQueue.Dequeue();
                            tempDouble = temStack.Pop();
                            temStack.Push(temStack.Pop() - tempDouble);
                            break;

                        case '✖':
                            postifixExpressionQueue.Dequeue();
                            temStack.Push(temStack.Pop() * temStack.Pop());
                            break;

                        case '÷':
                            postifixExpressionQueue.Dequeue();
                            tempDouble = temStack.Pop();
                            if (tempDouble != 0)
                            {
                                temStack.Push(temStack.Pop() / tempDouble);
                            }
                            else
                            {
                                MessageBox.Show("Error!0不能是被除數");
                            }
                            break;

                        default:
                            MessageBox.Show("未知的錯誤!");
                            break;
                    }
                }

                #endregion 計算後綴式表達

                input += "=" + Convert.ToString(temStack.Pop());

                ShowMessage();

                textBoxOutput.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確的運算式!");
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBoxOutput.Text.Contains("-"))
                {
                    textBoxOutput.Text = "-" + textBoxOutput.Text;
                }
                else
                {
                    textBoxOutput.Text = textBoxOutput.Text.Remove(0, 1);
                }
            }
            catch
            {
                MessageBox.Show("Error! Please enter the number.");
            }
        }
    }
}