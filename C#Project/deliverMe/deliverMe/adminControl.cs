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
    public partial class adminControl : Form
    {
        public adminControl()
        {
            InitializeComponent();
        }

        private void adminControl_Load(object sender, EventArgs e)
        {
            themeReload();

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            
            
            try
            {
                switch (adminForm.tableNum)
                {
                    case 1:
                        this.studentTableAdapter.Fill(this._C_ProjectDataSet.Student);
                        dataGridView1.DataSource = _C_ProjectDataSet.Student;

                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;

                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        textBox6.Visible = true;

                        break;

                    case 2:
                        this.driversTableAdapter.Fill(this._C_ProjectDataSet.Drivers);
                        dataGridView1.DataSource = _C_ProjectDataSet.Drivers;

                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label7.Visible = true;

                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        textBox4.Visible = true;
                        textBox5.Visible = true;

                        label3.Text = "Bus ID";
                        label4.Text = "Wallet ID";
                        label5.Text = "Password";
                        label7.Text = "**ID,Bus ID and WalletID are required to Add";

                        break;

                    case 3:
                        this.busTableAdapter.Fill(this._C_ProjectDataSet.Bus);
                        dataGridView1.DataSource = _C_ProjectDataSet.Bus;

                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label7.Visible = true;

                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        textBox4.Visible = true;

                        label1.Text = "Bus ID";
                        label2.Text = "Bus Seats";
                        label3.Text = "Bus Destination";
                        label4.Text = "Time";
                        label7.Text = "**BID,BSeats and Time are required to Add ";

                        break;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("ERROR\n\n" + e1);
            }

        }

        private void themeReload() {
            if (signIn.isDarkMode)
            {
                this.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;

                btnAdd.BackColor = Color.Black;
                btnAdd.ForeColor = Color.White;

                btnUpdate.BackColor = Color.Black;
                btnUpdate.ForeColor = Color.White;

                btnDelete.BackColor = Color.Black;
                btnDelete.ForeColor = Color.White;
            }
            else {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;

                btnAdd.BackColor = Color.White;
                btnAdd.ForeColor = Color.Black;

                btnUpdate.BackColor = Color.White;
                btnUpdate.ForeColor = Color.Black;

                btnDelete.BackColor = Color.White;
                btnDelete.ForeColor = Color.Black;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
            _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
            _C_ProjectDataSetTableAdapters.BusTableAdapter bus = new _C_ProjectDataSetTableAdapters.BusTableAdapter();

            try
            {
                switch (adminForm.tableNum) {
                    case 1:
                        student.deleteAccount(Convert.ToDecimal(textBox1.Text));
                        this.studentTableAdapter.Fill(this._C_ProjectDataSet.Student);
                        break;
                    case 2:
                        driver.deleteProfile(Convert.ToDecimal(textBox1.Text));
                        this.driversTableAdapter.Fill(this._C_ProjectDataSet.Drivers);
                        break;
                    case 3:
                        bus.deleteTrip(Convert.ToDecimal(textBox1.Text));
                        this.busTableAdapter.Fill(this._C_ProjectDataSet.Bus);
                        break;
                }
            }
            catch (Exception e1) {
                MessageBox.Show("ERROR in deleting\n\n" + e1);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
            _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
            _C_ProjectDataSetTableAdapters.BusTableAdapter bus = new _C_ProjectDataSetTableAdapters.BusTableAdapter();

            try
            {
                switch (adminForm.tableNum)
                {
                    case 1:
                        if (textBox2.Text != "")
                            student.updateName(textBox2.Text, Convert.ToDecimal(textBox1.Text));
                        if (textBox3.Text != "")
                            student.updateSex(textBox3.Text, Convert.ToDecimal(textBox1.Text));
                        if (textBox4.Text != "")
                            student.updateSHome(textBox4.Text, Convert.ToDecimal(textBox1.Text));
                        if (textBox5.Text != "")
                            student.updateWalletID(Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox1.Text));
                        if (textBox6.Text != "")
                            student.updatePass(textBox5.Text, Convert.ToDecimal(textBox1.Text));

                        this.studentTableAdapter.Fill(this._C_ProjectDataSet.Student);
                        break;

                    case 2:
                        if (textBox2.Text != "")
                            driver.updateName(textBox2.Text, Convert.ToDecimal(textBox1.Text));
                        if (textBox3.Text != "")
                            driver.updateBID(Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox1.Text));
                        if (textBox4.Text != "")
                            driver.updateWalletID(Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox1.Text));
                        if (textBox5.Text != "")
                            driver.updatePass(textBox5.Text, Convert.ToDecimal(textBox1.Text));

                        this.driversTableAdapter.Fill(this._C_ProjectDataSet.Drivers);
                        break;

                    case 3:
                        if (textBox2.Text != "")
                            bus.updateBSeats(Convert.ToDecimal(textBox2.Text), Convert.ToDecimal(textBox1.Text));
                        if (textBox3.Text != "")
                            bus.updateBDestination(textBox3.Text, Convert.ToDecimal(textBox1.Text));
                        if (textBox4.Text != "")
                            bus.updateTime(Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox1.Text));

                        this.busTableAdapter.Fill(this._C_ProjectDataSet.Bus);
                        break;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("ERROR in updating\n\n" + e1);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _C_ProjectDataSetTableAdapters.StudentTableAdapter student = new _C_ProjectDataSetTableAdapters.StudentTableAdapter();
            _C_ProjectDataSetTableAdapters.DriversTableAdapter driver = new _C_ProjectDataSetTableAdapters.DriversTableAdapter();
            _C_ProjectDataSetTableAdapters.BusTableAdapter bus = new _C_ProjectDataSetTableAdapters.BusTableAdapter();
            
            try
            {
                switch (adminForm.tableNum)
                {
                    case 1: 
                        student.addAll(
                            Convert.ToDecimal(textBox1.Text), 
                            textBox2.Text,                    
                            textBox3.Text,                    
                            textBox4.Text,                    
                            Convert.ToDecimal(textBox5.Text), 
                            textBox6.Text  
                        );
                        this.studentTableAdapter.Fill(this._C_ProjectDataSet.Student);
                        break;

                    case 2: 
                        driver.addAll(
                            Convert.ToDecimal(textBox1.Text), 
                            textBox2.Text,                    
                            Convert.ToDecimal(textBox3.Text), 
                            Convert.ToDecimal(textBox4.Text), 
                            textBox5.Text                     
                        );
                        this.driversTableAdapter.Fill(this._C_ProjectDataSet.Drivers);
                        break;

                    case 3: 
                        bus.addAll(
                            Convert.ToDecimal(textBox1.Text),
                            Convert.ToDecimal(textBox2.Text), 
                            textBox3.Text,                    
                            Convert.ToDecimal(textBox4.Text)
                        );
                        this.busTableAdapter.Fill(this._C_ProjectDataSet.Bus);
                        break;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("ERROR\n\n" + e1);
            }
        }
    }
}
