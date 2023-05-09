using System;
using System.Windows.Forms;

namespace ContextMenu
{
    public partial class Form1 : Form
    {
        ContextMenuStrip m;
        public Form1()
        {
            InitializeComponent();
            m = new ContextMenuStrip();
            var item = m.Items.Add("Menu Item 1");
            (item as ToolStripMenuItem).Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Пункт меню " + (sender as ToolStripMenuItem).Text);
            };
            item = m.Items.Add("Menu Item 2");
            (item as ToolStripMenuItem).Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Пункт меню " + (sender as ToolStripMenuItem).Text);
            };
            item = m.Items.Add("Menu Item 3");
            (item as ToolStripMenuItem).Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Пункт меню " + (sender as ToolStripMenuItem).Text);
            };
            ContextMenuStrip = m;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pastleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();           

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
