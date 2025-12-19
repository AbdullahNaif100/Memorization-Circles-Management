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
            LoadAllcircal();

        }
        Memorization_Circles_ManagementEntities2 db = new Memorization_Circles_ManagementEntities2();

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            CircleForm cf = new CircleForm();
            cf.Show();
        }
        private void LoadAllcircal()
        {
            dataGridViewCircalDisplay.DataSource = db.Circles.ToList();
        }

        private void dataGridViewUserDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
            
        private void dataGridViewCircalDisplay_SelectionChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridViewCircalDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCircalDisplay.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridViewCircalDisplay.SelectedRows[0];

            textBoxNameCircle.Text = row.Cells["CircleName"].Value?.ToString();
            textBoxMosqCircle.Text = row.Cells["MosqueName"].Value?.ToString();
            textBoxlivelCircle.Text = row.Cells["EducationalLevel"].Value?.ToString();
            

        }

        private void buttonEdetCircal_Click(object sender, EventArgs e)
        {
            Circles obj = new Circles();
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

        private void buttonDeletCircal_Click(object sender, EventArgs e)
        {
            // تأكد أن المستخدم اختار صف
            if (dataGridViewCircalDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار مستخدم للحذف");
                return;
            }

            // جلب ID من الصف المحدد
            int id = Convert.ToInt32(dataGridViewCircalDisplay.SelectedRows[0].Cells["CircleID"].Value);

            // البحث عن المستخدم في قاعدة البيانات
            var circles = db.Circles.Find(id);


            if (circles != null)
            {
                // تأكيد الحذف
                DialogResult result = MessageBox.Show(
                    "هل أنت متأكد من حذف هذا المستخدم؟",
                    "تأكيد الحذف",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    db.Circles.Remove(circles);
                    db.SaveChanges();

                    MessageBox.Show("✅ تم حذف المستخدم بنجاح", id.ToString());

                    // تحديث القائمة
                    LoadAllcircal();
                }
            }
            else
            {
                MessageBox.Show("❌ لم يتم العثور على المستخدم");
            }
        }

        private void comboBoxMochrfCircle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

        // تأكد أن القيمة غير فارغة قبل التحويل
        //if (row.Cells["UserType"].Value != null)
        //    comboBoxUser.Text = Convert.ToString(row.Cells["UserType"].Value);

        //comboBoxUser.SelectedValue = row.Cells["CircleID"].Value;


    }

