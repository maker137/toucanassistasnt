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
    public partial class PicFrame : Form
    {
        public PicFrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.BackgroundImage = Image.FromFile(dialog.FileName);
            }
        }

        private void PicFrame_Load(object sender, EventArgs e)
        {
            if (File.Exists("configdata")) 
            {
                try
                {
                    pictureBox1.BackgroundImage = Image.FromFile(File.ReadAllLines("configdata")[1]);
                }
                catch 
                {
                    MessageBox.Show("There is no picture selected.");
                }
            }
        }
    }
}
