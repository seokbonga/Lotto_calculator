using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 루프예제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void 판단예제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void 간단한계산ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void 로또ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }
    }
}
