using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImproveProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(label1.Text == "Turn Alarm Off")
            {
                label1.Text = "Turn Alarm On";
            }
            else if(label1.Text == "Turn Alarm On")
            {
                label1.Text = "Turn Alarm Off";
            }

        }
    }
}
