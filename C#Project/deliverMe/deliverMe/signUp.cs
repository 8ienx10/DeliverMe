using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deliverMe
{
    public partial class signUp : Form
    {
        Boolean firstTime = false;
        
        public signUp()
        {
            InitializeComponent();
        }

        private void signUp_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Sex";
            themeReload();
            languageReload();
        }

        private void themeReload()
        {
            if (signIn.isDarkMode)
            {
                picboxTitle.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\titleDarkMode.jpg");
                btnTheme.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\sun.png");

                this.BackColor = Color.Black;
                btnLanguage.BackColor = Color.Black;
                btnLanguage.ForeColor = Color.White;
                btnTheme.BackColor = Color.Black;

                lblor.ForeColor = Color.White;
                lblSignup.ForeColor = Color.White;

                lblID.ForeColor = Color.White;
                lblPass.ForeColor = Color.White;
                lblName.ForeColor = Color.White;
                checkBox1.ForeColor = Color.White;

                btnCreate.BackColor = Color.Black;
                btnCreate.ForeColor = Color.White;

                label1.ForeColor = Color.White;
            }
            else
            {
                picboxTitle.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\titleLightMode.jpg");
                btnTheme.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\moon.png");

                this.BackColor = Color.White;
                btnLanguage.BackColor = Color.White;
                btnLanguage.ForeColor = Color.Black;
                btnTheme.BackColor = Color.White;

                lblor.ForeColor = Color.Black;
                lblSignup.ForeColor = Color.Black;

                lblID.ForeColor = Color.Black;
                lblPass.ForeColor = Color.Black ;
                lblName.ForeColor = Color.Black;
                checkBox1.ForeColor = Color.Black;

                btnCreate.BackColor = Color.White;
                btnCreate.ForeColor = Color.Black;

                label1.ForeColor = Color.Black;
            }
            
        }

        private void languageReload() {
            if (signIn.isArabic)
            {
                btnLanguage.Text = "E";

                lblSignup.Text = "انشاء حساب";
                lblSignup.Location = new System.Drawing.Point(165, 342);

                lblor.Text = "او";
                lblor.Location = new System.Drawing.Point(316, 388);

                linklblCreate.Text = "تسجيل الدخول";
                linklblCreate.Location = new System.Drawing.Point(248, 388);

                lblID.Text = "ادخل رقمك الجامعي";
                lblID.Location = new System.Drawing.Point(197, 438);

                lblPass.Text = "ادخل كلمة السر";
                lblPass.Location = new System.Drawing.Point(227, 524);

                lblName.Text = "الاسم";
                lblName.Location = new System.Drawing.Point(182, 610);

                btnCreate.Text = "انشاء";
                comboBox1.Text = "الجنس";

                checkBox1.Location = new System.Drawing.Point(317, 684);

                label1.Text = "اوافق على";
                label1.Location = new System.Drawing.Point(261, 684);

                linkLabel1.Text = "الشروط والاحكام";
                linkLabel1.Location = new System.Drawing.Point(185, 684);

            }
            else
            {
                btnLanguage.Text = "ع";

                lblSignup.Text = "Singn up";
                lblSignup.Location = new System.Drawing.Point(4, 342);

                lblor.Text = "or";
                lblor.Location = new System.Drawing.Point(14, 388);

                linklblCreate.Text = "sign in";
                linklblCreate.Location = new System.Drawing.Point(27, 388);

                lblID.Text = "Enter Your ID";
                lblID.Location = new System.Drawing.Point(7, 438);

                lblPass.Text = "Enter Your Password";
                lblPass.Location = new System.Drawing.Point(7, 524);

                lblName.Text = "Name";
                lblName.Location = new System.Drawing.Point(10, 610);

                btnCreate.Text = "Create";
                comboBox1.Text = "Sex";

                checkBox1.Location = new System.Drawing.Point(15, 684);

                label1.Text = "I agree to the";
                label1.Location = new System.Drawing.Point(28, 684);

                linkLabel1.Text = "terms and conditions";
                linkLabel1.Location = new System.Drawing.Point(96, 684);

            }
        }

        private void closeApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (txtboxID.Text != "" && txtboxName.Text != "" && txtboxPass.Text != "" && (comboBox1.Text == "Male" || comboBox1.Text == "Female"))
                {
                    Random random = new Random();

                    int w = random.Next(1, 900000000);
                    int b = random.Next(1, 900000000);
                    
                    if (txtboxID.Text.Substring(0,3) == "100") {
                        try
                        {
                            _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
                            _C_ProjectDataSetTableAdapters.WalletTableAdapter wallet = new _C_ProjectDataSetTableAdapters.WalletTableAdapter();

                            student.addAll(decimal.Parse(txtboxID.Text),txtboxName.Text,comboBox1.Text, "Gaza", w,txtboxPass.Text);
                            wallet.addAll(w, decimal.Parse(txtboxID.Text),10);

                            signIn signin = new signIn();
                            this.Hide();
                            signin.ShowDialog();
                        }
                        catch (Exception e1) {
                            MessageBox.Show("ERROR while creating an account\n\n" + e1);
                        }
                    }
                    else if (txtboxID.Text.Substring(0, 3) == "200")
                    {
                        try
                        {
                            _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
                            _C_ProjectDataSetTableAdapters.BusTableAdapter bus = new _C_ProjectDataSetTableAdapters.BusTableAdapter();
                            _C_ProjectDataSetTableAdapters.WalletTableAdapter wallet = new _C_ProjectDataSetTableAdapters.WalletTableAdapter();

                            driver.addAll(decimal.Parse(txtboxID.Text), txtboxName.Text, b, w, txtboxPass.Text);
                            bus.addAll(b,20,"Gaza",12);
                            wallet.addAll(w, decimal.Parse(txtboxID.Text),10);

                            signIn signin = new signIn();
                            this.Hide();
                            signin.ShowDialog();
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("ERROR while creating an account\n\n" + e1);
                        }
                    }
                    else {
                        MessageBox.Show("start your ID with\n100 for a student profile\nand 200 for a driver profile");
                    }
                }
                else {
                    MessageBox.Show("Enter all the informations");
                }
            }
            else {
                MessageBox.Show("You have to agree to the terms and conditions");
            }
        }

        private void btnCreateHover(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) {
                if (btnCreate.Location.X.Equals(127))
                    btnCreate.Location = new System.Drawing.Point(226, 719);
                else if (btnCreate.Location.X.Equals(226))
                    btnCreate.Location = new System.Drawing.Point(15, 719);
                else if (btnCreate.Location.X.Equals(15))
                    btnCreate.Location = new System.Drawing.Point(127, 719);
            }
            
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            signIn.isDarkMode = !signIn.isDarkMode;
            themeReload();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            signIn.isArabic = !signIn.isArabic;
            languageReload();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Give us a full mark");
        }

        private void txtIDClick(object sender, EventArgs e)
        {
            if (!firstTime)
            {
                MessageBox.Show("start your ID with\n100 for a student profile\nand 200 for a driver profile");
                firstTime = true;
            }
        }

        private void linklblCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signIn signin = new signIn();
            this.Hide();
            signin.ShowDialog();
        }
    }
}
