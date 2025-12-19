using managment.newwww;
using managment.newwww;
using managment.riang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using managment.newwww;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace managment.UserDisplay
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            LoadAllUsers();
        }
        Memorization_Circles_ManagementEntities2 db = new Memorization_Circles_ManagementEntities2();
        private void LoadAllUsers()
        {
            dataGridViewUserDisplay.DataSource = db.Users.ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // استدعاء دالة لجلب وعرض جميع البيانات
        }





        private void UserDisplay_Load(object sender, EventArgs e)
        {

        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            // تأكد أن المستخدم اختار صف
            if (dataGridViewUserDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى اختيار مستخدم للحذف");
                return;
            }

            // جلب ID من الصف المحدد
            int id = Convert.ToInt32(dataGridViewUserDisplay.SelectedRows[0].Cells["UserID"].Value);

            // البحث عن المستخدم في قاعدة البيانات
            var student = db.Users.Find(id);


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
                    db.Users.Remove(student);
                    db.SaveChanges();

                    MessageBox.Show("✅ تم حذف المستخدم بنجاح",id.ToString());

                    // تحديث القائمة
                    LoadAllUsers();
                }
            }
            else
            {
                MessageBox.Show("❌ لم يتم العثور على المستخدم");
            }


        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

            newUser cf = new newUser();
            cf.Show();
        }

        private void textBoxSercheUser_TextChanged(object sender, EventArgs e)
        {

            string name = textBoxSercheUser.Text.Trim();

            if (name == "")
            {
                LoadAllUsers(); // رجوع لجميع الطلاب إذا مسح البحث
                return;
            }

            var result = db.Users
                           .Where(s => s.UserName.Contains(name))
                           .ToList();

            dataGridViewUserDisplay.DataSource = result;
        }

        private void dataGridViewUserDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            // تحقق هل تم اختيار طالب
            if (dataGridViewUserDisplay.SelectedRows.Count == 0)
            {
                MessageBox.Show("اختر طالب للتعديل أولاً");
                return;
            }

            int id = Convert.ToInt32(
                dataGridViewUserDisplay.SelectedRows[0].Cells["UserID"].Value
            );

            var users = db.Users.Find(id);

            if (users == null)
            {
                MessageBox.Show("لم يتم العثور على المستخدم ");
                return;
            }

            users.UserName = txtName.Text;
            users.Password  = txtPassword.Text;
            users.UserType  =comboBoxUser.Text;
           

          

            db.SaveChanges();

            MessageBox.Show("تم تعديل بيانات المستخدم  بنجاح");
            txtName.Text = " ";
             txtPassword.Text = " ";
           comboBoxUser.Text = " ";


        }

        private void dataGridViewUserDisplay_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dataGridViewUserDisplay.SelectedRows.Count == 0) return;

            DataGridViewRow row = dataGridViewUserDisplay.SelectedRows[0];

            txtName.Text = row.Cells["UserName"].Value?.ToString();
            txtPassword.Text = row.Cells["Password"].Value?.ToString();
            comboBoxUser.Text = row.Cells["UserType"].Value?.ToString();

            // تأكد أن القيمة غير فارغة قبل التحويل
            //if (row.Cells["UserType"].Value != null)
            //    comboBoxUser.Text = Convert.ToString(row.Cells["UserType"].Value);

            //comboBoxUser.SelectedValue = row.Cells["CircleID"].Value;



        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
    

    
}

