namespace CalculateProject
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPCalculate = new System.Windows.Forms.Button();
            this.buttonLoanCalculate = new System.Windows.Forms.Button();
            this.buttonInterestCalculate = new System.Windows.Forms.Button();
            this.buttonArithmeticCalculate = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonPCalculate);
            this.groupBox1.Controls.Add(this.buttonLoanCalculate);
            this.groupBox1.Controls.Add(this.buttonInterestCalculate);
            this.groupBox1.Controls.Add(this.buttonArithmeticCalculate);
            this.groupBox1.Controls.Add(this.buttonCalculate);
            this.groupBox1.Font = new System.Drawing.Font("華康魏碑體", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(45, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 359);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "有關計算專案";
            // 
            // buttonPCalculate
            // 
            this.buttonPCalculate.Location = new System.Drawing.Point(303, 159);
            this.buttonPCalculate.Name = "buttonPCalculate";
            this.buttonPCalculate.Size = new System.Drawing.Size(109, 54);
            this.buttonPCalculate.TabIndex = 4;
            this.buttonPCalculate.Text = "郵資計算器";
            this.buttonPCalculate.UseVisualStyleBackColor = true;
            this.buttonPCalculate.Click += new System.EventHandler(this.buttonPCalculate_Click);
            // 
            // buttonLoanCalculate
            // 
            this.buttonLoanCalculate.Location = new System.Drawing.Point(303, 42);
            this.buttonLoanCalculate.Name = "buttonLoanCalculate";
            this.buttonLoanCalculate.Size = new System.Drawing.Size(109, 54);
            this.buttonLoanCalculate.TabIndex = 3;
            this.buttonLoanCalculate.Text = "貸款計算器";
            this.buttonLoanCalculate.UseVisualStyleBackColor = true;
            this.buttonLoanCalculate.Click += new System.EventHandler(this.buttonLoanCalculate_Click);
            // 
            // buttonInterestCalculate
            // 
            this.buttonInterestCalculate.Location = new System.Drawing.Point(36, 276);
            this.buttonInterestCalculate.Name = "buttonInterestCalculate";
            this.buttonInterestCalculate.Size = new System.Drawing.Size(109, 54);
            this.buttonInterestCalculate.TabIndex = 2;
            this.buttonInterestCalculate.Text = "利息計算器";
            this.buttonInterestCalculate.UseVisualStyleBackColor = true;
            this.buttonInterestCalculate.Click += new System.EventHandler(this.buttonInterestCalculate_Click);
            // 
            // buttonArithmeticCalculate
            // 
            this.buttonArithmeticCalculate.Location = new System.Drawing.Point(36, 159);
            this.buttonArithmeticCalculate.Name = "buttonArithmeticCalculate";
            this.buttonArithmeticCalculate.Size = new System.Drawing.Size(109, 54);
            this.buttonArithmeticCalculate.TabIndex = 1;
            this.buttonArithmeticCalculate.Text = "四則運算計算器";
            this.buttonArithmeticCalculate.UseVisualStyleBackColor = true;
            this.buttonArithmeticCalculate.Click += new System.EventHandler(this.buttonArithmeticCalculate_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(36, 42);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(109, 54);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "普通計算器";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(303, 276);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 54);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "專案主畫面";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPCalculate;
        private System.Windows.Forms.Button buttonLoanCalculate;
        private System.Windows.Forms.Button buttonInterestCalculate;
        private System.Windows.Forms.Button buttonArithmeticCalculate;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonExit;
    }
}

