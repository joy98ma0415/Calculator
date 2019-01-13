namespace InterestCalculate
{
    partial class Daily
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.AnnuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quarterlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semiAnnuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("華康魏碑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExit.Location = new System.Drawing.Point(374, 238);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(54, 30);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Visible = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Font = new System.Drawing.Font("華康魏碑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCalculator.Location = new System.Drawing.Point(374, 183);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(54, 30);
            this.buttonCalculator.TabIndex = 17;
            this.buttonCalculator.Text = "計算";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelResult);
            this.groupBox2.Location = new System.Drawing.Point(444, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 344);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "輸出結果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康隸書體W3", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "您的存款訊息如下：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("華康隸書體W3", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelResult.Location = new System.Drawing.Point(23, 75);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 19);
            this.labelResult.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(18, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 344);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸入訊息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("華康魏碑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(303, 170);
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
            this.textBoxYearsRate.Location = new System.Drawing.Point(150, 163);
            this.textBoxYearsRate.Multiline = true;
            this.textBoxYearsRate.Name = "textBoxYearsRate";
            this.textBoxYearsRate.Size = new System.Drawing.Size(135, 24);
            this.textBoxYearsRate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("華康魏碑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(303, 287);
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
            this.labelRate.Location = new System.Drawing.Point(9, 163);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(106, 24);
            this.labelRate.TabIndex = 1;
            this.labelRate.Text = "年利率：";
            // 
            // textBoxInterest
            // 
            this.textBoxInterest.Location = new System.Drawing.Point(150, 281);
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
            this.labelInterest.Location = new System.Drawing.Point(9, 281);
            this.labelInterest.Name = "labelInterest";
            this.labelInterest.Size = new System.Drawing.Size(106, 24);
            this.labelInterest.TabIndex = 2;
            this.labelInterest.Text = "利  息：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSeparator1,
            this.關於ToolStripMenuItem,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnnuallyToolStripMenuItem,
            this.dailyToolStripMenuItem,
            this.monthlyToolStripMenuItem,
            this.quarterlyToolStripMenuItem,
            this.semiAnnuallyToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(71, 22);
            this.toolStripSplitButton1.Text = "利息計算";
            // 
            // AnnuallyToolStripMenuItem
            // 
            this.AnnuallyToolStripMenuItem.Name = "AnnuallyToolStripMenuItem";
            this.AnnuallyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.AnnuallyToolStripMenuItem.Text = "Annually";
            this.AnnuallyToolStripMenuItem.Click += new System.EventHandler(this.AnnuallyToolStripMenuItem_Click);
            // 
            // dailyToolStripMenuItem
            // 
            this.dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            this.dailyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dailyToolStripMenuItem.Text = "Daily";
            this.dailyToolStripMenuItem.Click += new System.EventHandler(this.dailyToolStripMenuItem_Click);
            // 
            // monthlyToolStripMenuItem
            // 
            this.monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            this.monthlyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.monthlyToolStripMenuItem.Text = "Monthly";
            this.monthlyToolStripMenuItem.Click += new System.EventHandler(this.monthlyToolStripMenuItem_Click);
            // 
            // quarterlyToolStripMenuItem
            // 
            this.quarterlyToolStripMenuItem.Name = "quarterlyToolStripMenuItem";
            this.quarterlyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.quarterlyToolStripMenuItem.Text = "Quarterly";
            this.quarterlyToolStripMenuItem.Click += new System.EventHandler(this.quarterlyToolStripMenuItem_Click);
            // 
            // semiAnnuallyToolStripMenuItem
            // 
            this.semiAnnuallyToolStripMenuItem.Name = "semiAnnuallyToolStripMenuItem";
            this.semiAnnuallyToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.semiAnnuallyToolStripMenuItem.Text = "SemiAnnually";
            this.semiAnnuallyToolStripMenuItem.Click += new System.EventHandler(this.semiAnnuallyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.關於ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.關於ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("關於ToolStripMenuItem.Image")));
            this.關於ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.關於ToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "關於";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Daily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Daily";
            this.Text = "Daily";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem AnnuallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quarterlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semiAnnuallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}