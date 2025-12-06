using managment.newwww;
using managment.riang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace managment.circalDisplay
{
    public partial class circalDisplay : Form
    {
        public circalDisplay()
        {
            InitializeComponent();
        }
        Memorization_Circles_ManagementEntities6 db = new Memorization_Circles_ManagementEntities6();

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            CircleForm cf = new CircleForm();
            cf.Show();
        }

        private void dataGridViewUserDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
            
        private void dataGridViewUserDisplay_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCircalDisplay.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridViewCircalDisplay.SelectedRows[0];
            Circles obj = new Circles();

            
            textBoxNameCircle.Text = row.Cells["CircleName"].Value.ToString();
            textBoxMosqCircle.Text = row.Cells["MosqueName"].Value.ToString();
            textBoxlivelCircle.Text = row.Cells["EducationalLevel"].Value.ToString();

        }

        private void dataGridViewCircalDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEdetCircal_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            // تحقق هل تم اختيار طالب
            if (dataGridViewCircalDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("اختر طالب للتعديل أولاً");
                return;
            }

            int id = Convert.ToInt32(
                dataGridViewCircalDisplay.SelectedRows[0].Cells["CircleID"].Value
            );

            var circles = db.Circles.Find(id);

            if (circles == null)
            {
                MessageBox.Show("لم يتم العثور على المستخدم ");
                return;
            }

            circles.CircleName = textBoxNameCircle.Text;
            circles.MosqueName = textBoxMosqCircle.Text;
            circles.EducationalLevel = textBoxlivelCircle.Text;




            db.SaveChanges();

            MessageBox.Show("تم تعديل بيانات المستخدم  بنجاح");
            textBoxNameCircle.Text = " ";
            textBoxMosqCircle.Text = " ";
            textBoxlivelCircle.Text = " ";


        }

        private void circalDisplay_Load(object sender, EventArgs e)
        {

        }
    }

        // تأكد أن القيمة غير فارغة قبل التحويل
        //if (row.Cells["UserType"].Value != null)
        //    comboBoxUser.Text = Convert.ToString(row.Cells["UserType"].Value);

        //comboBoxUser.SelectedValue = row.Cells["CircleID"].Value;


    }
}
