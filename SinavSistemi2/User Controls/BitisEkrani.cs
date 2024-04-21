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
    public partial class BitisEkrani : UserControl
    {
        public int conc;
        public BitisEkrani()
        {
            InitializeComponent();
        }

        public void WriteConc()
        {

            label3.Text = Convert.ToString(conc) ;

            if (conc >= 6)
            {
                label6.Text = "Geçtiniz! Tebrik ederiz.";
            }
            else
            {
                label6.Text = "Kaldınız. Lütfen bir dahaki sınavı bekleyiniz.";
            }
        }
    }
}
