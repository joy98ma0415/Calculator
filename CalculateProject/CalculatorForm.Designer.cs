namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOperand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClearError = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonPowTwo = new System.Windows.Forms.Button();
            this.buttonFactorial = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button正負 = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康魏碑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxResult);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxOperand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxResult.Location = new System.Drawing.Point(101, 85);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(651, 46);
            this.textBoxResult.TabIndex = 3;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("華康隸書體W3", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "結  果：";
            // 
            // textBoxOperand
            // 
            this.textBoxOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxOperand.Location = new System.Drawing.Point(101, 21);
            this.textBoxOperand.Multiline = true;
            this.textBoxOperand.Name = "textBoxOperand";
            this.textBoxOperand.Size = new System.Drawing.Size(651, 46);
            this.textBoxOperand.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("華康隸書體W3", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "運算式：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.buttonClear);
            this.groupBox2.Controls.Add(this.buttonClearError);
            this.groupBox2.Controls.Add(this.buttonBackspace);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 82);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExit.Location = new System.Drawing.Point(657, 21);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 51);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClear.Location = new System.Drawing.Point(447, 21);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 51);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClearError
            // 
            this.buttonClearError.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonClearError.Location = new System.Drawing.Point(237, 21);
            this.buttonClearError.Name = "buttonClearError";
            this.buttonClearError.Size = new System.Drawing.Size(75, 51);
            this.buttonClearError.TabIndex = 1;
            this.buttonClearError.Text = "CE";
            this.buttonClearError.UseVisualStyleBackColor = true;
            this.buttonClearError.Click += new System.EventHandler(this.buttonClearError_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonBackspace.Location = new System.Drawing.Point(27, 21);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(75, 51);
            this.buttonBackspace.TabIndex = 0;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonEqual);
            this.groupBox3.Controls.Add(this.buttonZero);
            this.groupBox3.Controls.Add(this.buttonPoint);
            this.groupBox3.Controls.Add(this.buttonNine);
            this.groupBox3.Controls.Add(this.buttonEight);
            this.groupBox3.Controls.Add(this.buttonSeven);
            this.groupBox3.Controls.Add(this.buttonSix);
            this.groupBox3.Controls.Add(this.buttonFive);
            this.groupBox3.Controls.Add(this.buttonFour);
            this.groupBox3.Controls.Add(this.buttonThree);
            this.groupBox3.Controls.Add(this.buttonTwo);
            this.groupBox3.Controls.Add(this.buttonOne);
            this.groupBox3.Location = new System.Drawing.Point(12, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 365);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonEqual.Location = new System.Drawing.Point(274, 288);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(75, 51);
            this.buttonEqual.TabIndex = 15;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonZero.Location = new System.Drawing.Point(150, 288);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(75, 51);
            this.buttonZero.TabIndex = 14;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPoint.Location = new System.Drawing.Point(27, 288);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(75, 51);
            this.buttonPoint.TabIndex = 13;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonNine.Location = new System.Drawing.Point(274, 199);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(75, 51);
            this.buttonNine.TabIndex = 12;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonEight.Location = new System.Drawing.Point(150, 199);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(75, 51);
            this.buttonEight.TabIndex = 11;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSeven.Location = new System.Drawing.Point(27, 199);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(75, 51);
            this.buttonSeven.TabIndex = 10;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSix.Location = new System.Drawing.Point(274, 110);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(75, 51);
            this.buttonSix.TabIndex = 9;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFive.Location = new System.Drawing.Point(150, 110);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(75, 51);
            this.buttonFive.TabIndex = 8;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFour.Location = new System.Drawing.Point(27, 110);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(75, 51);
            this.buttonFour.TabIndex = 7;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonThree.Location = new System.Drawing.Point(273, 21);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(75, 51);
            this.buttonThree.TabIndex = 6;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonTwo.Location = new System.Drawing.Point(150, 21);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(75, 51);
            this.buttonTwo.TabIndex = 5;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonOne.Location = new System.Drawing.Point(27, 21);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(75, 51);
            this.buttonOne.TabIndex = 4;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonPowTwo);
            this.groupBox4.Controls.Add(this.buttonFactorial);
            this.groupBox4.Controls.Add(this.buttonDivide);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.buttonSqrt);
            this.groupBox4.Controls.Add(this.buttonMultiply);
            this.groupBox4.Controls.Add(this.button正負);
            this.groupBox4.Controls.Add(this.buttonPow);
            this.groupBox4.Controls.Add(this.buttonSubtract);
            this.groupBox4.Controls.Add(this.buttonMod);
            this.groupBox4.Controls.Add(this.buttonPercent);
            this.groupBox4.Controls.Add(this.buttonPlus);
            this.groupBox4.Location = new System.Drawing.Point(397, 299);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 365);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // buttonPowTwo
            // 
            this.buttonPowTwo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPowTwo.Location = new System.Drawing.Point(274, 288);
            this.buttonPowTwo.Name = "buttonPowTwo";
            this.buttonPowTwo.Size = new System.Drawing.Size(75, 51);
            this.buttonPowTwo.TabIndex = 15;
            this.buttonPowTwo.Text = "X ^2";
            this.buttonPowTwo.UseVisualStyleBackColor = true;
            this.buttonPowTwo.Click += new System.EventHandler(this.buttonPowTwo_Click);
            // 
            // buttonFactorial
            // 
            this.buttonFactorial.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFactorial.Location = new System.Drawing.Point(150, 288);
            this.buttonFactorial.Name = "buttonFactorial";
            this.buttonFactorial.Size = new System.Drawing.Size(75, 51);
            this.buttonFactorial.TabIndex = 14;
            this.buttonFactorial.Text = "n!";
            this.buttonFactorial.UseVisualStyleBackColor = true;
            this.buttonFactorial.Click += new System.EventHandler(this.buttonFactorial_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDivide.Location = new System.Drawing.Point(27, 288);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(75, 51);
            this.buttonDivide.TabIndex = 13;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button11.Location = new System.Drawing.Point(274, 199);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 51);
            this.button11.TabIndex = 12;
            this.button11.Text = "1/x";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSqrt.Location = new System.Drawing.Point(150, 199);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(75, 51);
            this.buttonSqrt.TabIndex = 11;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMultiply.Location = new System.Drawing.Point(27, 199);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(75, 51);
            this.buttonMultiply.TabIndex = 10;
            this.buttonMultiply.Text = "✖";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // button正負
            // 
            this.button正負.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button正負.Location = new System.Drawing.Point(274, 110);
            this.button正負.Name = "button正負";
            this.button正負.Size = new System.Drawing.Size(75, 51);
            this.button正負.TabIndex = 9;
            this.button正負.Text = "±";
            this.button正負.UseVisualStyleBackColor = true;
            this.button正負.Click += new System.EventHandler(this.button正負_Click);
            // 
            // buttonPow
            // 
            this.buttonPow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPow.Location = new System.Drawing.Point(150, 110);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(75, 51);
            this.buttonPow.TabIndex = 8;
            this.buttonPow.Text = "X ^ Y";
            this.buttonPow.UseVisualStyleBackColor = true;
            this.buttonPow.Click += new System.EventHandler(this.buttonPow_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSubtract.Location = new System.Drawing.Point(27, 110);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(75, 51);
            this.buttonSubtract.TabIndex = 7;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonMod.Location = new System.Drawing.Point(273, 21);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 51);
            this.buttonMod.TabIndex = 6;
            this.buttonMod.Text = "Mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPercent.Location = new System.Drawing.Point(150, 21);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(75, 51);
            this.buttonPercent.TabIndex = 5;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPlus.Location = new System.Drawing.Point(27, 21);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 51);
            this.buttonPlus.TabIndex = 4;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 686);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "計算機 Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOperand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearError;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonPowTwo;
        private System.Windows.Forms.Button buttonFactorial;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button button正負;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonPlus;
    }
}

