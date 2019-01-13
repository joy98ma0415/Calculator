namespace InterestCalculate
{
    partial class InterestMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterestMainForm));
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
            this.label1 = new System.Windows.Forms.Label();
            this.回專案主畫面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(484, 25);
            this.toolStrip1.TabIndex = 0;
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
            this.toolStripMenuItem1,
            this.回專案主畫面ToolStripMenuItem});
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("華康魏碑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(118, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "利息計算器主畫面";
            // 
            // 回專案主畫面ToolStripMenuItem
            // 
            this.回專案主畫面ToolStripMenuItem.Name = "回專案主畫面ToolStripMenuItem";
            this.回專案主畫面ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.回專案主畫面ToolStripMenuItem.Text = "回專案主畫面";
            this.回專案主畫面ToolStripMenuItem.Click += new System.EventHandler(this.回專案主畫面ToolStripMenuItem_Click);
            // 
            // InterestMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "InterestMainForm";
            this.Text = "利息計算器主畫面";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem AnnuallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quarterlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semiAnnuallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 回專案主畫面ToolStripMenuItem;
    }
}

