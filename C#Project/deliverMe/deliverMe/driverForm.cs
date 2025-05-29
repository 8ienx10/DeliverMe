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
    public partial class driverForm : Form
    {
        private static Boolean isnoTrips = false;
        
        public driverForm()
        {
            InitializeComponent();
        }

        private void closeApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            signIn signin = new signIn();
            this.Hide();
            signin.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupdateForm su = new SupdateForm();
            su.ShowDialog();

            _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
            lblName.Text = driver.getName(signIn.userID);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void driverForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            themeReload();
            languageReload();

            _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
            _C_ProjectDataSetTableAdapters.BusTableAdapter bus = new _C_ProjectDataSetTableAdapters.BusTableAdapter();

            lblName.Text = driver.getName(signIn.userID);
            lblBus1.Text = bus.getBSeats(Convert.ToDecimal(driver.getBID(signIn.userID))).ToString();
            lblBus1ID.Text = Convert.ToDecimal(driver.getBID(signIn.userID)).ToString();
            label1.Text = bus.getBDestination(Convert.ToDecimal(driver.getBID(signIn.userID)));

            _C_ProjectDataSetTableAdapters.WalletTableAdapter wallet = new _C_ProjectDataSetTableAdapters.WalletTableAdapter();
            label6.Text = wallet.getMoney(Convert.ToDecimal(driver.getWalletID(signIn.userID))).ToString();

            double time1 = Convert.ToDouble(bus.getTime(Convert.ToDecimal(driver.getBID(signIn.userID))));
            int hours1 = (int)time1;
            int minutes1 = (int)Math.Round((time1 - hours1) * 100);
            label11.Text = hours1 + ":" + minutes1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
            _C_ProjectDataSetTableAdapters.BusTableAdapter bus = new _C_ProjectDataSetTableAdapters.BusTableAdapter();

            bus.deleteTrip(Convert.ToDecimal(driver.getBID(signIn.userID)));

            label11.Visible = false;
            lblBus1ID.Visible = false;
            lblBus1.Visible = false;
            label8.Visible = false;
            label1.Visible = false;

            button1.Visible = false;

            isnoTrips = true;
            noTrips();

        }

        private void noTrips() {
            if (isnoTrips) {
                if (signIn.isArabic)
                {
                    label3.Text = "لا رحلات اليوم";
                    label3.Location = new System.Drawing.Point(100, 274);
                }
                else
                {
                    label3.Text = "you have No trips for today";
                    label3.Location = new System.Drawing.Point(3, 274);
                }

                label3.ForeColor = Color.Red;
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

        private void themeReload() {
            if (signIn.isDarkMode)
            {
                btnTheme.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\sun.png");
                this.BackColor = Color.Black;
                btnLanguage.BackColor = Color.Black;
                btnLanguage.ForeColor = Color.White;
                btnTheme.BackColor = Color.Black;

                lblWelcome.ForeColor = Color.White;
                lblName.ForeColor = Color.White;

                lblBus1.ForeColor = Color.White;
                lblBus1ID.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label1.ForeColor = Color.White;

                panel1.BackColor = Color.Black;

                label7.ForeColor = Color.White;

                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;
                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;
                btnSignin.BackColor = Color.Black;
                btnSignin.ForeColor = Color.White;

                if (isnoTrips)
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.White;
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

                lblBus1.ForeColor = Color.Black;
                lblBus1ID.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;

                panel1.BackColor = Color.White;

                label7.ForeColor = Color.Black;

                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                btnSignin.BackColor = Color.White;
                btnSignin.ForeColor = Color.Black;

                if (isnoTrips)
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.Black;
            }
        }

        private void languageReload() {
            if (signIn.isArabic)
            {
                btnLanguage.Text = "E";

                button1.Text = "الغاء الرحلة";

                button3.Text = "تحديث معلوماتي";
                btnSignin.Text = "تسجيل الخروج";

                lblWelcome.Text = "مرحبا";
                lblWelcome.Location = new System.Drawing.Point(196, 1);

                lblName.Location = new System.Drawing.Point(12, 1);
            }
            else
            {
                btnLanguage.Text = "ع";

                button1.Text = "Cancel Trip";

                button3.Text = "Update account information";
                btnSignin.Text = "Sign out";

                lblWelcome.Text = "Hello";
                lblWelcome.Location = new System.Drawing.Point(-3, 1);

                lblName.Location = new System.Drawing.Point(70, 1);
            }

            noTrips();
        }
    }
}
