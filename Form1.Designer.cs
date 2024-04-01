namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonFor = new System.Windows.Forms.Button();
            this.buttonForeach = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(55, 46);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(724, 677);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonFor
            // 
            this.buttonFor.Location = new System.Drawing.Point(817, 46);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(427, 157);
            this.buttonFor.TabIndex = 1;
            this.buttonFor.Text = "For문";
            this.buttonFor.UseVisualStyleBackColor = true;
            this.buttonFor.Click += new System.EventHandler(this.buttonFor_Click);
            // 
            // buttonForeach
            // 
            this.buttonForeach.Location = new System.Drawing.Point(817, 236);
            this.buttonForeach.Name = "buttonForeach";
            this.buttonForeach.Size = new System.Drawing.Size(427, 157);
            this.buttonForeach.TabIndex = 2;
            this.buttonForeach.Text = "Foreach문";
            this.buttonForeach.UseVisualStyleBackColor = true;
            this.buttonForeach.Click += new System.EventHandler(this.buttonForeach_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(827, 436);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(416, 156);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "출력창 지우기";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 764);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonForeach);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.textBoxResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.Button buttonForeach;
        private System.Windows.Forms.Button buttonClear;
    }
}

