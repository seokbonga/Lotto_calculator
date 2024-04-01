namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblifResult = new System.Windows.Forms.Label();
            this.lblswitchResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // nNumber1
            // 
            this.nNumber1.Location = new System.Drawing.Point(113, 98);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(290, 35);
            this.nNumber1.TabIndex = 0;
            // 
            // nNumber2
            // 
            this.nNumber2.Location = new System.Drawing.Point(444, 98);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(290, 35);
            this.nNumber2.TabIndex = 1;
            // 
            // cboxDay
            // 
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cboxDay.Location = new System.Drawing.Point(113, 390);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(309, 32);
            this.cboxDay.TabIndex = 2;
            this.cboxDay.SelectedIndexChanged += new System.EventHandler(this.cboxDay_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "요일선택";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(857, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 118);
            this.button1.TabIndex = 6;
            this.button1.Text = "Number비교";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(857, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 118);
            this.button2.TabIndex = 7;
            this.button2.Text = "선택요일확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblifResult
            // 
            this.lblifResult.AutoSize = true;
            this.lblifResult.Location = new System.Drawing.Point(109, 252);
            this.lblifResult.Name = "lblifResult";
            this.lblifResult.Size = new System.Drawing.Size(106, 24);
            this.lblifResult.TabIndex = 8;
            this.lblifResult.Text = "lblifResult";
            // 
            // lblswitchResult
            // 
            this.lblswitchResult.AutoSize = true;
            this.lblswitchResult.Location = new System.Drawing.Point(109, 590);
            this.lblswitchResult.Name = "lblswitchResult";
            this.lblswitchResult.Size = new System.Drawing.Size(160, 24);
            this.lblswitchResult.TabIndex = 9;
            this.lblswitchResult.Text = "lblswitchResult";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.lblswitchResult);
            this.Controls.Add(this.lblifResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.nNumber1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblifResult;
        private System.Windows.Forms.Label lblswitchResult;
    }
}