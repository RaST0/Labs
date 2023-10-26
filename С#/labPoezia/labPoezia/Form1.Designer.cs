namespace labPoezia
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.zin = new System.Windows.Forms.ToolStripButton();
            this.zout = new System.Windows.Forms.ToolStripButton();
            this.about = new System.Windows.Forms.ToolStripButton();
            this.tc = new System.Windows.Forms.TabControl();
            this.FullText = new System.Windows.Forms.TabPage();
            this.ThroughLine = new System.Windows.Forms.TabPage();
            this.FirstWords = new System.Windows.Forms.TabPage();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tc.SuspendLayout();
            this.FullText.SuspendLayout();
            this.ThroughLine.SuspendLayout();
            this.FirstWords.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zin,
            this.zout,
            this.about});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // zin
            // 
            this.zin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zin.Image = ((System.Drawing.Image)(resources.GetObject("zin.Image")));
            this.zin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zin.Name = "zin";
            this.zin.Size = new System.Drawing.Size(58, 22);
            this.zin.Text = "Zoom IN";
            // 
            // zout
            // 
            this.zout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zout.Image = ((System.Drawing.Image)(resources.GetObject("zout.Image")));
            this.zout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zout.Name = "zout";
            this.zout.Size = new System.Drawing.Size(70, 22);
            this.zout.Text = "Zoom OUT";
            // 
            // about
            // 
            this.about.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(44, 22);
            this.about.Text = "About";
            // 
            // tc
            // 
            this.tc.Controls.Add(this.FullText);
            this.tc.Controls.Add(this.ThroughLine);
            this.tc.Controls.Add(this.FirstWords);
            this.tc.Controls.Add(this.tabPage1);
            this.tc.Controls.Add(this.tabPage2);
            this.tc.Controls.Add(this.tabPage3);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 25);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(800, 425);
            this.tc.TabIndex = 1;
            // 
            // FullText
            // 
            this.FullText.Controls.Add(this.tb1);
            this.FullText.Location = new System.Drawing.Point(4, 22);
            this.FullText.Name = "FullText";
            this.FullText.Padding = new System.Windows.Forms.Padding(3);
            this.FullText.Size = new System.Drawing.Size(792, 399);
            this.FullText.TabIndex = 0;
            this.FullText.Text = "Полностью";
            this.FullText.UseVisualStyleBackColor = true;
            // 
            // ThroughLine
            // 
            this.ThroughLine.Controls.Add(this.tb2);
            this.ThroughLine.Location = new System.Drawing.Point(4, 22);
            this.ThroughLine.Name = "ThroughLine";
            this.ThroughLine.Padding = new System.Windows.Forms.Padding(3);
            this.ThroughLine.Size = new System.Drawing.Size(792, 399);
            this.ThroughLine.TabIndex = 1;
            this.ThroughLine.Text = "Через строчку";
            this.ThroughLine.UseVisualStyleBackColor = true;
            // 
            // FirstWords
            // 
            this.FirstWords.Controls.Add(this.tb3);
            this.FirstWords.Location = new System.Drawing.Point(4, 22);
            this.FirstWords.Name = "FirstWords";
            this.FirstWords.Padding = new System.Windows.Forms.Padding(3);
            this.FirstWords.Size = new System.Drawing.Size(792, 399);
            this.FirstWords.TabIndex = 2;
            this.FirstWords.Text = "Первое слово";
            this.FirstWords.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            this.tb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb1.Location = new System.Drawing.Point(3, 3);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb1.Size = new System.Drawing.Size(786, 393);
            this.tb1.TabIndex = 0;
            this.tb1.Text = resources.GetString("tb1.Text");
            // 
            // tb2
            // 
            this.tb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb2.Location = new System.Drawing.Point(3, 3);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb2.Size = new System.Drawing.Size(786, 393);
            this.tb2.TabIndex = 1;
            // 
            // tb3
            // 
            this.tb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb3.Location = new System.Drawing.Point(3, 3);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb3.Size = new System.Drawing.Size(786, 393);
            this.tb3.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 399);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "2 & 3  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb4
            // 
            this.tb4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb4.Location = new System.Drawing.Point(3, 3);
            this.tb4.Multiline = true;
            this.tb4.Name = "tb4";
            this.tb4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb4.Size = new System.Drawing.Size(786, 393);
            this.tb4.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 399);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "через слово";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb5
            // 
            this.tb5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb5.Location = new System.Drawing.Point(3, 3);
            this.tb5.Multiline = true;
            this.tb5.Name = "tb5";
            this.tb5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb5.Size = new System.Drawing.Size(786, 393);
            this.tb5.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 399);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "перевенуть";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb6
            // 
            this.tb6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb6.Location = new System.Drawing.Point(3, 3);
            this.tb6.Multiline = true;
            this.tb6.Name = "tb6";
            this.tb6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb6.Size = new System.Drawing.Size(786, 393);
            this.tb6.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tc.ResumeLayout(false);
            this.FullText.ResumeLayout(false);
            this.FullText.PerformLayout();
            this.ThroughLine.ResumeLayout(false);
            this.ThroughLine.PerformLayout();
            this.FirstWords.ResumeLayout(false);
            this.FirstWords.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton zin;
        private System.Windows.Forms.ToolStripButton zout;
        private System.Windows.Forms.ToolStripButton about;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage FullText;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TabPage ThroughLine;
        private System.Windows.Forms.TabPage FirstWords;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb6;
    }
}

