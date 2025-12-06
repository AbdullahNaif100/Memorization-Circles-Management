using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using managment.UserDisplay;
using managment.riang;
using managment.newwww;
using managment.circalDisplay;

using managment.tro;
using managment.student;
namespace managment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
            //this.Hide();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            circalDisplay cf = new circalDisplay();
            cf.Show();
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm af = new AttendanceForm();
            af.Show();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            //ReportForm rf = new ReportForm();
            //rf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
