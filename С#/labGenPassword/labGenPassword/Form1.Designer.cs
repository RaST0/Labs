namespace labGenPassword
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
            this.tpas = new System.Windows.Forms.TextBox();
            this.bgen = new System.Windows.Forms.Button();
            this.aLower = new System.Windows.Forms.CheckBox();
            this.aUpper = new System.Windows.Forms.CheckBox();
            this.aNumber = new System.Windows.Forms.CheckBox();
            this.aSpec = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aLength = new System.Windows.Forms.NumericUpDown();
            this.aRus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.aLength)).BeginInit();
            this.SuspendLayout();
            // 
            // tpas
            // 
            this.tpas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpas.Location = new System.Drawing.Point(12, 12);
            this.tpas.Name = "tpas";
            this.tpas.Size = new System.Drawing.Size(315, 45);
            this.tpas.TabIndex = 0;
            this.tpas.Text = "< Password >";
            this.tpas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bgen
            // 
            this.bgen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bgen.Location = new System.Drawing.Point(12, 63);
            this.bgen.Name = "bgen";
            this.bgen.Size = new System.Drawing.Size(315, 63);
            this.bgen.TabIndex = 1;
            this.bgen.Text = "Generate";
            this.bgen.UseVisualStyleBackColor = true;
            this.bgen.Click += new System.EventHandler(this.bgen_Click);
            // 
            // aLower
            // 
            this.aLower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLower.AutoSize = true;
            this.aLower.Checked = true;
            this.aLower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aLower.Location = new System.Drawing.Point(10, 133);
            this.aLower.Name = "aLower";
            this.aLower.Size = new System.Drawing.Size(247, 30);
            this.aLower.TabIndex = 2;
            this.aLower.Text = "Английские символы";
            this.aLower.UseVisualStyleBackColor = true;
            // 
            // aUpper
            // 
            this.aUpper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aUpper.AutoSize = true;
            this.aUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aUpper.Location = new System.Drawing.Point(10, 160);
            this.aUpper.Name = "aUpper";
            this.aUpper.Size = new System.Drawing.Size(334, 30);
            this.aUpper.TabIndex = 3;
            this.aUpper.Text = "Символы в верхнем регистре";
            this.aUpper.UseVisualStyleBackColor = true;
            // 
            // aNumber
            // 
            this.aNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aNumber.AutoSize = true;
            this.aNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aNumber.Location = new System.Drawing.Point(10, 187);
            this.aNumber.Name = "aNumber";
            this.aNumber.Size = new System.Drawing.Size(106, 30);
            this.aNumber.TabIndex = 4;
            this.aNumber.Text = "Цифры";
            this.aNumber.UseVisualStyleBackColor = true;
            // 
            // aSpec
            // 
            this.aSpec.AutoSize = true;
            this.aSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aSpec.Location = new System.Drawing.Point(10, 214);
            this.aSpec.Name = "aSpec";
            this.aSpec.Size = new System.Drawing.Size(271, 30);
            this.aSpec.TabIndex = 5;
            this.aSpec.Text = "Специальные символы";
            this.aSpec.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Длина пароля";
            // 
            // aLength
            // 
            this.aLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aLength.Location = new System.Drawing.Point(146, 250);
            this.aLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.aLength.Name = "aLength";
            this.aLength.Size = new System.Drawing.Size(67, 26);
            this.aLength.TabIndex = 7;
            this.aLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.aLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // aRus
            // 
            this.aRus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aRus.AutoSize = true;
            this.aRus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aRus.Location = new System.Drawing.Point(122, 187);
            this.aRus.Name = "aRus";
            this.aRus.Size = new System.Drawing.Size(212, 30);
            this.aRus.TabIndex = 8;
            this.aRus.Text = "Русские символы";
            this.aRus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(339, 277);
            this.Controls.Add(this.aRus);
            this.Controls.Add(this.aLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aSpec);
            this.Controls.Add(this.aNumber);
            this.Controls.Add(this.aUpper);
            this.Controls.Add(this.aLower);
            this.Controls.Add(this.bgen);
            this.Controls.Add(this.tpas);
            this.MaximumSize = new System.Drawing.Size(355, 316);
            this.MinimumSize = new System.Drawing.Size(355, 316);
            this.Name = "Form1";
            this.Text = "Gen Password";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tpas;
        private System.Windows.Forms.Button bgen;
        private System.Windows.Forms.CheckBox aLower;
        private System.Windows.Forms.CheckBox aUpper;
        private System.Windows.Forms.CheckBox aNumber;
        private System.Windows.Forms.CheckBox aSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown aLength;
        private System.Windows.Forms.CheckBox aRus;
    }
}

