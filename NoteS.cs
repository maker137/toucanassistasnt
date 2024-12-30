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
    public partial class NoteS : Form
    {
        public NoteS()
        {
            InitializeComponent();
        }

        private void NoteS_Load(object sender, EventArgs e)
        {
            if(File.Exists("configdata"))
            {
                textBox1.Text = File.ReadAllLines("configdata")[0];
            }
        }
    }
}
