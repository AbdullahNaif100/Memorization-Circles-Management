using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managment.users
{
    public partial class logIn : Form
    {
        Memorization_Circles_ManagementEntities6 db = new Memorization_Circles_ManagementEntities6();

        public logIn()
        {
            InitializeComponent();
        }

        private void logIn_Load(object sender, EventArgs e)
        {
            

        }
        void openForm(){
            Application.Run(new MainForm());
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = textBoxNameUser.Text;
            String pass = textBoxPassword.Text;
            var result = db.Users.Where(y => y.UserName ==username && y.Password == pass);
            if (result.Count()>0) {
                this.Close();
                Thread th = new Thread(openForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show(" اسم الامستخدم خطاء ");
            }
        }
           
    }
}
