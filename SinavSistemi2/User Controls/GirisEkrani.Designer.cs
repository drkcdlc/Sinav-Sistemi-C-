
namespace SinavSistemi2.User_Controls
{
    partial class GirisEkrani
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.cbxRead = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(0, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(842, 80);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merhaba.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hepinize başarılar dileriz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Komisyon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lütfen isminizi giriniz:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(82, 293);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(125, 27);
            this.tbxName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "İsim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Soyisim";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(82, 326);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(125, 27);
            this.tbxSurname.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "E-Mail";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(82, 359);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(125, 27);
            this.tbxEmail.TabIndex = 9;
            // 
            // cbxRead
            // 
            this.cbxRead.AutoSize = true;
            this.cbxRead.Location = new System.Drawing.Point(295, 377);
            this.cbxRead.Name = "cbxRead";
            this.cbxRead.Size = new System.Drawing.Size(216, 24);
            this.cbxRead.TabIndex = 11;
            this.cbxRead.Text = "Okudum ve kabul ediyorum.";
            this.cbxRead.UseVisualStyleBackColor = true;
            this.cbxRead.CheckedChanged += new System.EventHandler(this.cbxRead_CheckedChanged);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxRead);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisEkrani";
            this.Size = new System.Drawing.Size(856, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.CheckBox cbxRead;
    }
}
