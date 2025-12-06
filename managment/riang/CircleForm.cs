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

namespace managment.riang
{
    public partial class CircleForm : Form
    {
        Memorization_Circles_ManagementEntities6   db = new Memorization_Circles_ManagementEntities6();

        public CircleForm()
        {
            InitializeComponent();
            LoadUser();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_lick(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CircleForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxState_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadUser()
        {
            var Users = db.Users.ToList();
            // لا يوجد اختيار افتراضي


            comboBoxTecherCircle.DataSource = Users;
            comboBoxTecherCircle.DisplayMember = "UserName";  // الاسم الظاهر
            comboBoxTecherCircle.ValueMember = "UserID";      // الرقم الحقيقي
            comboBoxTecherCircle.SelectedIndex = -1;
        }

        private void comboBoxTecherCircle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMochrfCircle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Circles obj = new Circles();

            obj.CircleName = textBoxNameCircle.Text; // استخدم الاسم الفعلي لحقل اسم المستخدم لديك
            obj.MosqueName = textBoxMosqCircle.Text; // استخدم الاسم الفعلي لحقل كلمة المرور لديك
            obj.EducationalLevel = textBoxlivelCircle.Text;
           
            // 4. حفظ الكائن في قاعدة البيانات
            db.Circles.Add(obj);
            db.SaveChanges();

            // 5. إظهار رسالة النجاح
            MessageBox.Show("تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 6. مسح الحقول بعد الحفظ (خطوة اختيارية ومفيدة)
            // txtUserId.Text = ""; // مسح حقل رقم المستخدم
            textBoxNameCircle.Text = "";
            textBoxMosqCircle.Text = "";
            // comboBoxTecherCircle.SelectedIndex = -1; // إلغاء تحديد نوع المستخدم
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
