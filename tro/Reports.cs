using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managment.tro
{
    public partial class AttendanceForm : Form
    {
        Memorization_Circles_ManagementEntities2 db = new Memorization_Circles_ManagementEntities2();

        public AttendanceForm()
        {
            InitializeComponent();
            LoadCircles();
            LoadAttendance();
            LoadReports();
        }
        private void LoadReports()
        {
            var query = db.MemorizationRecords
                          .Select(r => new
                          {
                              r.RecordID,
                              Student = r.Students.StudentName,
                              Circle = r.Circles.CircleName,
                              Date = r.SessionDate,
                              Time = r.SessionTime,
                              r.AttendanceStatus
                          })
                          .ToList();

            datdataGridViewReportsaGridView2.DataSource = query;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void الحضرو_والغياب_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datdataGridViewReportsaGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            

    }
        private void LoadCircles()
        {
            mboBoxCircle.DataSource = db.Circles.ToList();
            mboBoxCircle.DisplayMember = "CircleName";
            mboBoxCircle.ValueMember = "CircleID";
            mboBoxCircle.SelectedIndex = -1;
        }

        private void LoadAttendance()
        {
            comboBoxAttendance.Items.Clear();
            comboBoxAttendance.Items.Add("");
            comboBoxAttendance.Items.Add("حاضر");
            comboBoxAttendance.Items.Add("غائب");
        }


        private void mboBoxCircle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
         
           
        

    }

        private void mboBoxCircle_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void datdataGridViewReportsaGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var query = db.MemorizationRecords.AsQueryable();

            // فلترة الحلقة
            if (mboBoxCircle.SelectedItem != null)
            {
                Circles c = (Circles)mboBoxCircle.SelectedItem;
                query = query.Where(x => x.CircleID == c.CircleID);
            }

            // فلترة الحضور
            if (comboBoxAttendance.Text != "")
            {
                query = query.Where(x => x.AttendanceStatus == comboBoxAttendance.Text);
            }

            // فلترة التاريخ
            query = query.Where(x => x.SessionDate >= dateFrom.Value.Date &&
                                     x.SessionDate <= dateTo.Value.Date);

            // البحث بالاسم
            if (txtSearch.Text.Trim() != "")
            {
                string name = txtSearch.Text.Trim();
                query = query.Where(x => x.Students.StudentName.Contains(name));
            }

            var result = query.Select(r => new
            {
                r.RecordID,
                Student = r.Students.StudentName,
                Circle = r.Circles.CircleName,
                Date = r.SessionDate,
                Time = r.SessionTime,
                r.AttendanceStatus
            }).ToList();

            datdataGridViewReportsaGridView2.DataSource = result;

        }

        private void comboBoxAttendance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefres_Click_1(object sender, EventArgs e)
        {
            LoadReports();
        }
    }
}
