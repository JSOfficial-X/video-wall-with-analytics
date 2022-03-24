using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rdo_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                MessageBox.Show("1");
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
           if (radioButton2.Checked)
            {
                MessageBox.Show("2");
                radioButton2.Checked = false;
                radioButton1.Checked = true;
            }
        }
    }
}
