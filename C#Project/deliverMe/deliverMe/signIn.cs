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
    public partial class signIn : Form
    {
        public static Boolean isArabic = false;
        public static Boolean isDarkMode = false;
        public static decimal userID;

        public static studentForm sf = new studentForm();
        public static driverForm df = new driverForm();
        public static adminForm af = new adminForm();
        
        public signIn()
        {
            InitializeComponent();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            themeReload();
        }

        private void themeReload() {
            if (isDarkMode)
            {
                picboxTitle.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\titleDarkMode.jpg");
                btnTheme.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\sun.png");

                this.BackColor = Color.Black;
                btnLanguage.BackColor = Color.Black;
                btnLanguage.ForeColor = Color.White;
                btnTheme.BackColor = Color.Black;
                btnSignin.BackColor = Color.Black;
                btnSignin.ForeColor = Color.White;

                lblor.ForeColor = Color.White;
                lblSignin.ForeColor = Color.White;
                lblID.ForeColor = Color.White;
                lblPass.ForeColor = Color.White;
            }
            else {
                picboxTitle.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\titleLightMode.jpg");
                btnTheme.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\moon.png");

                this.BackColor = Color.White;
                btnLanguage.BackColor = Color.White;
                btnLanguage.ForeColor = Color.Black;
                btnTheme.BackColor = Color.White;
                btnSignin.BackColor = Color.White;
                btnSignin.ForeColor = Color.Black;

                lblor.ForeColor = Color.Black;
                lblSignin.ForeColor = Color.Black;
                lblID.ForeColor = Color.Black;
                lblPass.ForeColor = Color.Black;
            }
        }

        private void languageReload() {
            if (isArabic)
            {
                btnLanguage.Text = "E";

                lblSignin.Text = "تسجيل الدخول";
                lblSignin.Location = new System.Drawing.Point(133, 342);

                lblor.Text = "او";
                lblor.Location = new System.Drawing.Point(316, 388);

                linklblCreate.Text = "انشاء حساب جديد";
                linklblCreate.Location = new System.Drawing.Point(231,388);

                lblID.Text = "ادخل رقمك الجامعي";
                lblID.Location = new System.Drawing.Point(197, 438);

                lblPass.Text = "ادخل كلمة السر";
                lblPass.Location = new System.Drawing.Point(227, 524);

                btnSignin.Text = "تسجيل الدخول";

            }
            else {
                btnLanguage.Text = "ع";

                lblSignin.Text = "Sign in";
                lblSignin.Location = new System.Drawing.Point(4, 342);

                lblor.Text = "or";
                lblor.Location = new System.Drawing.Point(14, 388);

                linklblCreate.Text = "Create an account";
                linklblCreate.Location = new System.Drawing.Point(27, 388);

                lblID.Text = "Enter Your ID";
                lblID.Location = new System.Drawing.Point(7, 438);

                lblPass.Text = "Enter Your Password";
                lblPass.Location = new System.Drawing.Point(7, 524);

                btnSignin.Text = "Sign in";

            }
        }

        private void signIn_Load(object sender, EventArgs e)
        {
            themeReload();
            languageReload();
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            isArabic = !isArabic;
            languageReload();
        }

        private void linklblCreate_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUp signup = new signUp();
            this.Hide();
            signup.ShowDialog();
        }

        private void closeApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtboxID.Text != "" && txtboxPass.Text != "")
            {
                if (txtboxID.Text.Substring(0, 3) == "100")
                {
                    try
                    {
                        _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
                        _C_ProjectDataSet.StudentDataTable studentInfo = student.GetDataBy11(decimal.Parse(txtboxID.Text), txtboxPass.Text);

                        if (studentInfo.Rows.Count == 1)
                        {
                            userID = decimal.Parse(txtboxID.Text);
                            
                            this.Hide();
                            sf.ShowDialog();
                        }
                        else
                            MessageBox.Show("Wrong ID and Password");
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("ERROR while Signing in\n\n" + e1);
                    }
                }
                else if (txtboxID.Text.Substring(0, 3) == "200")
                {
                    try
                    {
                        _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
                        _C_ProjectDataSet.DriversDataTable driverInfo = driver.GetDataBy11(decimal.Parse(txtboxID.Text), txtboxPass.Text);

                        if (driverInfo.Rows.Count == 1) {
                            userID = decimal.Parse(txtboxID.Text);

                            this.Hide();
                            df.ShowDialog();
                        } else
                            MessageBox.Show("Wrong ID and Password");
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("ERROR while Signing in\n\n" + e1);
                    }
                }
                else if (txtboxID.Text.Substring(0, 3) == "300") {
                    try
                    {
                        _C_ProjectDataSetTableAdapters.AdministratorTableAdapter admin = new _C_ProjectDataSetTableAdapters.AdministratorTableAdapter();
                        _C_ProjectDataSet.AdministratorDataTable adminInfo = admin.GetDataBy1(decimal.Parse(txtboxID.Text), txtboxPass.Text);

                        if (adminInfo.Rows.Count == 1)
                        {
                            userID = decimal.Parse(txtboxID.Text);

                            this.Hide();
                            af.ShowDialog();
                        }
                        else
                            MessageBox.Show("Wrong ID and Password");
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("ERROR while Signing in\n\n" + e1);
                    }
                }
                else
                {
                    MessageBox.Show("start your ID with\n100 for a student profile\nand 200 for a driver profile");
                }
            }
            else
            {
                MessageBox.Show("Enter all the informations");
            }
        }
    }
}
