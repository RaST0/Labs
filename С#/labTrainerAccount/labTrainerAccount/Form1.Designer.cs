namespace labTrainerAccount
{
    partial class fm
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
            this.laTrue = new System.Windows.Forms.Label();
            this.laFalse = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butYes = new System.Windows.Forms.Button();
            this.butNo = new System.Windows.Forms.Button();
            this.laQuestion = new System.Windows.Forms.Label();
            this.laVerno = new System.Windows.Forms.Label();
            this.laAutor = new System.Windows.Forms.Label();
            this.butRes = new System.Windows.Forms.Button();
            this.lvl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.laTrue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.laFalse, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // laTrue
            // 
            this.laTrue.AutoSize = true;
            this.laTrue.BackColor = System.Drawing.Color.LawnGreen;
            this.laTrue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laTrue.Location = new System.Drawing.Point(3, 0);
            this.laTrue.Name = "laTrue";
            this.laTrue.Size = new System.Drawing.Size(149, 62);
            this.laTrue.TabIndex = 0;
            this.laTrue.Text = "Верно = 00";
            this.laTrue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laFalse
            // 
            this.laFalse.AutoSize = true;
            this.laFalse.BackColor = System.Drawing.Color.Pink;
            this.laFalse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laFalse.Location = new System.Drawing.Point(158, 0);
            this.laFalse.Name = "laFalse";
            this.laFalse.Size = new System.Drawing.Size(149, 62);
            this.laFalse.TabIndex = 1;
            this.laFalse.Text = "Неверно = 00";
            this.laFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.butYes, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.butNo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 300);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 76);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // butYes
            // 
            this.butYes.BackColor = System.Drawing.Color.Lime;
            this.butYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butYes.ForeColor = System.Drawing.Color.Red;
            this.butYes.Location = new System.Drawing.Point(3, 3);
            this.butYes.Name = "butYes";
            this.butYes.Size = new System.Drawing.Size(147, 70);
            this.butYes.TabIndex = 0;
            this.butYes.Text = "Да";
            this.butYes.UseVisualStyleBackColor = false;
            this.butYes.Click += new System.EventHandler(this.butYes_Click);
            // 
            // butNo
            // 
            this.butNo.BackColor = System.Drawing.Color.GreenYellow;
            this.butNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butNo.ForeColor = System.Drawing.Color.Red;
            this.butNo.Location = new System.Drawing.Point(156, 3);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(148, 70);
            this.butNo.TabIndex = 1;
            this.butNo.Text = "Нет";
            this.butNo.UseVisualStyleBackColor = false;
            this.butNo.Click += new System.EventHandler(this.butNo_Click);
            // 
            // laQuestion
            // 
            this.laQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laQuestion.Location = new System.Drawing.Point(12, 77);
            this.laQuestion.Name = "laQuestion";
            this.laQuestion.Size = new System.Drawing.Size(310, 177);
            this.laQuestion.TabIndex = 2;
            this.laQuestion.Text = "10+10=20";
            this.laQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laQuestion.Click += new System.EventHandler(this.laQuestion_Click);
            // 
            // laVerno
            // 
            this.laVerno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laVerno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laVerno.Location = new System.Drawing.Point(12, 266);
            this.laVerno.Name = "laVerno";
            this.laVerno.Size = new System.Drawing.Size(307, 31);
            this.laVerno.TabIndex = 3;
            this.laVerno.Text = "Верно?";
            this.laVerno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laAutor
            // 
            this.laAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.laAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laAutor.Location = new System.Drawing.Point(185, 376);
            this.laAutor.Name = "laAutor";
            this.laAutor.Size = new System.Drawing.Size(137, 23);
            this.laAutor.TabIndex = 4;
            this.laAutor.Text = "Demidov Y";
            this.laAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laAutor.Click += new System.EventHandler(this.laAutor_Click);
            // 
            // butRes
            // 
            this.butRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butRes.BackColor = System.Drawing.Color.Khaki;
            this.butRes.Location = new System.Drawing.Point(13, 376);
            this.butRes.Name = "butRes";
            this.butRes.Size = new System.Drawing.Size(75, 23);
            this.butRes.TabIndex = 5;
            this.butRes.Text = "Сбросить";
            this.butRes.UseVisualStyleBackColor = false;
            this.butRes.Click += new System.EventHandler(this.butRes_Click);
            // 
            // lvl
            // 
            this.lvl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl.Location = new System.Drawing.Point(48, 98);
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(235, 31);
            this.lvl.TabIndex = 6;
            this.lvl.Text = "Уровень:  Х";
            this.lvl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(334, 401);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.butRes);
            this.Controls.Add(this.laAutor);
            this.Controls.Add(this.laVerno);
            this.Controls.Add(this.laQuestion);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(350, 440);
            this.Name = "fm";
            this.Text = "labTrainer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label laTrue;
        private System.Windows.Forms.Label laFalse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button butYes;
        private System.Windows.Forms.Button butNo;
        private System.Windows.Forms.Label laQuestion;
        private System.Windows.Forms.Label laVerno;
        private System.Windows.Forms.Label laAutor;
        private System.Windows.Forms.Button butRes;
        private System.Windows.Forms.Label lvl;
    }
}

