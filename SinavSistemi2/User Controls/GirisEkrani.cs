using System;
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
    public partial class GirisEkrani : UserControl
    {
        public string name;
        public string surname;
        public string email;
        public int readornot = 0;
        public GirisEkrani()
        {
            InitializeComponent();
        }

        public void NameEquals()
        {
            name = tbxName.Text;
            surname = tbxSurname.Text;
            email = tbxEmail.Text;
        }

        public void ReadOrNot()
        {
            if (cbxRead.Checked == true)
            {
                readornot = 1;
            }
        }

        private void cbxRead_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
