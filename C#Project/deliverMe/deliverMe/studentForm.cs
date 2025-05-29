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
    public partial class studentForm : Form
    {
        Reserve1 reserve1 = new Reserve1();
        Reserve1 reserve2 = new Reserve1();
        Reserve1 reserve3 = new Reserve1();

        int numOfReserves = 0;
        string busNum1;
        string busNum2;
        string busNum3;
        Boolean firstTime = true;

        public static string busID;

        public studentForm()
        {
            InitializeComponent();
        }

        private void closeApp(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void studentForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            themeReload();
            languageReload();

            _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();

            if (student.GetSex(signIn.userID) == "Male")
                pictureBox1.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\boyProfile.png");
            else
                pictureBox1.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\girlProfile.jpg");

            lblName.Text = student.getName(signIn.userID);
            comboBox1.Text = student.getSHome(signIn.userID);


            lblBus1.Visible = false;
            label3.Visible = false;
            lblBus1ID.Visible = false;
            btnBus1.Visible = false;
            label8.Visible = false;
            label11.Visible = false;

            lblBus2.Visible = false;
            label4.Visible = false;
            lblBus2ID.Visible = false;
            btnBus2.Visible = false;
            label9.Visible = false;
            label12.Visible = false;

            lblBus3.Visible = false;
            label5.Visible = false;
            label1.Visible = false;
            btnBus3.Visible = false;
            label10.Visible = false;
            label13.Visible = false;

            button5.Visible = false;
            button2.Visible = false;
            button1.Visible = false;

            _C_ProjectDataSetTableAdapters.WalletTableAdapter wallet = new _C_ProjectDataSetTableAdapters.WalletTableAdapter();
            label6.Text = wallet.getMoney(Convert.ToDecimal(student.getWalletID(signIn.userID))).ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
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

        private void languageReload()
        {
            if (signIn.isArabic)
            {
                btnLanguage.Text = "E";
                
                button5.Text = "الحجز الاول";
                button2.Text = "الحجز الثاني";
                button1.Text = "الحجز الثالث";

                button3.Text = "تحديث معلوماتي";
                btnSignin.Text = "تسجيل الخروج";

                btnBus1.Text = "حجز";
                btnBus2.Text = "حجز";
                btnBus3.Text = "حجز";

                button4.Text = "حجوزاتي";

                lblID.Text = "الى اين تود الذهاب";
                lblID.Location = new System.Drawing.Point(205, 129);

                lblWelcome.Text = "مرحبا";
                lblWelcome.Location = new System.Drawing.Point(196, 1);

                lblName.Location = new System.Drawing.Point(12, 1);
            }
            else
            {
                btnLanguage.Text = "ع";

                button5.Text = "Show Reservation 1";
                button2.Text = "Show Reservation 2";
                button1.Text = "Show Reservation 3";

                button3.Text = "Update account information";
                btnSignin.Text = "Sign out";

                btnBus1.Text = "Reserve";
                btnBus2.Text = "Reserve";
                btnBus3.Text = "Reserve";

                button4.Text = "My reservetions";

                lblID.Text = "Where you want to go";
                lblID.Location = new System.Drawing.Point(7, 129);

                lblWelcome.Text = "Hello";
                lblWelcome.Location = new System.Drawing.Point(-3, 1);

                lblName.Location = new System.Drawing.Point(70, 1);
            }
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
                lblID.ForeColor = Color.White;

                lblBus1.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                lblBus1ID.ForeColor = Color.White;
                btnBus1.BackColor = Color.Black;
                btnBus1.ForeColor = Color.White;
                label11.ForeColor = Color.White;

                lblBus2.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                lblBus2ID.ForeColor = Color.White;
                btnBus2.BackColor = Color.Black;
                btnBus2.ForeColor = Color.White;
                label12.ForeColor = Color.White;

                lblBus3.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                btnBus3.BackColor = Color.Black;
                btnBus3.ForeColor = Color.White;
                label13.ForeColor = Color.White;

                button4.BackColor = Color.Black;
                button4.ForeColor = Color.White;

                panel1.BackColor = Color.Black;

                label7.ForeColor = Color.White;

                button1.BackColor = Color.Black;
                button1.ForeColor = Color.White;
                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;
                button5.BackColor = Color.Black;
                button5.ForeColor = Color.White;
                button3.BackColor = Color.Black;
                button3.ForeColor = Color.White;
                btnSignin.BackColor = Color.Black;
                btnSignin.ForeColor = Color.White;
            }
            else {
                btnTheme.Image = Image.FromFile(@"C:\Users\qusay\Desktop\C#Project\moon.png");
                this.BackColor = Color.White;
                btnLanguage.BackColor = Color.White;
                btnLanguage.ForeColor = Color.Black;
                btnTheme.BackColor = Color.White;

                lblWelcome.ForeColor = Color.Black;
                lblName.ForeColor = Color.Black;
                lblID.ForeColor = Color.Black;

                lblBus1.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                lblBus1ID.ForeColor = Color.Black;
                btnBus1.BackColor = Color.White;
                btnBus1.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;

                lblBus2.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                lblBus2ID.ForeColor = Color.Black;
                btnBus2.BackColor = Color.White;
                btnBus2.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;

                lblBus3.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                btnBus3.BackColor = Color.White;
                btnBus3.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;

                button4.BackColor = Color.White;
                button4.ForeColor = Color.Black;

                panel1.BackColor = Color.White;

                label7.ForeColor = Color.Black;

                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
                button5.BackColor = Color.White;
                button5.ForeColor = Color.Black;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Black;
                btnSignin.BackColor = Color.White;
                btnSignin.ForeColor = Color.Black;
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            signIn signin = new signIn();
            this.Hide();
            signin.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
            
            if (!firstTime)
            {
                lblBus1.Visible = false;
                label3.Visible = false;
                lblBus1ID.Visible = false;
                btnBus1.Visible = false;
                label8.Visible = false;
                label11.Visible = false;

                lblBus2.Visible = false;
                label4.Visible = false;
                lblBus2ID.Visible = false;
                btnBus2.Visible = false;
                label9.Visible = false;
                label12.Visible = false;

                lblBus3.Visible = false;
                label5.Visible = false;
                label1.Visible = false;
                btnBus3.Visible = false;
                label10.Visible = false;
                label13.Visible = false;

                _C_ProjectDataSetTableAdapters.BusTableAdapter bus = new _C_ProjectDataSetTableAdapters.BusTableAdapter();
                _C_ProjectDataSet.BusDataTable busInfo = bus.GetDataBy11(comboBox1.Text);

                switch (busInfo.Rows.Count)
                {
                    case 0:
                        MessageBox.Show("No Buses right now");
                        break;
                    case 1:

                        lblBus1.Text = bus.getBSeats(Convert.ToDecimal(busInfo[0]["BID"])).ToString();
                        lblBus1ID.Text = busInfo[0]["BID"].ToString();

                        double time1 = Convert.ToDouble(bus.getTime(Convert.ToDecimal(busInfo[0]["BID"])));
                        int hours1 = (int)time1;
                        int minutes1 = (int)Math.Round((time1 - hours1) * 100);
                        label11.Text = hours1 + ":" + minutes1;

                        lblBus1.Visible = true;
                        label3.Visible = true;
                        lblBus1ID.Visible = true;
                        btnBus1.Visible = true;
                        label8.Visible = true;
                        label11.Visible = true;

                        break;
                    case 2:

                        lblBus1.Text = bus.getBSeats(Convert.ToDecimal(busInfo[0]["BID"])).ToString();
                        lblBus1ID.Text = busInfo[0]["BID"].ToString();

                        lblBus2.Text = bus.getBSeats(Convert.ToDecimal(busInfo[1]["BID"])).ToString();
                        lblBus2ID.Text = busInfo[1]["BID"].ToString();

                        double time2 = Convert.ToDouble(bus.getTime(Convert.ToDecimal(busInfo[0]["BID"])));
                        int hours2 = (int)time2;
                        int minutes2 = (int)Math.Round((time2 - hours2) * 100);
                        label12.Text = hours2 + ":" + minutes2;

                        double time3 = Convert.ToDouble(bus.getTime(Convert.ToDecimal(busInfo[0]["BID"])));
                        int hours3 = (int)time3;
                        int minutes3 = (int)Math.Round((time3 - hours3) * 100);
                        label13.Text = hours3 + ":" + minutes3;

                        lblBus1.Visible = true;
                        label3.Visible = true;
                        lblBus1ID.Visible = true;
                        btnBus1.Visible = true;
                        label8.Visible = true;
                        label11.Visible = true;

                        lblBus2.Visible = true;
                        label4.Visible = true;
                        lblBus2ID.Visible = true;
                        btnBus2.Visible = true;
                        label9.Visible = true;
                        label12.Visible = true;

                        break;
                    case 3:

                        lblBus1.Text = bus.getBSeats(Convert.ToDecimal(busInfo[0]["BID"])).ToString();
                        lblBus1ID.Text = busInfo[0]["BID"].ToString();

                        lblBus2.Text = bus.getBSeats(Convert.ToDecimal(busInfo[1]["BID"])).ToString();
                        lblBus2ID.Text = busInfo[1]["BID"].ToString();

                        lblBus3.Text = bus.getBSeats(Convert.ToDecimal(busInfo[2]["BID"])).ToString();
                        label1.Text = busInfo[2]["BID"].ToString();

                        double time4 = Convert.ToDouble(bus.getTime(Convert.ToDecimal(busInfo[0]["BID"])));
                        int hours4 = (int)time4;
                        int minutes4 = (int)Math.Round((time4 - hours4) * 100);
                        label11.Text = hours4 + ":" + minutes4;

                        double time5 = Convert.ToDouble(bus.getTime(Convert.ToDecimal(busInfo[0]["BID"])));
                        int hours5 = (int)time5;
                        int minutes5 = (int)Math.Round((time5 - hours5) * 100);
                        label12.Text = hours5 + ":" + minutes5;

                        double time6 = Convert.ToDouble(bus.getTime(Convert.ToDecimal(busInfo[0]["BID"])));
                        int hours6 = (int)time6;
                        int minutes6 = (int)Math.Round((time6 - hours6) * 100);
                        label13.Text = hours6 + ":" + minutes6;

                        lblBus1.Visible = true;
                        label3.Visible = true;
                        lblBus1ID.Visible = true;
                        btnBus1.Visible = true;
                        label8.Visible = true;
                        label11.Visible = true;

                        lblBus2.Visible = true;
                        label4.Visible = true;
                        lblBus2ID.Visible = true;
                        btnBus2.Visible = true;
                        label9.Visible = true;
                        label12.Visible = true;

                        lblBus3.Visible = true;
                        label5.Visible = true;
                        label1.Visible = true;
                        btnBus3.Visible = true;
                        label10.Visible = true;
                        label13.Visible = true;

                        break;
                }
            }
            else
                firstTime = false;
        }

        private void btnBus1_Click(object sender, EventArgs e)
        {
            if (numOfReserves != 3)
            {
                switch (numOfReserves)
                {
                    case 0:
                        busNum1 = lblBus1ID.Text;
                        busID = busNum1;
                        break;
                    case 1:
                        busNum2 = lblBus1ID.Text;
                        busID = busNum2;
                        break;
                    case 2:
                        busNum3 = lblBus1ID.Text;
                        busID = busNum3;
                        break;
                }

                _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
                _C_ProjectDataSetTableAdapters.WalletTableAdapter wallet = new _C_ProjectDataSetTableAdapters.WalletTableAdapter();
                wallet.updateMoney((Convert.ToDecimal(wallet.getMoney(Convert.ToDecimal(student.getWalletID(signIn.userID)))) - 0.35m),Convert.ToDecimal(student.getWalletID(signIn.userID)));
                label6.Text = wallet.getMoney(Convert.ToDecimal(student.getWalletID(signIn.userID))).ToString();

                numOfReserves++;
                reserve1.ShowDialog();
            }
            else
                MessageBox.Show("you cant reserve more than 3 in a day");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;

            button5.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void btnBus2_Click(object sender, EventArgs e)
        {
            if (numOfReserves != 3)
            {
                switch (numOfReserves)
                {
                    case 0:
                        busNum1 = lblBus2ID.Text;
                        busID = busNum1;
                        break;
                    case 1:
                        busNum2 = lblBus2ID.Text;
                        busID = busNum2;
                        break;
                    case 2:
                        busNum3 = lblBus2ID.Text;
                        busID = busNum3;
                        break;
                }

                _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
                _C_ProjectDataSetTableAdapters.WalletTableAdapter wallet = new _C_ProjectDataSetTableAdapters.WalletTableAdapter();
                wallet.updateMoney((Convert.ToDecimal(wallet.getMoney(Convert.ToDecimal(student.getWalletID(signIn.userID)))) - 0.35m), Convert.ToDecimal(student.getWalletID(signIn.userID)));
                label6.Text = wallet.getMoney(Convert.ToDecimal(student.getWalletID(signIn.userID))).ToString();

                numOfReserves++;
                reserve2.ShowDialog();
            }
            else
                MessageBox.Show("you cant reserve more than 3 in a day");
        }

        private void btnBus3_Click(object sender, EventArgs e)
        {
            if (numOfReserves != 3)
            {
                switch (numOfReserves)
                {
                    case 0:
                        busNum1 = label1.Text;
                        busID = busNum1;
                        break;
                    case 1:
                        busNum2 = label1.Text;
                        busID = busNum2;
                        break;
                    case 2:
                        busNum3 = label1.Text;
                        busID = busNum3;
                        break;
                }

                _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
                _C_ProjectDataSetTableAdapters.WalletTableAdapter wallet = new _C_ProjectDataSetTableAdapters.WalletTableAdapter();
                wallet.updateMoney((Convert.ToDecimal(wallet.getMoney(Convert.ToDecimal(student.getWalletID(signIn.userID)))) - 0.35m), Convert.ToDecimal(student.getWalletID(signIn.userID)));

                
                numOfReserves++;
                reserve3.ShowDialog();
            }
            else
                MessageBox.Show("you cant reserve more than 3 in a day");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (numOfReserves) {
                case 0:
                    MessageBox.Show("You have no reservations");
                    break;
                case 1:
                    button5.Visible = true;

                    panel1.Visible = !panel1.Visible;
                    break;
                case 2:
                    button5.Visible = true;
                    button2.Visible = true;

                    panel1.Visible = !panel1.Visible;
                    break;
                case 3:
                    button5.Visible = true;
                    button2.Visible = true;
                    button1.Visible = true;

                    panel1.Visible = !panel1.Visible;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            busID = busNum1;
            reserve1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            busID = busNum2;
            reserve2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            busID = busNum3;
            reserve3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupdateForm su = new SupdateForm();
            su.ShowDialog();

            _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
            lblName.Text = student.getName(signIn.userID);
        }
    }
}
