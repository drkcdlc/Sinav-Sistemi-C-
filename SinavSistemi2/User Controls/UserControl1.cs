﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi2
{
    public partial class UserControl1 : UserControl
    {
        public int sum;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                sum = 1;
            }

            else if (radioButton3.Checked == true || radioButton2.Checked == true || radioButton1.Checked == true)
            {
                sum = 0;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                sum = 1;
            }

            else if (radioButton3.Checked == true || radioButton2.Checked == true || radioButton1.Checked == true)
            {
                sum = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                sum = 1;
            }

            else if (radioButton3.Checked == true || radioButton2.Checked == true || radioButton1.Checked == true)
            {
                sum = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                sum = 1;
            }

            else if (radioButton3.Checked == true || radioButton2.Checked == true || radioButton1.Checked == true)
            {
                sum = 0;
            }
        }
    }
}
