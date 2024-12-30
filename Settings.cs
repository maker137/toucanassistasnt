using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Toucan_Assistant
{
    public partial class Settings : Form
    {
        string foo;
        public Settings()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foo = openFileDialog1.FileName;
            }
            else
            {
                foo = "%userdir%/Pictures/toucan.jpg";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string checker;
            checker = textBox1.Text;
            string[] configdata = {checker, foo };
            File.WriteAllLines("configdata", configdata);
        }
    }
}
