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
    public partial class Reserve1 : Form
    {
        public Reserve1()
        {
            InitializeComponent();
        }

        private void Reserve1_Load(object sender, EventArgs e)
        {
            label3.Text = studentForm.busID;
            label4.Text = signIn.userID.ToString();

            _C_ProjectDataSetTableAdapters.BusTableAdapter bus = new _C_ProjectDataSetTableAdapters.BusTableAdapter();

            label5.Text = bus.getBSeats(Convert.ToDecimal(studentForm.busID)).ToString();
            label8.Text = bus.getBDestination(Convert.ToDecimal(studentForm.busID)).ToString();

            double time = Convert.ToDouble(bus.getTime(Convert.ToDecimal(studentForm.busID)));
            int hours = (int)time;
            int minutes = (int)Math.Round((time - hours) * 100);
            label7.Text = hours + ":" + minutes;
        }
    }
}
