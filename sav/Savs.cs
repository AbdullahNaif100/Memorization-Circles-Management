using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managment.sav
{
    public partial class Save : Form
    {
        Memorization_Circles_ManagementEntities2 db = new Memorization_Circles_ManagementEntities2();

        public Save()
        {
            InitializeComponent();

            LoadSurahNames();
            LoadSurahNamesend();
            LoadSurahNamesRevou();
            LoadSurahNamesendRevou();
            LoadAuanumber();
            LoadAyoNumberend();
            LoadRevouAyanumber();
            LoadAyoNumbendRevou();
            LoadCircles();
            LoadAttendance();
            textBoxSaveErarr.Text = errorCount.ToString();

            textBoxSaveErarr.ReadOnly = true;
            textBoxRevyoErrar.ReadOnly = true;
        }

        //-----------------------------------
        // السور
        //-----------------------------------

        private string[] QuranSurahs =
        {
            "الفاتحة","البقرة","آل عمران","النساء","المائدة","الأنعام","الأعراف",
            "الأنفال","التوبة","يونس","هود","يوسف","الرعد","إبراهيم","الحجر","النحل",
            "الإسراء","الكهف","مريم","طه","الأنبياء","الحج","المؤمنون","النور",
            "الفرقان","الشعراء","النمل","القصص","العنكبوت","الروم","لقمان","السجدة",
            "الأحزاب","سبأ","فاطر","يس","الصافات","ص","الزمر","غافر","فصلت","الشورى",
            "الزخرف","الدخان","الجاثية","الأحقاف","محمد","الفتح","الحجرات","ق",
            "الذاريات","الطور","النجم","القمر","الرحمن","الواقعة","الحجر","المؤمن",
            "الحديد","المجادلة","الحشر","الممتحنة","الصف","الجمعة","المنافقون",
            "التغابن","الطلاق","التحريم","الملك","القلم","الحاقة","المعارج","نوح",
            "الجن","المزمل","المدثر","القيامة","الإنسان","المرسلات","النبأ",
            "النازعات","عبس","التكوير","الإنفطار","المطففين","الإنشقاق","البروج",
            "الطارق","الأعلى","الغاشية","الفجر","البلد","الشمس","الليل","الضحى",
            "الشرح","التين","العلق","القدر","البينة","الزلزلة","العاديات","القارعة",
            "التكاثر","العصر","الهمزة","الفيل","قريش","الماعون","الكوثر",
            "الكافرون","النصر","المسد","الإخلاص","الفلق","الناس"
        };

        private string[] QuranJuz =
        {
            "الجزء 1","الجزء 2","الجزء 3","الجزء 4","الجزء 5","الجزء 6","الجزء 7",
            "الجزء 8","الجزء 9","الجزء 10","الجزء 11","الجزء 12","الجزء 13",
            "الجزء 14","الجزء 15","الجزء 16","الجزء 17","الجزء 18","الجزء 19",
            "الجزء 20","الجزء 21","الجزء 22","الجزء 23","الجزء 24","الجزء 25",
            "الجزء 26","الجزء 27","الجزء 28","الجزء 29","الجزء 30"
        };

        private void LoadSurahNames()
        {
            comboBoxSurao.Items.AddRange(QuranSurahs);
            comboBoxSurao.SelectedIndex = 0;
        }

        private void LoadSurahNamesend()
        {
            comboBoxToSurao.Items.AddRange(QuranSurahs);
            comboBoxToSurao.SelectedIndex = 0;
        }

        private void LoadSurahNamesRevou()
        {
            comboBoxRevyoSurao.Items.AddRange(QuranSurahs);
            comboBoxRevyoSurao.SelectedIndex = 0;
        }

        private void LoadSurahNamesendRevou()
        {
            comboBoxToRevyoSurao.Items.AddRange(QuranSurahs);
            comboBoxToRevyoSurao.SelectedIndex = 0;
        }

        private void LoadAuanumber()
        {
            comboBoxAyoo.Items.AddRange(QuranJuz);
            comboBoxAyoo.SelectedIndex = 0;
        }

        private void LoadAyoNumberend()
        {
            comboBoxToAyoo.Items.AddRange(QuranJuz);
            comboBoxToAyoo.SelectedIndex = 0;
        }

        private void LoadRevouAyanumber()
        {
            comboBoxRevuoAyoo.Items.AddRange(QuranJuz);
            comboBoxRevuoAyoo.SelectedIndex = 0;
        }

        private void LoadAyoNumbendRevou()
        {
            comboBoxToRevyoAyo.Items.AddRange(QuranJuz);
            comboBoxToRevyoAyo.SelectedIndex = 0;
        }

        //-----------------------------------
        // الطلاب والوقت
        //-----------------------------------

        private void Save_Load(object sender, EventArgs e)
        {
            // التاريخ والوقت
            labelDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, ev) =>
            {
                labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            };
            timer.Start();

            // الطلاب
            var students = db.Students.ToList();
            SudentName.DataSource = students;
            SudentName.DisplayMember = "StudentName";
            SudentName.ValueMember = "StudentID";
            SudentName.SelectedIndex = -1;

            SudentName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SudentName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        //-----------------------------------
        // الحضور
        //-----------------------------------

        private void LoadAttendance()
        {
            comboBoxAttendance.Items.Clear();
            comboBoxAttendance.Items.Add("حاضر");
            comboBoxAttendance.Items.Add("غائب");
            comboBoxAttendance.SelectedIndex = 0;
        }

        //-----------------------------------
        // الحلقات
        //-----------------------------------

        private void LoadCircles()
      
        {
            comboBoxCircle.DataSource = db.Circles.ToList();
            comboBoxCircle.DisplayMember = "CircleName";
            comboBoxCircle.ValueMember = "CircleID";
            comboBoxCircle.SelectedIndex = -1;
        }

        

        //-----------------------------------
        // زر الحفظ
        //-----------------------------------

        private void buttoSearche_Click(object sender, EventArgs e)
        {
            try
            {
                if (SudentName.SelectedValue == null)
                {
                    MessageBox.Show("اختر الطالب");
                    return;
                }

                if (comboBoxCircle.SelectedValue == null)
                {
                    MessageBox.Show("اختر الحلقة");
                    return;
                }

                if (comboBoxAttendance.Text == "")
                {
                    MessageBox.Show("اختر حالة الحضور");
                    return;
                }

                int studentId = Convert.ToInt32(SudentName.SelectedValue);
                int circleId = Convert.ToInt32(comboBoxCircle.SelectedValue);
                string attendance = comboBoxAttendance.Text;

                MemorizationRecords record = new MemorizationRecords();
                record.StudentID = studentId;
                record.CircleID = circleId;
                record.AttendanceStatus = attendance;
                record.Notes = textBoxNot.Text;
                record.SessionDate = DateTime.Now.Date;
                record.SessionTime = DateTime.Now.TimeOfDay;

                db.MemorizationRecords.Add(record);
                db.SaveChanges();

                int recordId = record.RecordID;

                // حفظ الحفظ
                NewMemorization mem = new NewMemorization();
                mem.RecordID = recordId;
                mem.SuraFrom = comboBoxSurao.Text;
                mem.AyahFrom = comboBoxAyoo.Text;
                mem.SuraTo = comboBoxToSurao.Text;
                mem.AyahTo = comboBoxToAyoo.Text;
                mem.PagesCount = int.TryParse(comboBoxNemberBage.Text, out int p1) ? p1 : 0;
                mem.Mistakes = int.TryParse(textBoxSaveErarr.Text, out int m1) ? m1 : 0;

                db.NewMemorization.Add(mem);

                // حفظ المراجعة
                Revision rev = new Revision();
                rev.RecordID = recordId;
                rev.SuraFrom = comboBoxRevyoSurao.Text;
                rev.AyahFrom = comboBoxRevuoAyoo.Text;
                rev.SuraTo = comboBoxToRevyoSurao.Text;
                rev.AyahTo = comboBoxToRevyoAyo.Text;
                rev.PagesCount = int.TryParse(comboBoxRevyoNumberBage.Text, out int p2) ? p2 : 0;
                rev.Mistakes = int.TryParse(textBoxRevyoErrar.Text, out int m2) ? m2 : 0;

                db.Revision.Add(rev);
                db.SaveChanges();

                MessageBox.Show("✅ تم الحفظ بنجاح");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ:\n" + ex.Message);
            }
        }

        //-----------------------------------
        // تفريغ الحقول
        //-----------------------------------

        private void ClearFields()
        {
            comboBoxCircle.SelectedIndex = -1;
            SudentName.SelectedIndex = -1;
            comboBoxAttendance.SelectedIndex = 0;

            comboBoxSurao.SelectedIndex = 0;
            comboBoxAyoo.SelectedIndex = 0;
            comboBoxToSurao.SelectedIndex = 0;
            comboBoxToAyoo.SelectedIndex = 0;

            comboBoxRevyoSurao.SelectedIndex = 0;
            comboBoxRevuoAyoo.SelectedIndex = 0;
            comboBoxToRevyoSurao.SelectedIndex = 0;
            comboBoxToRevyoAyo.SelectedIndex = 0;

            comboBoxNemberBage.Text = "";
            comboBoxRevyoNumberBage.Text = "";
            textBoxSaveErarr.Text = "";
            textBoxRevyoErrar.Text = "";
            textBoxNot.Text = "";
        }

        private void comboBoxCircle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCircle.SelectedItem == null)
                return;

            Circles circle = (Circles)comboBoxCircle.SelectedItem;
            int circleId = circle.CircleID;

            var students = db.Students
                             .Where(s => s.CircleID == circleId)
                             .ToList();

            SudentName.DataSource = students;
            SudentName.DisplayMember = "StudentName";
            SudentName.ValueMember = "StudentID";
            SudentName.SelectedIndex = -1;
        


        // تفعيل البحث التلقائي من جديد
        SudentName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
    SudentName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        int errorCount = 0;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonErarrMauynass_Click(object sender, EventArgs e)
        {
            if (errorCount > 0)
                errorCount--;

            textBoxSaveErarr.Text = errorCount.ToString();
        }

        private void textBoxSaveErarr_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonErarrblass_Click(object sender, EventArgs e)
        {
            errorCount++;
            textBoxSaveErarr.Text = errorCount.ToString();
        }

        private void buttonErarrblassRevyo_Click(object sender, EventArgs e)
        {
            errorCount++;
            textBoxRevyoErrar.Text = errorCount.ToString();
        }

        private void buttonErarrMauynassRevyo_Click(object sender, EventArgs e)
        {
            if (errorCount > 0)
                errorCount--;

            textBoxRevyoErrar.Text = errorCount.ToString();
        }

        private void textBoxRevyoErrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
