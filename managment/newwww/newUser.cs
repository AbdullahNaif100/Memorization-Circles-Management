using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managment.newwww
{
    public partial class newUser : Form
    {
        Memorization_Circles_ManagementEntities6 db = new Memorization_Circles_ManagementEntities6();

        public newUser()
        {
            InitializeComponent();
        }
       
       // String UserType = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Users obj = new Users();

            obj.UserName = txtName.Text; // استخدم الاسم الفعلي لحقل اسم المستخدم لديك
            obj.Password = txtPassword.Text; // استخدم الاسم الفعلي لحقل كلمة المرور لديك
            obj.UserType = comboBoxUser.Text; 
            // 4. حفظ الكائن في قاعدة البيانات
            db.Users.Add(obj);
            db.SaveChanges();

            // 5. إظهار رسالة النجاح
            MessageBox.Show("تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 6. مسح الحقول بعد الحفظ (خطوة اختيارية ومفيدة)
            // txtUserId.Text = ""; // مسح حقل رقم المستخدم
            txtName.Text = "";
            txtPassword.Text = "";
            comboBoxUser.SelectedIndex = -1; // إلغاء تحديد نوع المستخدم

        
    }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void newUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
