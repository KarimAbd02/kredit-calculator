namespace percentCalc
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numstartcount = new System.Windows.Forms.NumericUpDown();
            this.numpercent = new System.Windows.Forms.NumericUpDown();
            this.numyears = new System.Windows.Forms.NumericUpDown();
            this.comboprocess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).BeginInit();
            this.SuspendLayout();
            // 
            // numstartcount
            // 
            this.numstartcount.DecimalPlaces = 2;
            this.numstartcount.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numstartcount.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numstartcount.Location = new System.Drawing.Point(195, 30);
            this.numstartcount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numstartcount.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numstartcount.Name = "numstartcount";
            this.numstartcount.Size = new System.Drawing.Size(185, 28);
            this.numstartcount.TabIndex = 0;
            this.numstartcount.ThousandsSeparator = true;
            this.numstartcount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numpercent
            // 
            this.numpercent.DecimalPlaces = 2;
            this.numpercent.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numpercent.Location = new System.Drawing.Point(195, 73);
            this.numpercent.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numpercent.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            131072});
            this.numpercent.Name = "numpercent";
            this.numpercent.Size = new System.Drawing.Size(185, 28);
            this.numpercent.TabIndex = 1;
            this.numpercent.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numyears
            // 
            this.numyears.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numyears.Location = new System.Drawing.Point(195, 116);
            this.numyears.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numyears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numyears.Name = "numyears";
            this.numyears.Size = new System.Drawing.Size(68, 28);
            this.numyears.TabIndex = 2;
            this.numyears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboprocess
            // 
            this.comboprocess.BackColor = System.Drawing.SystemColors.Window;
            this.comboprocess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboprocess.FormattingEnabled = true;
            this.comboprocess.Items.AddRange(new object[] {
            "Ежедневно",
            "Ежемесячно",
            "Ежеквартально",
            "По полугодиям",
            "Ежегодно"});
            this.comboprocess.Location = new System.Drawing.Point(195, 166);
            this.comboprocess.Name = "comboprocess";
            this.comboprocess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboprocess.Size = new System.Drawing.Size(185, 32);
            this.comboprocess.TabIndex = 3;
            this.comboprocess.SelectedIndexChanged += new System.EventHandler(this.comboprocess_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сумма кредита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Процентная ставка (%)\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество лет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вариант начисления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Итого:";
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.Location = new System.Drawing.Point(394, 75);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(115, 69);
            this.calc.TabIndex = 10;
            this.calc.Text = "Рассчитать";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // total
            // 
            this.total.DecimalPlaces = 2;
            this.total.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.total.Location = new System.Drawing.Point(195, 218);
            this.total.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(185, 28);
            this.total.TabIndex = 11;
            this.total.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Оплата:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(394, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Очиситить поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(521, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboprocess);
            this.Controls.Add(this.numyears);
            this.Controls.Add(this.numpercent);
            this.Controls.Add(this.numstartcount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредит";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numstartcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numstartcount;
        private System.Windows.Forms.NumericUpDown numpercent;
        private System.Windows.Forms.NumericUpDown numyears;
        private System.Windows.Forms.ComboBox comboprocess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.NumericUpDown total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

