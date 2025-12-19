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
        Memorization_Circles_ManagementEntities2 db = new Memorization_Circles_ManagementEntities2();

        public newUser()
        {
            InitializeComponent();
        }
       
       // String UserType = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("اكتب اسم المستخدم  ");
                    return;
                }

                if (txtPassword.Text == "")
                {
                    MessageBox.Show("اكتب كلمة المرور ");
                    return;
                }

                if (comboBoxUser.Text == null)
                {
                    MessageBox.Show("اختر توع المستخدم ");
                    return;
                }

                Users obj = new Users();

            obj.UserName = txtName.Text; // استخدم الاسم الفعلي لحقل اسم المستخدم لديك
            obj.Password = txtPassword.Text; // استخدم الاسم الفعلي لحقل كلمة المرور لديك
           obj.UserType = comboBoxUser.Text;
            // 4. حفظ الكائن في قاعدة البيانات
            if (txtName.Text == null && txtPassword.Text == null )
            {
                MessageBox.Show(" ادخل الاسم ةكلمه المروررر ");
            }
            else
            {
                db.Users.Add(obj);
                db.SaveChanges();

                // 5. إظهار رسالة النجاح
                MessageBox.Show("تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtName.Text = "";
                txtPassword.Text = "";
                comboBoxUser.SelectedIndex = -1; // إلغاء تحديد نوع المستخدم
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ:\n" + ex.Message);
            }
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void newUser_Load(object sender, EventArgs e)
        {

        }

       

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
