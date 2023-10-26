namespace labTimer
{
    partial class Fm1
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
            this.components = new System.ComponentModel.Container();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.pic_des = new System.Windows.Forms.PictureBox();
            this.pic_sao = new System.Windows.Forms.PictureBox();
            this.pic_tg = new System.Windows.Forms.PictureBox();
            this.lcount = new System.Windows.Forms.Label();
            this.lfalse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_des)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tg)).BeginInit();
            this.SuspendLayout();
            // 
            // tm
            // 
            this.tm.Enabled = true;
            this.tm.Interval = 10;
            // 
            // pic_des
            // 
            this.pic_des.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_des.Image = global::labTimer.Properties.Resources.destiny;
            this.pic_des.Location = new System.Drawing.Point(260, 12);
            this.pic_des.Name = "pic_des";
            this.pic_des.Size = new System.Drawing.Size(118, 95);
            this.pic_des.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_des.TabIndex = 2;
            this.pic_des.TabStop = false;
            this.pic_des.Tag = "3";
            this.pic_des.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_sao
            // 
            this.pic_sao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_sao.Image = global::labTimer.Properties.Resources.sao;
            this.pic_sao.Location = new System.Drawing.Point(136, 12);
            this.pic_sao.Name = "pic_sao";
            this.pic_sao.Size = new System.Drawing.Size(118, 95);
            this.pic_sao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_sao.TabIndex = 1;
            this.pic_sao.TabStop = false;
            this.pic_sao.Tag = "2";
            this.pic_sao.Click += new System.EventHandler(this.pic_Click);
            // 
            // pic_tg
            // 
            this.pic_tg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_tg.Image = global::labTimer.Properties.Resources.tg;
            this.pic_tg.Location = new System.Drawing.Point(12, 12);
            this.pic_tg.Name = "pic_tg";
            this.pic_tg.Size = new System.Drawing.Size(118, 95);
            this.pic_tg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_tg.TabIndex = 0;
            this.pic_tg.TabStop = false;
            this.pic_tg.Tag = "1";
            this.pic_tg.Click += new System.EventHandler(this.pic_Click);
            // 
            // lcount
            // 
            this.lcount.AutoSize = true;
            this.lcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcount.Location = new System.Drawing.Point(714, 12);
            this.lcount.Name = "lcount";
            this.lcount.Size = new System.Drawing.Size(26, 26);
            this.lcount.TabIndex = 3;
            this.lcount.Text = "--";
            // 
            // lfalse
            // 
            this.lfalse.AutoSize = true;
            this.lfalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lfalse.Location = new System.Drawing.Point(714, 58);
            this.lfalse.Name = "lfalse";
            this.lfalse.Size = new System.Drawing.Size(26, 26);
            this.lfalse.TabIndex = 4;
            this.lfalse.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "попадания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "промахи";
            // 
            // Fm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lfalse);
            this.Controls.Add(this.lcount);
            this.Controls.Add(this.pic_des);
            this.Controls.Add(this.pic_sao);
            this.Controls.Add(this.pic_tg);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Fm1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_des)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_tg;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.PictureBox pic_sao;
        private System.Windows.Forms.PictureBox pic_des;
        private System.Windows.Forms.Label lcount;
        private System.Windows.Forms.Label lfalse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

