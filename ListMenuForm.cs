using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Toucan_Assistant
{
    public partial class ListMenuForm : Form
    {
        public ListMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DaFish form = new DaFish();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoteS form = new NoteS();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PicFrame form = new PicFrame();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GoogleEngine form = new GoogleEngine();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClockWidget form = new ClockWidget();
            form.Show();
        }
    }
}
