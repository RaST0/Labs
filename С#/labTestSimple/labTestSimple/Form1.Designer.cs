namespace labTestSimple
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
            this.tc = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buStart = new System.Windows.Forms.Button();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.tp5 = new System.Windows.Forms.TabPage();
            this.cfalse = new System.Windows.Forms.Label();
            this.ctrue = new System.Windows.Forms.Label();
            this.buEnd = new System.Windows.Forms.Button();
            this.pic_true = new System.Windows.Forms.Label();
            this.pic_false = new System.Windows.Forms.Label();
            this.la_end_3 = new System.Windows.Forms.Label();
            this.la_end_2 = new System.Windows.Forms.Label();
            this.la_end_1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progbar = new System.Windows.Forms.ProgressBar();
            this.tc.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tp5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tc.Controls.Add(this.tp1);
            this.tc.Controls.Add(this.tp2);
            this.tc.Controls.Add(this.tabPage3);
            this.tc.Controls.Add(this.tabPage4);
            this.tc.Controls.Add(this.tp5);
            this.tc.HotTrack = true;
            this.tc.ItemSize = new System.Drawing.Size(0, 1);
            this.tc.Location = new System.Drawing.Point(3, 45);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(797, 403);
            this.tc.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc.TabIndex = 0;
            this.tc.TabStop = false;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.label6);
            this.tp1.Controls.Add(this.label3);
            this.tp1.Controls.Add(this.buStart);
            this.tp1.Location = new System.Drawing.Point(4, 5);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(789, 394);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "menu";
            this.tp1.UseVisualStyleBackColor = true;
            this.tp1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(0, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 223);
            this.label6.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // buStart
            // 
            this.buStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buStart.Location = new System.Drawing.Point(3, 338);
            this.buStart.Name = "buStart";
            this.buStart.Size = new System.Drawing.Size(777, 50);
            this.buStart.TabIndex = 2;
            this.buStart.Text = "Начать тест";
            this.buStart.UseVisualStyleBackColor = false;
            this.buStart.Click += new System.EventHandler(this.buStart_Click);
            // 
            // tp2
            // 
            this.tp2.AutoScroll = true;
            this.tp2.Controls.Add(this.button6);
            this.tp2.Controls.Add(this.button5);
            this.tp2.Controls.Add(this.button4);
            this.tp2.Controls.Add(this.button3);
            this.tp2.Controls.Add(this.label2);
            this.tp2.Controls.Add(this.button2);
            this.tp2.Location = new System.Drawing.Point(4, 5);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(789, 394);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "1";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(8, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(773, 53);
            this.button6.TabIndex = 5;
            this.button6.Tag = "";
            this.button6.Text = "oh my god";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buAll_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(8, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(773, 53);
            this.button5.TabIndex = 4;
            this.button5.Tag = "1";
            this.button5.Text = "da";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buAll_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(8, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(773, 53);
            this.button4.TabIndex = 3;
            this.button4.Tag = "";
            this.button4.Text = "daga kotoaru";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buAll_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(8, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(773, 53);
            this.button3.TabIndex = 2;
            this.button3.Tag = "";
            this.button3.Text = "daze";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "kono Dio ?";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(8, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(773, 53);
            this.button2.TabIndex = 0;
            this.button2.Tag = "";
            this.button2.Text = "yare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buAll_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(8, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(773, 53);
            this.button1.TabIndex = 11;
            this.button1.Tag = "";
            this.button1.Text = "oh my god";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buAll_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(8, 181);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(773, 53);
            this.button7.TabIndex = 10;
            this.button7.Tag = "";
            this.button7.Text = "da";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buAll_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(8, 131);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(773, 53);
            this.button8.TabIndex = 9;
            this.button8.Tag = "";
            this.button8.Text = "daga kotoaru";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buAll_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(8, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(773, 53);
            this.button9.TabIndex = 8;
            this.button9.Tag = "1";
            this.button9.Text = "daze";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "yare yare ?";
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(8, 32);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(773, 53);
            this.button10.TabIndex = 6;
            this.button10.Tag = "";
            this.button10.Text = "yare";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buAll_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.button12);
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.button14);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.button15);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(789, 394);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(6, 231);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(773, 53);
            this.button11.TabIndex = 11;
            this.button11.Tag = "1";
            this.button11.Text = "WARUDO";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buAll_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(6, 181);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(773, 53);
            this.button12.TabIndex = 10;
            this.button12.Tag = "";
            this.button12.Text = "da";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buAll_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(6, 132);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(773, 53);
            this.button13.TabIndex = 9;
            this.button13.Tag = "";
            this.button13.Text = "daga kotoaru";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buAll_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(6, 82);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(773, 53);
            this.button14.TabIndex = 8;
            this.button14.Tag = "";
            this.button14.Text = "daze";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.buAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "ZA ?";
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(6, 32);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(773, 53);
            this.button15.TabIndex = 6;
            this.button15.Tag = "";
            this.button15.Text = "yare";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.buAll_Click);
            // 
            // tp5
            // 
            this.tp5.Controls.Add(this.cfalse);
            this.tp5.Controls.Add(this.ctrue);
            this.tp5.Controls.Add(this.buEnd);
            this.tp5.Controls.Add(this.pic_true);
            this.tp5.Controls.Add(this.pic_false);
            this.tp5.Controls.Add(this.la_end_3);
            this.tp5.Controls.Add(this.la_end_2);
            this.tp5.Controls.Add(this.la_end_1);
            this.tp5.Location = new System.Drawing.Point(4, 5);
            this.tp5.Name = "tp5";
            this.tp5.Padding = new System.Windows.Forms.Padding(3);
            this.tp5.Size = new System.Drawing.Size(789, 394);
            this.tp5.TabIndex = 4;
            this.tp5.Text = "end";
            this.tp5.UseVisualStyleBackColor = true;
            // 
            // cfalse
            // 
            this.cfalse.AutoSize = true;
            this.cfalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cfalse.Location = new System.Drawing.Point(403, 63);
            this.cfalse.Name = "cfalse";
            this.cfalse.Size = new System.Drawing.Size(16, 24);
            this.cfalse.TabIndex = 7;
            this.cfalse.Text = "-";
            // 
            // ctrue
            // 
            this.ctrue.AutoSize = true;
            this.ctrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctrue.Location = new System.Drawing.Point(400, 26);
            this.ctrue.Name = "ctrue";
            this.ctrue.Size = new System.Drawing.Size(16, 24);
            this.ctrue.TabIndex = 6;
            this.ctrue.Text = "-";
            // 
            // buEnd
            // 
            this.buEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buEnd.Location = new System.Drawing.Point(4, 338);
            this.buEnd.Name = "buEnd";
            this.buEnd.Size = new System.Drawing.Size(777, 50);
            this.buEnd.TabIndex = 5;
            this.buEnd.Text = "Начать заново";
            this.buEnd.UseVisualStyleBackColor = false;
            this.buEnd.Click += new System.EventHandler(this.buEnd_Click);
            // 
            // pic_true
            // 
            this.pic_true.Image = ((System.Drawing.Image)(resources.GetObject("pic_true.Image")));
            this.pic_true.Location = new System.Drawing.Point(6, 106);
            this.pic_true.Name = "pic_true";
            this.pic_true.Size = new System.Drawing.Size(234, 185);
            this.pic_true.TabIndex = 4;
            this.pic_true.Visible = false;
            // 
            // pic_false
            // 
            this.pic_false.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_false.Image = ((System.Drawing.Image)(resources.GetObject("pic_false.Image")));
            this.pic_false.Location = new System.Drawing.Point(547, 106);
            this.pic_false.Name = "pic_false";
            this.pic_false.Size = new System.Drawing.Size(234, 185);
            this.pic_false.TabIndex = 3;
            this.pic_false.Visible = false;
            // 
            // la_end_3
            // 
            this.la_end_3.AutoSize = true;
            this.la_end_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_end_3.Location = new System.Drawing.Point(3, 63);
            this.la_end_3.Name = "la_end_3";
            this.la_end_3.Size = new System.Drawing.Size(132, 26);
            this.la_end_3.TabIndex = 2;
            this.la_end_3.Text = "3й вопрос - ";
            // 
            // la_end_2
            // 
            this.la_end_2.AutoSize = true;
            this.la_end_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_end_2.Location = new System.Drawing.Point(3, 38);
            this.la_end_2.Name = "la_end_2";
            this.la_end_2.Size = new System.Drawing.Size(132, 26);
            this.la_end_2.TabIndex = 1;
            this.la_end_2.Text = "2й вопрос - ";
            // 
            // la_end_1
            // 
            this.la_end_1.AutoSize = true;
            this.la_end_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.la_end_1.Location = new System.Drawing.Point(3, 14);
            this.la_end_1.Name = "la_end_1";
            this.la_end_1.Size = new System.Drawing.Size(132, 26);
            this.la_end_1.TabIndex = 0;
            this.la_end_1.Text = "1й вопрос - ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 38);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(337, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мой тест";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progbar
            // 
            this.progbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progbar.Location = new System.Drawing.Point(3, 31);
            this.progbar.Name = "progbar";
            this.progbar.Size = new System.Drawing.Size(797, 13);
            this.progbar.Step = 4;
            this.progbar.TabIndex = 0;
            this.progbar.Value = 25;
            this.progbar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progbar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tc.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tp5.ResumeLayout(false);
            this.tp5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tp5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label la_end_3;
        private System.Windows.Forms.Label la_end_2;
        private System.Windows.Forms.Label la_end_1;
        private System.Windows.Forms.Label pic_true;
        private System.Windows.Forms.Label pic_false;
        private System.Windows.Forms.Button buEnd;
        private System.Windows.Forms.Label cfalse;
        private System.Windows.Forms.Label ctrue;
        private System.Windows.Forms.ProgressBar progbar;
    }
}

