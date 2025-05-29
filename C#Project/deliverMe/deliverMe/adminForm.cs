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
    public partial class adminForm : Form
    {

        public static int tableNum = 0;
        
        public adminForm()
        {
            InitializeComponent();
        }

        private void closeApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SupdateForm su = new SupdateForm();
            su.ShowDialog();

            _C_ProjectDataSetTableAdapters.AdministratorTableAdapter admin = new _C_ProjectDataSetTableAdapters.AdministratorTableAdapter();
            lblName.Text = admin.getName(signIn.userID);
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            _C_ProjectDataSetTableAdapters.AdministratorTableAdapter admin = new _C_ProjectDataSetTableAdapters.AdministratorTableAdapter();
            lblName.Text = admin.getName(signIn.userID);

            _C_ProjectDataSetTableAdapters.WalletTableAdapter wallet = new _C_ProjectDataSetTableAdapters.WalletTableAdapter();
            label6.Text = wallet.getMoney(Convert.ToDecimal(admin.getWalletID(signIn.userID))).ToString();

            if (admin.getSex(signIn.userID) == "Male")
                pictureBox1.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\boyProfile.png");
            else
                pictureBox1.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\girlProfile.jpg");

            panel1.Visible = !panel1.Visible;
            themeReload();
            languageReload();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            signIn signin = new signIn();
            this.Hide();
            signin.ShowDialog();
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

        private void themeReload()
        {
            if (signIn.isDarkMode)
            {
                btnTheme.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\sun.png");
                this.BackColor = Color.Black;
                btnLanguage.BackColor = Color.Black;
                btnLanguage.ForeColor = Color.White;
                btnTheme.BackColor = Color.Black;

                lblWelcome.ForeColor = Color.White;
                lblName.ForeColor = Color.White;

                panel1.BackColor = Color.Black;

                label7.ForeColor = Color.White;

                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;
                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;
                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;
                button7.BackColor = Color.Black;
                button7.ForeColor = Color.White;
                btnSignin.BackColor = Color.Black;
                btnSignin.ForeColor = Color.White;
            }
            else
            {
                btnTheme.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\moon.png");
                this.BackColor = Color.White;
                btnLanguage.BackColor = Color.White;
                btnLanguage.ForeColor = Color.Black;
                btnTheme.BackColor = Color.White;

                lblWelcome.ForeColor = Color.Black;
                lblName.ForeColor = Color.Black;

         

                panel1.BackColor = Color.White;

                label7.ForeColor = Color.Black;

                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                button7.BackColor = Color.White;
                button7.ForeColor = Color.Black;
                btnSignin.BackColor = Color.White;
                btnSignin.ForeColor = Color.Black;
            }
        }

        private void languageReload()
        {
            if (signIn.isArabic)
            {
                btnLanguage.Text = "E";

                button1.Text = "جدول الطلبة";
                button2.Text = "جدول السائقين";
                button3.Text = "جدول الحافلات";

                button7.Text = "تحديث معلوماتي";
                btnSignin.Text = "تسجيل الخروج";

                lblWelcome.Text = "مرحبا";
                lblWelcome.Location = new System.Drawing.Point(196, 1);

                lblName.Location = new System.Drawing.Point(12, 1);
            }
            else
            {
                btnLanguage.Text = "ع";

                button1.Text = "Student Table";
                button2.Text = "Driver Table";
                button3.Text = "Bus Table";

                button7.Text = "Update account information";
                btnSignin.Text = "Sign out";

                lblWelcome.Text = "Hello";
                lblWelcome.Location = new System.Drawing.Point(-3, 1);

                lblName.Location = new System.Drawing.Point(70, 1);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tableNum = 1;
            adminControl ac = new adminControl();
            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableNum = 2;
            adminControl ac = new adminControl();
            ac.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableNum = 3;
            adminControl ac = new adminControl();
            ac.ShowDialog();
        }
    }
}
