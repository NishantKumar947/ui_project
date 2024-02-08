using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sign_Up_Form
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void sabveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            PrintDialog abcd = new PrintDialog();
            abcd.ShowDialog();
            //printDialog1.ShowDialog();
        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();
            //panel1.BackColor = colorDialog1.Color;
        }

        private void fontbtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            //TextBox.DefaultFont = fontDialog.Font;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();
            //this.BackColor = colorDialog1.Color;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void aquaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Azure;
        }
    }
}
