namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.c윈도우폼예제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.루프예제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.판단예제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.간단한어플ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.간단한계산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로또ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.c윈도우폼예제ToolStripMenuItem,
            this.간단한어플ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // c윈도우폼예제ToolStripMenuItem
            // 
            this.c윈도우폼예제ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.루프예제ToolStripMenuItem,
            this.판단예제ToolStripMenuItem});
            this.c윈도우폼예제ToolStripMenuItem.Name = "c윈도우폼예제ToolStripMenuItem";
            this.c윈도우폼예제ToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.c윈도우폼예제ToolStripMenuItem.Text = "C# 윈도우폼 예제";
            // 
            // 루프예제ToolStripMenuItem
            // 
            this.루프예제ToolStripMenuItem.Name = "루프예제ToolStripMenuItem";
            this.루프예제ToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.루프예제ToolStripMenuItem.Text = "루프예제";
            this.루프예제ToolStripMenuItem.Click += new System.EventHandler(this.루프예제ToolStripMenuItem_Click);
            // 
            // 판단예제ToolStripMenuItem
            // 
            this.판단예제ToolStripMenuItem.Name = "판단예제ToolStripMenuItem";
            this.판단예제ToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.판단예제ToolStripMenuItem.Text = "판단예제";
            this.판단예제ToolStripMenuItem.Click += new System.EventHandler(this.판단예제ToolStripMenuItem_Click);
            // 
            // 간단한어플ToolStripMenuItem
            // 
            this.간단한어플ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.간단한계산ToolStripMenuItem,
            this.로또ToolStripMenuItem});
            this.간단한어플ToolStripMenuItem.Name = "간단한어플ToolStripMenuItem";
            this.간단한어플ToolStripMenuItem.Size = new System.Drawing.Size(162, 38);
            this.간단한어플ToolStripMenuItem.Text = "간단한 어플";
            // 
            // 간단한계산ToolStripMenuItem
            // 
            this.간단한계산ToolStripMenuItem.Name = "간단한계산ToolStripMenuItem";
            this.간단한계산ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.간단한계산ToolStripMenuItem.Text = "간단한 계산";
            this.간단한계산ToolStripMenuItem.Click += new System.EventHandler(this.간단한계산ToolStripMenuItem_Click);
            // 
            // 로또ToolStripMenuItem
            // 
            this.로또ToolStripMenuItem.Name = "로또ToolStripMenuItem";
            this.로또ToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.로또ToolStripMenuItem.Text = "로또";
            this.로또ToolStripMenuItem.Click += new System.EventHandler(this.로또ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 604);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem c윈도우폼예제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 루프예제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 판단예제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 간단한어플ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 간단한계산ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로또ToolStripMenuItem;
    }
}