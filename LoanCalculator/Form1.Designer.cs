namespace LoanCalculator
{
    partial class Form1
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.textBoxYearsRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrincipal = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.textBoxInterest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelInterest = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("華康魏碑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExit.Location = new System.Drawing.Point(386, 228);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(54, 30);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Font = new System.Drawing.Font("華康魏碑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCalculator.Location = new System.Drawing.Point(386, 173);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(54, 30);
            this.buttonCalculator.TabIndex = 11;
            this.buttonCalculator.Text = "計算";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxResult);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(456, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 455);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "輸出結果";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(29, 51);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(280, 368);
            this.textBoxResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康隸書體W3", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "您的貸款訊息如下：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelPrincipal);
            this.groupBox1.Controls.Add(this.textBoxYearsRate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPrincipal);
            this.groupBox1.Controls.Add(this.labelRate);
            this.groupBox1.Controls.Add(this.textBoxInterest);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelInterest);
            this.groupBox1.Location = new System.Drawing.Point(29, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 455);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸入訊息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("華康魏碑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(303, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "年";
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Font = new System.Drawing.Font("華康魏碑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPrincipal.Location = new System.Drawing.Point(9, 45);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(106, 24);
            this.labelPrincipal.TabIndex = 0;
            this.labelPrincipal.Text = "本  金：";
            // 
            // textBoxYearsRate
            // 
            this.textBoxYearsRate.Location = new System.Drawing.Point(150, 220);
            this.textBoxYearsRate.Multiline = true;
            this.textBoxYearsRate.Name = "textBoxYearsRate";
            this.textBoxYearsRate.Size = new System.Drawing.Size(135, 24);
            this.textBoxYearsRate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("華康魏碑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(303, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "%";
            // 
            // textBoxPrincipal
            // 
            this.textBoxPrincipal.Location = new System.Drawing.Point(150, 45);
            this.textBoxPrincipal.Multiline = true;
            this.textBoxPrincipal.Name = "textBoxPrincipal";
            this.textBoxPrincipal.Size = new System.Drawing.Size(135, 24);
            this.textBoxPrincipal.TabIndex = 4;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("華康魏碑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRate.Location = new System.Drawing.Point(9, 220);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(106, 24);
            this.labelRate.TabIndex = 1;
            this.labelRate.Text = "年利率：";
            // 
            // textBoxInterest
            // 
            this.textBoxInterest.Location = new System.Drawing.Point(150, 395);
            this.textBoxInterest.Multiline = true;
            this.textBoxInterest.Name = "textBoxInterest";
            this.textBoxInterest.Size = new System.Drawing.Size(135, 24);
            this.textBoxInterest.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("華康魏碑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(303, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "元";
            // 
            // labelInterest
            // 
            this.labelInterest.AutoSize = true;
            this.labelInterest.Font = new System.Drawing.Font("華康魏碑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelInterest.Location = new System.Drawing.Point(9, 395);
            this.labelInterest.Name = "labelInterest";
            this.labelInterest.Size = new System.Drawing.Size(106, 24);
            this.labelInterest.TabIndex = 2;
            this.labelInterest.Text = "年  限：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 511);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "貸款計算器";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.TextBox textBoxYearsRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrincipal;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.TextBox textBoxInterest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelInterest;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

