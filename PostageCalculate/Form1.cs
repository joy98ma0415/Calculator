using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostageCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int g, q;

            try
            {
                g = int.Parse(textBoxKG.Text);
                q = int.Parse(textBoxQuantity.Text);
            }
            catch
            {
                MessageBox.Show("請重新輸入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("請選擇計算方式", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (System.Convert.ToInt16(textBoxKG.Text) < 20)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelResult.Text = "信函普通郵資：" + " 8 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 8 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelResult.Text = "信函限時郵資：" + " 15 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 15 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelResult.Text = "信函掛號郵資：" + " 28 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 28 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelResult.Text = "信函限時掛號郵資：" + " 35 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 35 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelResult.Text = "信函掛號付回執郵資：" + " 43 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 43 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelResult.Text = "信函限時掛號付回執郵資：" + " 50 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 50 * q + " 元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKG.Text) >= 21 & System.Convert.ToInt16(textBoxKG.Text) <= 50)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelResult.Text = "信函普通郵資：" + " 16 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 16 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelResult.Text = "信函限時郵資：" + " 23 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 23 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelResult.Text = "信函掛號郵資：" + " 36 " + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 36 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelResult.Text = "信函限時掛號郵資：" + " 43 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 43 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelResult.Text = "信函掛號付回執郵資：" + " 51 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 51 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelResult.Text = "信函限時付回執郵資：" + " 58 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 58 * q + " 元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKG.Text) >= 51 & System.Convert.ToInt16(textBoxKG.Text) <= 100)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelResult.Text = "信函普通郵資：" + " 24 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 24 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelResult.Text = "信函限時郵資：" + " 31 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 31 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelResult.Text = "信函掛號郵資：" + " 46 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 46 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelResult.Text = "信函限時掛號郵資：" + " 51 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 51 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelResult.Text = "信函掛號付回執郵資：" + " 59 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 59 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelResult.Text = "信函限時付回執郵資：" + " 66 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 66 * q + " 元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKG.Text) >= 101 & System.Convert.ToInt16(textBoxKG.Text) <= 250)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelResult.Text = "信函普通郵資：" + " 40 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 40 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelResult.Text = "信函限時郵資：" + " 47 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 47 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelResult.Text = "信函掛號郵資：" + " 60 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 60 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelResult.Text = "信函限時掛號郵資：" + " 67 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 67 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelResult.Text = "信函掛號付回執郵資：" + " 75 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 75 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelResult.Text = "信函限時付回執郵資：" + " 82 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 82 * q + " 元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKG.Text) >= 251 & System.Convert.ToInt16(textBoxKG.Text) <= 500)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelResult.Text = "信函普通郵資：" + " 72 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 72 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelResult.Text = "信函限時郵資：" + " 79 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 79 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelResult.Text = "信函掛號郵資：" + " 92 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 92 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelResult.Text = "信函限時掛號郵資：" + " 99 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 99 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelResult.Text = "信函掛號付回執郵資：" + " 107 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 107 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelResult.Text = "信函限時付回執郵資：" + " 114 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 114 * q + " 元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKG.Text) >= 501 & System.Convert.ToInt16(textBoxKG.Text) <= 1000)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelResult.Text = "信函普通郵資：" + " 112 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 112 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelResult.Text = "信函限時郵資：" + " 119 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 119 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelResult.Text = "信函掛號郵資：" + " 132 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 132 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelResult.Text = "信函限時掛號郵資：" + " 139 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 139 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelResult.Text = "信函掛號付回執郵資：" + " 147 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 147 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelResult.Text = "信函限時付回執郵資：" + " 154 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 154 * q + " 元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else if (System.Convert.ToInt16(textBoxKG.Text) >= 1001 & System.Convert.ToInt16(textBoxKG.Text) <= 2000)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "普通":
                        labelResult.Text = "信函普通郵資：" + " 160 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 160 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時":
                        labelResult.Text = "信函限時郵資：" + " 167 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 167 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號":
                        labelResult.Text = "信函掛號郵資：" + " 180 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 180 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號":
                        labelResult.Text = "信函限時掛號郵資：" + " 187 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 187 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "掛號付回執":
                        labelResult.Text = "信函掛號付回執郵資：" + " 195 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 195 * q + " 元" + "\r\n" + "\r\n";
                        break;

                    case "限時掛號付回執":
                        labelResult.Text = "信函限時付回執郵資：" + " 202 " + " 元" + "\r\n" + "\r\n" +
                            "包裹數量：" + string.Format("{0}", q) + "\r\n" + "\r\n" +
                            "包裹金額：" + 202 * q + " 元" + "\r\n" + "\r\n";
                        break;
                }
            }
            else
            {
                labelResult.Text = "您輸入的公克數不得超過2公斤！";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("請選擇");
            comboBox1.Items.Add("普通");
            comboBox1.Items.Add("限時");
            comboBox1.Items.Add("掛號");
            comboBox1.Items.Add("限時掛號");
            comboBox1.Items.Add("掛號附回執");
            comboBox1.Items.Add("限時掛號附回執");
            comboBox1.SelectedIndex = 0;
        }
    }
}