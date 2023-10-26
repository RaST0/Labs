namespace labCalc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laResult = new System.Windows.Forms.Label();
            this.buADD = new System.Windows.Forms.Button();
            this.buMinus = new System.Windows.Forms.Button();
            this.buDelit = new System.Windows.Forms.Button();
            this.buUmnog = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.buClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(73, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(73, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "A =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "B =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат:";
            // 
            // laResult
            // 
            this.laResult.AutoSize = true;
            this.laResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laResult.Location = new System.Drawing.Point(169, 193);
            this.laResult.Name = "laResult";
            this.laResult.Size = new System.Drawing.Size(100, 31);
            this.laResult.TabIndex = 5;
            this.laResult.Text = "(ответ)";
            // 
            // buADD
            // 
            this.buADD.BackColor = System.Drawing.Color.Red;
            this.buADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buADD.Location = new System.Drawing.Point(18, 150);
            this.buADD.Name = "buADD";
            this.buADD.Size = new System.Drawing.Size(40, 40);
            this.buADD.TabIndex = 6;
            this.buADD.Text = "+";
            this.buADD.UseVisualStyleBackColor = false;
            this.buADD.Click += new System.EventHandler(this.buADD_Click);
            // 
            // buMinus
            // 
            this.buMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buMinus.Location = new System.Drawing.Point(64, 150);
            this.buMinus.Name = "buMinus";
            this.buMinus.Size = new System.Drawing.Size(40, 40);
            this.buMinus.TabIndex = 7;
            this.buMinus.Text = "-";
            this.buMinus.UseVisualStyleBackColor = false;
            this.buMinus.Click += new System.EventHandler(this.buMinus_Click);
            // 
            // buDelit
            // 
            this.buDelit.BackColor = System.Drawing.Color.Lime;
            this.buDelit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buDelit.Location = new System.Drawing.Point(110, 150);
            this.buDelit.Name = "buDelit";
            this.buDelit.Size = new System.Drawing.Size(40, 40);
            this.buDelit.TabIndex = 8;
            this.buDelit.Text = "/";
            this.buDelit.UseVisualStyleBackColor = false;
            this.buDelit.Click += new System.EventHandler(this.buDelit_Click);
            // 
            // buUmnog
            // 
            this.buUmnog.BackColor = System.Drawing.Color.Blue;
            this.buUmnog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buUmnog.Location = new System.Drawing.Point(156, 150);
            this.buUmnog.Name = "buUmnog";
            this.buUmnog.Size = new System.Drawing.Size(40, 40);
            this.buUmnog.TabIndex = 9;
            this.buUmnog.Text = "*";
            this.buUmnog.UseVisualStyleBackColor = false;
            this.buUmnog.Click += new System.EventHandler(this.buUmnog_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(275, 42);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(216, 245);
            this.tbLog.TabIndex = 10;
            // 
            // buClear
            // 
            this.buClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buClear.Location = new System.Drawing.Point(194, 42);
            this.buClear.Name = "buClear";
            this.buClear.Size = new System.Drawing.Size(75, 23);
            this.buClear.TabIndex = 11;
            this.buClear.Text = "Очистить";
            this.buClear.UseVisualStyleBackColor = false;
            this.buClear.Click += new System.EventHandler(this.buClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(278, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "История";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(503, 332);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buClear);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.buUmnog);
            this.Controls.Add(this.buDelit);
            this.Controls.Add(this.buMinus);
            this.Controls.Add(this.buADD);
            this.Controls.Add(this.laResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(335, 363);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laResult;
        private System.Windows.Forms.Button buADD;
        private System.Windows.Forms.Button buMinus;
        private System.Windows.Forms.Button buDelit;
        private System.Windows.Forms.Button buUmnog;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button buClear;
        private System.Windows.Forms.Label label4;
    }
}

