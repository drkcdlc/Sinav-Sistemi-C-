using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FluentValidation;
using SinavSistemi2.Dependancy_Resolvers.Ninject;
using SinavSistemi2.EntityFramework;
using SinavSistemi2.FluentValidation;
using SinavSistemi2.User_Controls;

namespace SinavSistemi2
{
    public partial class Form1 : Form
    {
        private IAdder _adder;
        private IValidator<TextEntity> _validator;
        private IText _text;

        private int qnum;
        private int cheatedornot = 0;

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public Form1()
        {
            InitializeComponent();

            _adder = InstanceFactory.GetInstance<IAdder>();
            _validator = InstanceFactory.GetInstance<IValidator<TextEntity>>();
            _text = InstanceFactory.GetInstance<IText>();
        }

        private void girisEkrani1_Load(object sender, EventArgs e)
        {
            bitisEkrani1.Hide();
            btnCevap.Hide();
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label1.SendToBack();
            label2.SendToBack();
            label3.SendToBack();
            btnBefore.Enabled = false;
            btnBefore.SendToBack();
            btnNext.Enabled = false;
            btnNext.SendToBack();
            qnum = 1;


        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            girisEkrani1.NameEquals();

            int erroroccured = 0;

            if (girisEkrani1.name == "" && girisEkrani1.surname == "" && girisEkrani1.email == "")
            {
                MessageBox.Show("İsim, soyisim ve E-mail kutucukları boş bırakılamaz");
            }
            else
            {

                try
                {
                    Validator(new TextEntity
                    {
                        Namet = girisEkrani1.name,
                        Emailt = girisEkrani1.email,
                        Surnamet = girisEkrani1.surname
                    });
                }
                catch (Exception exception)
                {
                    erroroccured = 1;
                }

                if (erroroccured == 0)
                {
                    girisEkrani1.ReadOrNot();
                    if (girisEkrani1.readornot == 0)
                    {
                        MessageBox.Show("Lütfen alttaki kutucuk ile onay veriniz.");
                    }
                    else
                    {
                        girisEkrani1.Hide();
                        btnGiris.Hide();
                        secondTimer.Start();
                        label1.Enabled = true;
                        label2.Enabled = true;
                        label3.Enabled = true;
                        label3.BringToFront();
                        label2.BringToFront();
                        label1.BringToFront();
                        btnBefore.Enabled = true;
                        btnBefore.BringToFront();
                        btnNext.Enabled = true;
                        btnNext.BringToFront();

                        label1.Text = "8";
                        label3.Text = "0";
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qnum = 1;
            QuestionChanged();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            qnum = 2;
            QuestionChanged();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qnum = 3;
            QuestionChanged();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            qnum = 4;
            QuestionChanged();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            qnum = 5;
            QuestionChanged();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            qnum = 6;
            QuestionChanged();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            qnum = 7;
            QuestionChanged();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            qnum = 8;
            QuestionChanged();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            qnum = 9;
            QuestionChanged();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            qnum = 10;
            QuestionChanged();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ending();
        }

        private void btnCevap_Click(object sender, EventArgs e)
        {
            btnCevap.Hide();
            bitisEkrani1.Hide();
            button11.Enabled = false;
        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        public int seconds = 0;
        public int minutes = 8;
        private int afkcounter = 0;
        private void secondTimer_Tick(object sender, EventArgs e)
        {
            label3.Text = seconds--.ToString();
            label1.Text = minutes.ToString();
            if (seconds < 0)
            {
                minutes--;
                seconds = 59;
            }

            if (seconds < 0 && minutes < 0)
            {
                secondTimer.Stop();
                Ending();
            }

            if (IsActive(this.Handle) == false)
            {
                this.WindowState = FormWindowState.Minimized;
                this.WindowState = FormWindowState.Normal;
                afkcounter++;

                if (afkcounter > 2)
                {
                    cheatedornot = 1;
                    Ending();
                    MessageBox.Show("3 kez programı arkaya attığınızdan dolayı sınavınız sonlandırılmıştır.");
                }
            }


        }

        public bool IsActive(IntPtr handle)
        {
            IntPtr activeHandle = GetForegroundWindow();
            return (activeHandle == handle);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ending()
        {
            if (userControl11.sum == 1)
            {
                button1.BackColor = Color.LawnGreen;
            }

            else
            {
                button1.BackColor = Color.Crimson;
            }

            if (userControl21.sum == 1)
            {
                button2.BackColor = Color.LawnGreen;
            }

            else
            {
                button2.BackColor = Color.Crimson;
            }

            if (userControl31.sum == 1)
            {
                button3.BackColor = Color.LawnGreen;
            }

            else
            {
                button3.BackColor = Color.Crimson;
            }

            if (userControl41.sum == 1)
            {
                button4.BackColor = Color.LawnGreen;
            }

            else
            {
                button4.BackColor = Color.Crimson;
            }

            if (userControl51.sum == 1)
            {
                button5.BackColor = Color.LawnGreen;
            }

            else
            {
                button5.BackColor = Color.Crimson;
            }

            if (userControl61.sum == 1)
            {
                button6.BackColor = Color.LawnGreen;
            }

            else
            {
                button6.BackColor = Color.Crimson;
            }

            if (userControl71.sum == 1)
            {
                button7.BackColor = Color.LawnGreen;
            }

            else
            {
                button7.BackColor = Color.Crimson;
            }

            if (userControl81.sum == 1)
            {
                button8.BackColor = Color.LawnGreen;
            }

            else
            {
                button8.BackColor = Color.Crimson;
            }

            if (userControl91.sum == 1)
            {
                button9.BackColor = Color.LawnGreen;
            }

            else
            {
                button9.BackColor = Color.Crimson;
            }

            if (userControl101.sum == 1)
            {
                button10.BackColor = Color.LawnGreen;
            }

            else
            {
                button10.BackColor = Color.Crimson;
            }

            int total;

            if (cheatedornot == 1)
            {
                total = 0;
            }

            else
            {
                total = userControl11.sum + userControl21.sum + userControl31.sum + userControl41.sum +
                        userControl51.sum + userControl61.sum + userControl71.sum + userControl81.sum + userControl91.sum +
                        userControl101.sum;
            }

            bitisEkrani1.conc = total;
            bitisEkrani1.WriteConc();

            bitisEkrani1.Show();
            bitisEkrani1.BringToFront();

            string passedornot = "";

            string passedornotmsg = "";

            if (total >= 6)
            {
                passedornot = "Geçti";
                passedornotmsg = "Sınavdan geçtiniz. Tebrik ederiz.";
            }
            else
            {

                switch (cheatedornot)
                {
                    case 1:
                        passedornot = "Kaldı";
                        passedornotmsg = "Sınav programını 3 ten fazla kez alta atmaya çalıştığınız için sınavdan kaldınız. Lütfen bir dahaki sınavı bekleyiniz.";
                        break;
                    case 0:
                        passedornot = "Kaldı";
                        passedornotmsg = "Sınavdan kaldınız. Lütfen bir dahaki sınavı bekleyiniz.";
                        break;

                }
            }

            girisEkrani1.NameEquals();

            _adder.Add(new TableEntity
            {
                Name = girisEkrani1.name,
                Surname = girisEkrani1.surname,
                Results = total,
                PassedOrNot = passedornot,
                Email = girisEkrani1.email
            }
            );
            SmtpClient smtpClient = new SmtpClient("smtp.office365.com", 587);

            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("yourmailaddress", "yourmailpassword");
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(girisEkrani1.email);
            mailMessage.From = new MailAddress("yourmailaddress");
            mailMessage.Subject = "Online Kodlama Sınavı Sonucunuz";
            mailMessage.Body = $"Merhaba {girisEkrani1.name} {girisEkrani1.surname}. {passedornotmsg} Sınav sonucunuz: {total}. Sorunuz varsa burenkut@hotmail.com adresinden iletişime geçebilirsiniz.";
            smtpClient.Send(mailMessage);
            btnCevap.Show();
            btnCevap.BringToFront();

            secondTimer.Stop();

        }

        private void QuestionChanged()
        {

            if (button11.Enabled == true)
            {
                if (qnum == 1)
                {
                    userControl11.BringToFront();
                }
                if (qnum == 2)
                {
                    userControl21.BringToFront();
                }
                if (qnum == 3)
                {
                    userControl31.BringToFront();
                }
                if (qnum == 4)
                {
                    userControl41.BringToFront();
                }
                if (qnum == 5)
                {
                    userControl51.BringToFront();
                }
                if (qnum == 6)
                {
                    userControl61.BringToFront();
                }
                if (qnum == 7)
                {
                    userControl71.BringToFront();
                }
                if (qnum == 8)
                {
                    userControl81.BringToFront();
                }
                if (qnum == 9)
                {
                    userControl91.BringToFront();
                }
                if (qnum == 10)
                {
                    userControl101.BringToFront();
                }
            }

            if (button11.Enabled == false)
            {
                if (qnum == 1)
                {
                    userControl11.BringToFront();
                    lblt1.Enabled = true;
                    lblt2.Enabled = false;
                    lblt3.Enabled = false;
                    lblt4.Enabled = false;
                    lblt5.Enabled = false;
                    lblt6.Enabled = false;
                    lblt7.Enabled = false;
                    lblt8.Enabled = false;
                    lblt9.Enabled = false;
                    lblt10.Enabled = false;
                    lblt1.BringToFront();
                }
                if (qnum == 2)
                {
                    userControl21.BringToFront();
                    lblt1.Enabled = false;
                    lblt2.Enabled = true;
                    lblt3.Enabled = false;
                    lblt4.Enabled = false;
                    lblt5.Enabled = false;
                    lblt6.Enabled = false;
                    lblt7.Enabled = false;
                    lblt8.Enabled = false;
                    lblt9.Enabled = false;
                    lblt10.Enabled = false;
                    lblt2.BringToFront();
                }
                if (qnum == 3)
                {
                    userControl31.BringToFront();
                    lblt1.Enabled = false;
                    lblt2.Enabled = false;
                    lblt3.Enabled = true;
                    lblt4.Enabled = false;
                    lblt5.Enabled = false;
                    lblt6.Enabled = false;
                    lblt7.Enabled = false;
                    lblt8.Enabled = false;
                    lblt9.Enabled = false;
                    lblt10.Enabled = false;
                    lblt3.BringToFront();
                }
                if (qnum == 4)
                {
                    userControl41.BringToFront();
                    lblt1.Enabled = false;
                    lblt2.Enabled = false;
                    lblt3.Enabled = false;
                    lblt4.Enabled = true;
                    lblt5.Enabled = false;
                    lblt6.Enabled = false;
                    lblt7.Enabled = false;
                    lblt8.Enabled = false;
                    lblt9.Enabled = false;
                    lblt10.Enabled = false;
                    lblt4.BringToFront();
                }
                if (qnum == 5)
                {
                    userControl51.BringToFront();
                    lblt1.Enabled = false;
                    lblt2.Enabled = false;
                    lblt3.Enabled = false;
                    lblt4.Enabled = false;
                    lblt5.Enabled = true;
                    lblt6.Enabled = false;
                    lblt7.Enabled = false;
                    lblt8.Enabled = false;
                    lblt9.Enabled = false;
                    lblt10.Enabled = false;
                    lblt5.BringToFront();
                }
                if (qnum == 6)
                {
                    userControl61.BringToFront();
                    lblt1.Enabled = false;
                    lblt2.Enabled = false;
                    lblt3.Enabled = false;
                    lblt4.Enabled = false;
                    lblt5.Enabled = false;
                    lblt6.Enabled = true;
                    lblt7.Enabled = false;
                    lblt8.Enabled = false;
                    lblt9.Enabled = false;
                    lblt10.Enabled = false;
                    lblt6.BringToFront();
                }
                if (qnum == 7)
                {
                    userControl71.BringToFront();
                    lblt1.Enabled = false;
                    lblt2.Enabled = false;
                    lblt3.Enabled = false;
                    lblt4.Enabled = false;
                    lblt5.Enabled = false;
                    lblt6.Enabled = false;
                    lblt7.Enabled = true;
                    lblt8.Enabled = false;
                    lblt9.Enabled = false;
                    lblt10.Enabled = false;
                    lblt7.BringToFront();
                }
                if (qnum == 8)
                {
                    userControl81.BringToFront();
                    lblt1.Enabled = false;
                    lblt2.Enabled = false;
                    lblt3.Enabled = false;
                    lblt4.Enabled = false;
                    lblt5.Enabled = false;
                    lblt6.Enabled = false;
                    lblt7.Enabled = false;
                    lblt8.Enabled = true;
                    lblt9.Enabled = false;
                    lblt10.Enabled = false;
                    lblt8.BringToFront();
                }
                if (qnum == 9)
                {
                    userControl91.BringToFront();
                    lblt1.Enabled = false;
                    lblt2.Enabled = false;
                    lblt3.Enabled = false;
                    lblt4.Enabled = false;
                    lblt5.Enabled = false;
                    lblt6.Enabled = false;
                    lblt7.Enabled = false;
                    lblt8.Enabled = false;
                    lblt9.Enabled = true;
                    lblt10.Enabled = false;
                    lblt9.BringToFront();
                }
                if (qnum == 10)
                {
                    userControl101.BringToFront();
                    lblt1.Enabled = false;
                    lblt2.Enabled = false;
                    lblt3.Enabled = false;
                    lblt4.Enabled = false;
                    lblt5.Enabled = false;
                    lblt6.Enabled = false;
                    lblt7.Enabled = false;
                    lblt8.Enabled = false;
                    lblt9.Enabled = false;
                    lblt10.Enabled = true;
                    lblt10.BringToFront();
                }
            }

        }

        private void minuteTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            if (qnum > 0)
            {
                qnum--;
            }
            QuestionChanged();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (qnum < 10)
            {
                qnum++;
            }
            QuestionChanged();
        }

        public void Validator(TextEntity textEntity)
        {
            var resultemail = _validator.Validate(textEntity, options=>options.IncludeRuleSets("Email"));
            if (!resultemail.IsValid)
            {
                MessageBox.Show("Email kutucuğunu kontrol ediniz.");
                throw new ValidationException(resultemail.Errors);
            }

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            
        }
    }
}
