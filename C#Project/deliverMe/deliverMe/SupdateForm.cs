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
    public partial class SupdateForm : Form
    {
        public SupdateForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SupdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
            _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
             _C_ProjectDataSetTableAdapters.AdministratorTableAdapter admin = new _C_ProjectDataSetTableAdapters.AdministratorTableAdapter();

            try
            {
                if (signIn.userID.ToString().Substring(0, 3) == "100") {
                    if (txtboxPass.Text != "")
                        student.updatePass(txtboxPass.Text, signIn.userID);
                    if (txtboxName.Text != "")
                        student.updateName(txtboxName.Text, signIn.userID);
                    if (comboBox1.Text != "")
                        student.updateSex(comboBox1.Text, signIn.userID);
                }
                else if (signIn.userID.ToString().Substring(0, 3) == "200") {
                    if (txtboxPass.Text != "")
                        driver.updatePass(txtboxPass.Text, signIn.userID);
                    if (txtboxName.Text != "")
                        driver.updateName(txtboxName.Text, signIn.userID);
                }
                else if (signIn.userID.ToString().Substring(0, 3) == "300")
                {
                    if (txtboxPass.Text != "")
                        admin.updatePass(txtboxPass.Text, signIn.userID);
                    if (txtboxName.Text != "")
                        admin.updateName(txtboxName.Text, signIn.userID);
                    if (comboBox1.Text != "")
                        admin.updateSex(comboBox1.Text, signIn.userID);
                }

                this.Hide();
            }
            catch (Exception e1)
            {
                MessageBox.Show("ERROR while updating\n\n" + e1);
            }
        }

        private void SupdateForm_Load(object sender, EventArgs e)
        {
            themeReload();
            languageReload();
        }

        private void themeReload() {
            if (signIn.isDarkMode)
            {
                this.BackColor = Color.Black;
                picboxTitle.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\titleDarkMode.jpg");

                lblSignup.ForeColor = Color.White;
                lblPass.ForeColor = Color.White;
                lblName.ForeColor = Color.White;
                label1.ForeColor = Color.White;

                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;

                btnCreate.BackColor = Color.Black;
                btnCreate.ForeColor = Color.White;

                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;
            }
            else {
                this.BackColor = Color.White;
                picboxTitle.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\titleLightMode.jpg");

                lblSignup.ForeColor = Color.Black;
                lblPass.ForeColor = Color.Black;
                lblName.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;

                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;

                btnCreate.BackColor = Color.White;
                btnCreate.ForeColor = Color.Black;

                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
            }
        }

        private void languageReload() {
            if (signIn.isArabic)
            {
                lblSignup.Text = "تحديث معلوماتي";
                lblSignup.Location = new System.Drawing.Point(112, 235);

                lblPass.Text = "كلمة السر الجديدة";
                lblPass.Location = new System.Drawing.Point(209, 356);

                lblName.Text = "الاسم الجديد";
                lblName.Location = new System.Drawing.Point(241, 442);

                label1.Text = "الجنس الجديد";
                label1.Location = new System.Drawing.Point(237, 528);

                button1.Text = "تحديث";
                btnCreate.Text = "الغاء";
                button2.Text = "حذف الحساب";
            }
            else {
                lblSignup.Text = "Update info";
                lblSignup.Location = new System.Drawing.Point(1, 244);

                lblPass.Text = "New Password";
                lblPass.Location = new System.Drawing.Point(7, 356);

                lblName.Text = "New Name";
                lblName.Location = new System.Drawing.Point(7, 442);

                label1.Text = "New Sex";
                label1.Location = new System.Drawing.Point(7, 528);

                button1.Text = "Update";
                btnCreate.Text = "Cancel";
                button2.Text = "Delete account";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
            _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
            _C_ProjectDataSetTableAdapters.AdministratorTableAdapter admin = new _C_ProjectDataSetTableAdapters.AdministratorTableAdapter();

            try
            {
                if (signIn.userID.ToString().Substring(0, 3) == "100")
                {
                    student.deleteAccount(signIn.userID);

                    signIn signin = new signIn();
                    signIn.sf.Hide();
                    this.Hide();
                    signin.ShowDialog();
                }
                else if (signIn.userID.ToString().Substring(0, 3) == "200")
                {
                    driver.deleteProfile(signIn.userID);

                    signIn signin = new signIn();
                    signIn.df.Hide();
                    this.Hide();
                    signin.ShowDialog();
                }
                else if (signIn.userID.ToString().Substring(0, 3) == "300")
                {
                    admin.deleteProfile(signIn.userID);

                    signIn signin = new signIn();
                    signIn.af.Hide();
                    this.Hide();
                    signin.ShowDialog();
                }
            }
            catch (Exception e1) {
                MessageBox.Show("ERROR while deleting the account\n\n" + e1);
            }
        }
    }
}
