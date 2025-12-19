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
        Memorization_Circles_ManagementEntities2 db = new Memorization_Circles_ManagementEntities2();

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
            try
            {
                if (textBoxNameCircle.Text == "")
                {
                    MessageBox.Show("اكتب اسم الحلقة ");
                    return;
                }

                if (comboBoxTecherCircle.Text == "")
                {
                    MessageBox.Show("اختر المعلم ");
                    return;
                }




                Circles obj = new Circles();

            obj.CircleName = textBoxNameCircle.Text; 
            obj.MosqueName = textBoxMosqCircle.Text;
            obj.EducationalLevel = textBoxlivelCircle.Text;
           
            // 4. حفظ الكائن في قاعدة البيانات
            db.Circles.Add(obj);
            db.SaveChanges();

            // 5. إظهار رسالة النجاح
            MessageBox.Show("تم الحفظ بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            textBoxNameCircle.Text = "";
            textBoxMosqCircle.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ:\n" + ex.Message);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
