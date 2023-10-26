namespace labMoveBox
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.hpbar = new System.Windows.Forms.ProgressBar();
            this.hp_text = new System.Windows.Forms.Label();
            this.timer_hp = new System.Windows.Forms.Timer(this.components);
            this.yd = new System.Windows.Forms.Label();
            this.timer_heal = new System.Windows.Forms.Timer(this.components);
            this.heal = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // hpbar
            // 
            this.hpbar.Location = new System.Drawing.Point(12, 12);
            this.hpbar.Name = "hpbar";
            this.hpbar.Size = new System.Drawing.Size(172, 23);
            this.hpbar.TabIndex = 3;
            // 
            // hp_text
            // 
            this.hp_text.AutoSize = true;
            this.hp_text.Location = new System.Drawing.Point(92, 12);
            this.hp_text.Name = "hp_text";
            this.hp_text.Size = new System.Drawing.Size(22, 13);
            this.hp_text.TabIndex = 4;
            this.hp_text.Text = "HP";
            // 
            // timer_hp
            // 
            this.timer_hp.Enabled = true;
            this.timer_hp.Interval = 200;
            this.timer_hp.Tick += new System.EventHandler(this.timer_hp_Tick);
            // 
            // yd
            // 
            this.yd.AutoSize = true;
            this.yd.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yd.ForeColor = System.Drawing.Color.Red;
            this.yd.Location = new System.Drawing.Point(266, 191);
            this.yd.Name = "yd";
            this.yd.Size = new System.Drawing.Size(287, 63);
            this.yd.TabIndex = 5;
            this.yd.Text = "YOU DIED";
            this.yd.Visible = false;
            // 
            // timer_heal
            // 
            this.timer_heal.Enabled = true;
            this.timer_heal.Interval = 4000;
            this.timer_heal.Tick += new System.EventHandler(this.timer_heal_Tick);
            // 
            // heal
            // 
            this.heal.Image = global::labMoveBox.Properties.Resources.healthpack01;
            this.heal.Location = new System.Drawing.Point(675, 201);
            this.heal.Name = "heal";
            this.heal.Size = new System.Drawing.Size(41, 53);
            this.heal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heal.TabIndex = 6;
            this.heal.TabStop = false;
            this.heal.Visible = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::labMoveBox.Properties.Resources.ped_2;
            this.pb2.Location = new System.Drawing.Point(23, 191);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(91, 98);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::labMoveBox.Properties.Resources.ped;
            this.pb1.Location = new System.Drawing.Point(685, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(91, 98);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // pic
            // 
            this.pic.Image = global::labMoveBox.Properties.Resources.lol2;
            this.pic.Location = new System.Drawing.Point(319, 73);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(79, 99);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.heal);
            this.Controls.Add(this.yd);
            this.Controls.Add(this.hp_text);
            this.Controls.Add(this.hpbar);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.heal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar hpbar;
        private System.Windows.Forms.Label hp_text;
        private System.Windows.Forms.Timer timer_hp;
        private System.Windows.Forms.Label yd;
        private System.Windows.Forms.Timer timer_heal;
        private System.Windows.Forms.PictureBox heal;
    }
}

