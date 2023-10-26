namespace labRememberNumber
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ltrue = new System.Windows.Forms.Label();
            this.lfalse = new System.Windows.Forms.Label();
            this.lza = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.numb = new System.Windows.Forms.Label();
            this.lvv = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.bready = new System.Windows.Forms.Button();
            this.level = new System.Windows.Forms.Label();
            this.tick = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ltrue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lfalse, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ltrue
            // 
            this.ltrue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ltrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltrue.Location = new System.Drawing.Point(3, 0);
            this.ltrue.Name = "ltrue";
            this.ltrue.Size = new System.Drawing.Size(159, 52);
            this.ltrue.TabIndex = 0;
            this.ltrue.Text = "True = ";
            this.ltrue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lfalse
            // 
            this.lfalse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lfalse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lfalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lfalse.Location = new System.Drawing.Point(168, 0);
            this.lfalse.Name = "lfalse";
            this.lfalse.Size = new System.Drawing.Size(160, 52);
            this.lfalse.TabIndex = 1;
            this.lfalse.Text = "False = ";
            this.lfalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lza
            // 
            this.lza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lza.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lza.Location = new System.Drawing.Point(12, 64);
            this.lza.Name = "lza";
            this.lza.Size = new System.Drawing.Size(331, 26);
            this.lza.TabIndex = 1;
            this.lza.Text = "Запомни число";
            this.lza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.numb);
            this.panel.Location = new System.Drawing.Point(12, 117);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(331, 120);
            this.panel.TabIndex = 2;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // numb
            // 
            this.numb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numb.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numb.Location = new System.Drawing.Point(0, 23);
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(329, 95);
            this.numb.TabIndex = 0;
            this.numb.Text = "000000";
            this.numb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvv
            // 
            this.lvv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvv.Location = new System.Drawing.Point(12, 249);
            this.lvv.Name = "lvv";
            this.lvv.Size = new System.Drawing.Size(331, 26);
            this.lvv.TabIndex = 3;
            this.lvv.Text = "Введите число";
            this.lvv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb.Location = new System.Drawing.Point(12, 288);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(331, 29);
            this.tb.TabIndex = 4;
            this.tb.Text = "000000";
            this.tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bready
            // 
            this.bready.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bready.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bready.Location = new System.Drawing.Point(12, 324);
            this.bready.Name = "bready";
            this.bready.Size = new System.Drawing.Size(331, 55);
            this.bready.TabIndex = 5;
            this.bready.Text = "Готово";
            this.bready.UseVisualStyleBackColor = true;
            this.bready.Click += new System.EventHandler(this.bready_Click);
            // 
            // level
            // 
            this.level.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.level.Location = new System.Drawing.Point(8, 91);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(172, 23);
            this.level.TabIndex = 1;
            this.level.Text = "Level = ";
            this.level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tick
            // 
            this.tick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tick.Location = new System.Drawing.Point(171, 91);
            this.tick.Name = "tick";
            this.tick.Size = new System.Drawing.Size(172, 23);
            this.tick.TabIndex = 6;
            this.tick.Text = "tick = ";
            this.tick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 391);
            this.Controls.Add(this.tick);
            this.Controls.Add(this.level);
            this.Controls.Add(this.bready);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lvv);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lza);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(300, 430);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lfalse;
        private System.Windows.Forms.Label ltrue;
        private System.Windows.Forms.Label lza;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label numb;
        private System.Windows.Forms.Label lvv;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button bready;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label tick;
    }
}

