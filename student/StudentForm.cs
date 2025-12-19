using managment.newwww;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace managment.student
{
    public partial class StudentForm : Form
    {
        Memorization_Circles_ManagementEntities2 db = new Memorization_Circles_ManagementEntities2();

        public StudentForm()
        {
            InitializeComponent();
            
            LoadCircles();
            LoadCircles3();
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }


        // String EducationalLevel = null;
        private void buttonSaveDataStudent_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBoxNameStudent.Text == "")
                {
                    MessageBox.Show("اكتب اسم  الطالب");
                    return;
                }

                if (comboBoxCircal.SelectedValue == null)
                {
                    MessageBox.Show("اختر الحلقة");
                    return;
                }





                Students obj = new Students();

                obj.StudentName = textBoxNameStudent.Text;
                obj.addrass = textBoxAdrass.Text;
                obj.phone = textBoxPhone.Text;
                obj.GuardianPhone = textBoxNumberPhone.Text;
                obj.Nationality = comboNationality.Text;
                obj.EducationalLevel = comboBoxEducationalLevel.Text;
                //obj.CircleID = comboBoxCircal.Text;
                obj.BirthDate = dateTimeBrthday.Text;
                obj.CircleID = (int)comboBoxCircal.SelectedValue;






                db.Students.Add(obj);

                db.SaveChanges();


                //// 5. إظهار رسالة النجاح
                MessageBox.Show("تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxNameStudent.Text = " ";
                textBoxAdrass.Text = " ";
                textBoxPhone.Text = " ";
                textBoxNumberPhone.Text = " ";
                comboNationality.Text = " ذكر ";
                comboBoxEducationalLevel.Text = " اولي ";
                //comboBoxCircal.Text = " ";

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ:\n" + ex.Message);

            } }
       






        private void textBoxNumberPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdrass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNameStudent_TextChanged(object sender, EventArgs e)
        {

        }

       

        
        

        private void comboBoxCircal_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCircles();
            // تأكد أولاً أن هناك قيمة مختارة
            if (comboBoxCircal.SelectedValue == null)
                return;

            int circleID = Convert.ToInt32(comboBoxCircal.SelectedValue);

            // جلب جميع الطلاب من القاعدة
            var students = db.Students.ToList();

            // قائمة النتائج
            var result = new System.Collections.Generic.List<Students>();

            // فلترة الطلاب بحسب الحلقة
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].CircleID == circleID)
                {
                    result.Add(students[i]);
                }
            }

            // عرض النتائج
            dataGridViewStudent.DataSource = result;



        }
        private void LoadCircles()
        {
            var circles = db.Circles.ToList();

            comboBoxCircal.DataSource = circles;
            comboBoxCircal.DisplayMember = "CircleName";  // الاسم الظاهر
            comboBoxCircal.ValueMember = "CircleID";      // الرقم الحقيقي
            comboBoxCircal.SelectedIndex = -1;            // لا يوجد اختيار افتراضي
        }
        private void LoadCircles3()
        {
            var circles = db.Circles.ToList();

            comboBoxSelect.DataSource = circles;
            comboBoxSelect.DisplayMember = "CircleName";  // الاسم الظاهر
            comboBoxSelect.ValueMember = "CircleID";      // الرقم الحقيقي
            comboBoxSelect.SelectedIndex = -1;            // لا يوجد اختيار افتراضي
        }
        private void LoadStudents()
        {
            dataGridViewStudent.DataSource = db.Students.ToList();
        }
       

        private void Delete(object sender, EventArgs e)
        {
            // تأكد أن المستخدم اختار صف
            if (dataGridViewStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار مستخدم للحذف");
                return;
            }

            // جلب ID من الصف المحدد
            int id = Convert.ToInt32(dataGridViewStudent.SelectedRows[0].Cells["StudentID"].Value);

            // البحث عن المستخدم في قاعدة البيانات
            var student = db.Students.Find(id);


            if (student != null)
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
                    db.Students.Remove(student);
                    db.SaveChanges();

                    MessageBox.Show(" تم حذف المستخدم بنجاح");

                    // تحديث القائمة
                    LoadStudents();
                }
            }
            else
            {
                MessageBox.Show(" لم يتم العثور على المستخدم");
            }
        }

        private void AllStudent(object sender, EventArgs e)
        {
            LoadStudents();
        }

      


        private void StudentForm_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            Students obj = new Students();
            // تحقق هل تم اختيار طالب
            if (dataGridViewStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("اختر طالب للتعديل أولاً");
                return;
            }

            int id = Convert.ToInt32(
                dataGridViewStudent.SelectedRows[0].Cells["StudentID"].Value
            );

            var student = db.Students.Find(id);

            if (student == null)
            {
                MessageBox.Show("لم يتم العثور على الطالب");
                return;
            }

            student.StudentName = textBoxNameStudent.Text;
            student.addrass = textBoxAdrass.Text;
            student.phone = textBoxPhone.Text;
            student.GuardianPhone = textBoxNumberPhone.Text;
            student.Nationality = comboNationality.Text;
            student.EducationalLevel = comboBoxEducationalLevel.Text;
            student.BirthDate = dateTimeBrthday.Text; 

    if (comboBoxCircal.SelectedValue != null)
                student.CircleID = Convert.ToInt32(comboBoxCircal.SelectedValue);
            else
            {
                MessageBox.Show("اختر الحلقة أولاً");
                return;
            }

            db.SaveChanges();
            
            MessageBox.Show("تم تعديل بيانات الطالب بنجاح");
            textBoxNameStudent.Text = " ";
            textBoxAdrass.Text = " ";
            textBoxPhone.Text = " ";
            textBoxNumberPhone.Text = " ";
            comboNationality.Text = " ذكر ";
            comboBoxEducationalLevel.Text = " اولي ";
            //comboBoxCircal.Text = " ";
            LoadStudents();
        }

       

        private void serche_TextChanged(object sender, EventArgs e)
        {

            string name = serche.Text.Trim();

            if (name == "")
            {
                LoadStudents(); // رجوع لجميع الطلاب إذا مسح البحث
                return;
            }

            var result = db.Students
                           .Where(s => s.StudentName.Contains(name))
                           .ToList();

            dataGridViewStudent.DataSource = result;



        }

        private void comboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Add_Click(object sender, EventArgs e)
        {
            StudentForm cf = new StudentForm();
            cf.Show();
        }

        private void buttonSerchebyCircle_Click(object sender, EventArgs e)
        {

            var query = db.MemorizationRecords.AsQueryable();

            if (comboBoxCircal.SelectedItem != null)
            {
                Circles c = (Circles)comboBoxCircal.SelectedItem;

                query = query.Where(x => x.CircleID == c.CircleID);
            }

            var result = query.ToList();
            dataGridViewStudent.DataSource = result;

        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
       }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];

            textBoxNameStudent.Text = row.Cells["StudentName"].Value.ToString();
            textBoxAdrass.Text = row.Cells["addrass"].Value.ToString();
            textBoxPhone.Text = row.Cells["phone"].Value.ToString();
            textBoxNumberPhone.Text = row.Cells["GuardianPhone"].Value.ToString();
            comboNationality.Text = row.Cells["Nationality"].Value.ToString();
            comboBoxEducationalLevel.Text = row.Cells["EducationalLevel"].Value.ToString();

            dateTimeBrthday.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);

            comboBoxCircal.SelectedValue = row.Cells["CircleID"].Value;
        }

        private void dataGridViewStudent_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dataGridViewStudent.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridViewStudent.SelectedRows[0];

            textBoxNameStudent.Text = row.Cells["StudentName"].Value.ToString();
           textBoxAdrass.Text = row.Cells["addrass"].Value?.ToString();
            textBoxPhone.Text = row.Cells["phone"].Value?.ToString();
            textBoxNumberPhone.Text = row.Cells["GuardianPhone"].Value?.ToString();
            comboNationality.Text = row.Cells["Nationality"].Value?.ToString();
            comboBoxEducationalLevel.Text = row.Cells["EducationalLevel"].Value?.ToString();

            // تأكد أن القيمة غير فارغة قبل التحويل
            if (row.Cells["BirthDate"].Value != null)
                dateTimeBrthday.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);

         //   comboBoxCircal.SelectedValue = row.Cells["CircleID"].Value;
        

    }
}

}





