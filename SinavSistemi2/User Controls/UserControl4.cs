﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi2.User_Controls
{
    public partial class UserControl4 : UserControl
    {
        public int sum;
        public UserControl4()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                sum = 1;
            }

            else if (radioButton4.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                sum = 0;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                sum = 1;
            }

            else if (radioButton4.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                sum = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                sum = 1;
            }

            else if (radioButton4.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                sum = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                sum = 1;
            }

            else if (radioButton4.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                sum = 0;
            }
        }
    }
}
