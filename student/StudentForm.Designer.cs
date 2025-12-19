using System;

namespace managment.student
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxNameStudent = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.buttonSaveDataStudent = new System.Windows.Forms.Button();
            this.serche = new System.Windows.Forms.TextBox();
            this.buttonSercheAll = new System.Windows.Forms.Button();
            this.buttonSerchebyCircle = new System.Windows.Forms.Button();
            this.dateTimeBrthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxNumberPhone = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAdrass = new System.Windows.Forms.TextBox();
            this.comboBoxCircal = new System.Windows.Forms.ComboBox();
            this.comboBoxEducationalLevel = new System.Windows.Forms.ComboBox();
            this.comboNationality = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(364, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 37);
            this.label3.TabIndex = 38;
            this.label3.Text = "بيانات الطالب ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(824, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(306, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "الجنسية ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(817, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "اسم الطالب ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(274, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 24);
            this.label8.TabIndex = 76;
            this.label8.Text = "المرحلة التعليمية ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(297, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 77;
            this.label4.Text = "تاريخ الميلاد";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(824, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
            this.label10.TabIndex = 79;
            this.label10.Text = "العنوان ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(817, 161);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 24);
            this.label11.TabIndex = 80;
            this.label11.Text = "رقم الجوال ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(795, 196);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 24);
            this.label12.TabIndex = 81;
            this.label12.Text = "رقم جوال ولي الامر ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label16.Location = new System.Drawing.Point(316, 181);
            this.label16.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 24);
            this.label16.TabIndex = 95;
            this.label16.Text = "الحلقة ";
            // 
            // textBoxNameStudent
            // 
            this.textBoxNameStudent.Location = new System.Drawing.Point(547, 85);
            this.textBoxNameStudent.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.textBoxNameStudent.Multiline = true;
            this.textBoxNameStudent.Name = "textBoxNameStudent";
            this.textBoxNameStudent.Size = new System.Drawing.Size(233, 35);
            this.textBoxNameStudent.TabIndex = 99;
            this.textBoxNameStudent.TextChanged += new System.EventHandler(this.textBoxNameStudent_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label18.Location = new System.Drawing.Point(822, 323);
            this.label18.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 21);
            this.label18.TabIndex = 134;
            this.label18.Text = "اختر االحلقة  ";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(24, 416);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 26;
            this.dataGridViewStudent.Size = new System.Drawing.Size(931, 280);
            this.dataGridViewStudent.TabIndex = 140;
            this.dataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellContentClick);
            this.dataGridViewStudent.SelectionChanged += new System.EventHandler(this.dataGridViewStudent_SelectionChanged);
            // 
            // buttonSaveDataStudent
            // 
            this.buttonSaveDataStudent.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonSaveDataStudent.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveDataStudent.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonSaveDataStudent.Location = new System.Drawing.Point(320, 255);
            this.buttonSaveDataStudent.Name = "buttonSaveDataStudent";
            this.buttonSaveDataStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSaveDataStudent.Size = new System.Drawing.Size(202, 40);
            this.buttonSaveDataStudent.TabIndex = 141;
            this.buttonSaveDataStudent.Text = "حفظ بيانات الطالب ";
            this.buttonSaveDataStudent.UseVisualStyleBackColor = false;
            this.buttonSaveDataStudent.Click += new System.EventHandler(this.buttonSaveDataStudent_Click);
            // 
            // serche
            // 
            this.serche.Location = new System.Drawing.Point(40, 323);
            this.serche.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.serche.Multiline = true;
            this.serche.Name = "serche";
            this.serche.Size = new System.Drawing.Size(295, 35);
            this.serche.TabIndex = 136;
            this.serche.TextChanged += new System.EventHandler(this.serche_TextChanged);
            // 
            // buttonSercheAll
            // 
            this.buttonSercheAll.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSercheAll.Location = new System.Drawing.Point(39, 366);
            this.buttonSercheAll.Name = "buttonSercheAll";
            this.buttonSercheAll.Size = new System.Drawing.Size(118, 40);
            this.buttonSercheAll.TabIndex = 137;
            this.buttonSercheAll.Text = "جميع الطلاب ";
            this.buttonSercheAll.UseVisualStyleBackColor = true;
            this.buttonSercheAll.Click += new System.EventHandler(this.AllStudent);
            // 
            // buttonSerchebyCircle
            // 
            this.buttonSerchebyCircle.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerchebyCircle.Location = new System.Drawing.Point(163, 366);
            this.buttonSerchebyCircle.Name = "buttonSerchebyCircle";
            this.buttonSerchebyCircle.Size = new System.Drawing.Size(172, 40);
            this.buttonSerchebyCircle.TabIndex = 138;
            this.buttonSerchebyCircle.Text = "الطلاب خسب الحلقة  ";
            this.buttonSerchebyCircle.Click += new System.EventHandler(this.buttonSerchebyCircle_Click);
            // 
            // dateTimeBrthday
            // 
            this.dateTimeBrthday.Font = new System.Drawing.Font("Tahoma", 14F);
            this.dateTimeBrthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBrthday.Location = new System.Drawing.Point(28, 75);
            this.dateTimeBrthday.Name = "dateTimeBrthday";
            this.dateTimeBrthday.Size = new System.Drawing.Size(233, 36);
            this.dateTimeBrthday.TabIndex = 142;
            // 
            // textBoxNumberPhone
            // 
            this.textBoxNumberPhone.Location = new System.Drawing.Point(547, 185);
            this.textBoxNumberPhone.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.textBoxNumberPhone.Multiline = true;
            this.textBoxNumberPhone.Name = "textBoxNumberPhone";
            this.textBoxNumberPhone.Size = new System.Drawing.Size(233, 35);
            this.textBoxNumberPhone.TabIndex = 146;
            this.textBoxNumberPhone.TextChanged += new System.EventHandler(this.textBoxNumberPhone_TextChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(547, 155);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(233, 35);
            this.textBoxPhone.TabIndex = 145;
            // 
            // textBoxAdrass
            // 
            this.textBoxAdrass.Location = new System.Drawing.Point(547, 120);
            this.textBoxAdrass.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.textBoxAdrass.Multiline = true;
            this.textBoxAdrass.Name = "textBoxAdrass";
            this.textBoxAdrass.Size = new System.Drawing.Size(233, 35);
            this.textBoxAdrass.TabIndex = 143;
            this.textBoxAdrass.TextChanged += new System.EventHandler(this.textBoxAdrass_TextChanged);
            // 
            // comboBoxCircal
            // 
            this.comboBoxCircal.Font = new System.Drawing.Font("Tahoma", 14F);
            this.comboBoxCircal.FormattingEnabled = true;
            this.comboBoxCircal.Location = new System.Drawing.Point(28, 181);
            this.comboBoxCircal.Name = "comboBoxCircal";
            this.comboBoxCircal.Size = new System.Drawing.Size(233, 36);
            this.comboBoxCircal.TabIndex = 149;
            this.comboBoxCircal.SelectedIndexChanged += new System.EventHandler(this.comboBoxCircal_SelectedIndexChanged);
            // 
            // comboBoxEducationalLevel
            // 
            this.comboBoxEducationalLevel.Font = new System.Drawing.Font("Tahoma", 14F);
            this.comboBoxEducationalLevel.FormattingEnabled = true;
            this.comboBoxEducationalLevel.Items.AddRange(new object[] {
            "اول اولي ",
            "اولي ",
            "ثانوي "});
            this.comboBoxEducationalLevel.Location = new System.Drawing.Point(28, 146);
            this.comboBoxEducationalLevel.Name = "comboBoxEducationalLevel";
            this.comboBoxEducationalLevel.Size = new System.Drawing.Size(233, 36);
            this.comboBoxEducationalLevel.TabIndex = 148;
            // 
            // comboNationality
            // 
            this.comboNationality.Font = new System.Drawing.Font("Tahoma", 14F);
            this.comboNationality.FormattingEnabled = true;
            this.comboNationality.Items.AddRange(new object[] {
            "ذكر ",
            "انثي"});
            this.comboNationality.Location = new System.Drawing.Point(28, 111);
            this.comboNationality.Name = "comboNationality";
            this.comboNationality.Size = new System.Drawing.Size(233, 36);
            this.comboNationality.TabIndex = 150;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Highlight;
            this.Add.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Add.Location = new System.Drawing.Point(737, 735);
            this.Add.Name = "Add";
            this.Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Add.Size = new System.Drawing.Size(202, 40);
            this.Add.TabIndex = 156;
            this.Add.Text = "اضافة طالب ";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Aqua;
            this.buttonEdit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonEdit.Location = new System.Drawing.Point(420, 735);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEdit.Size = new System.Drawing.Size(173, 40);
            this.buttonEdit.TabIndex = 155;
            this.buttonEdit.Text = "تعديل ";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Brown;
            this.buttonDelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonDelete.Location = new System.Drawing.Point(75, 735);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelete.Size = new System.Drawing.Size(202, 40);
            this.buttonDelete.TabIndex = 154;
            this.buttonDelete.Text = "الحذف";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.Delete);
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.Font = new System.Drawing.Font("Tahoma", 14F);
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Location = new System.Drawing.Point(706, 367);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(233, 36);
            this.comboBoxSelect.TabIndex = 157;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.buttonSerchebyCircle_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 811);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.comboNationality);
            this.Controls.Add(this.comboBoxCircal);
            this.Controls.Add(this.comboBoxEducationalLevel);
            this.Controls.Add(this.textBoxNumberPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAdrass);
            this.Controls.Add(this.dateTimeBrthday);
            this.Controls.Add(this.buttonSaveDataStudent);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.buttonSerchebyCircle);
            this.Controls.Add(this.buttonSercheAll);
            this.Controls.Add(this.serche);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxNameStudent);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "StudentForm";
            this.Text = "student";
            this.Load += new System.EventHandler(this.StudentForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void student_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxNameStudent;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button buttonSaveDataStudent;
        private System.Windows.Forms.TextBox serche;
        private System.Windows.Forms.Button buttonSercheAll;
        private System.Windows.Forms.Button buttonSerchebyCircle;
        private System.Windows.Forms.DateTimePicker dateTimeBrthday;
        private System.Windows.Forms.TextBox textBoxNumberPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAdrass;
        private System.Windows.Forms.ComboBox comboBoxCircal;
        private System.Windows.Forms.ComboBox comboBoxEducationalLevel;
        private System.Windows.Forms.ComboBox comboNationality;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxSelect;
    }
}