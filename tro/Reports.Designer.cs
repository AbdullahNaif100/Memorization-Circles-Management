namespace managment.tro
{
    partial class AttendanceForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefres = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxAttendance = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.mboBoxCircle = new System.Windows.Forms.ComboBox();
            this.datdataGridViewReportsaGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datdataGridViewReportsaGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(629, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 33);
            this.label5.TabIndex = 174;
            this.label5.Text = "حسب االحضور ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(229, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 173;
            this.label2.Text = "حسب الحلقة ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(218, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 33);
            this.label4.TabIndex = 172;
            this.label4.Text = "الي تاريخ  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(630, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 33);
            this.label3.TabIndex = 171;
            this.label3.Text = "من تاريخ ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 57);
            this.label1.TabIndex = 170;
            this.label1.Text = "تقارير";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Tahoma", 16F);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(12, 152);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 40);
            this.dateTo.TabIndex = 169;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtSearch.Location = new System.Drawing.Point(12, 267);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(434, 40);
            this.txtSearch.TabIndex = 168;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefres
            // 
            this.btnRefres.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRefres.Location = new System.Drawing.Point(108, 587);
            this.btnRefres.Name = "btnRefres";
            this.btnRefres.Size = new System.Drawing.Size(119, 44);
            this.btnRefres.TabIndex = 167;
            this.btnRefres.Text = "تحديث الكل ";
            this.btnRefres.UseVisualStyleBackColor = false;
            this.btnRefres.Click += new System.EventHandler(this.btnRefres_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Location = new System.Drawing.Point(446, 587);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 44);
            this.btnSearch.TabIndex = 166;
            this.btnSearch.Text = "شرح بتفصيل ";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // comboBoxAttendance
            // 
            this.comboBoxAttendance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.comboBoxAttendance.FormattingEnabled = true;
            this.comboBoxAttendance.Location = new System.Drawing.Point(424, 208);
            this.comboBoxAttendance.Name = "comboBoxAttendance";
            this.comboBoxAttendance.Size = new System.Drawing.Size(200, 41);
            this.comboBoxAttendance.TabIndex = 165;
            this.comboBoxAttendance.SelectedIndexChanged += new System.EventHandler(this.comboBoxAttendance_SelectedIndexChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Tahoma", 16F);
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(424, 153);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 40);
            this.dateFrom.TabIndex = 164;
            // 
            // mboBoxCircle
            // 
            this.mboBoxCircle.Font = new System.Drawing.Font("Tahoma", 16F);
            this.mboBoxCircle.FormattingEnabled = true;
            this.mboBoxCircle.Location = new System.Drawing.Point(12, 208);
            this.mboBoxCircle.Name = "mboBoxCircle";
            this.mboBoxCircle.Size = new System.Drawing.Size(200, 41);
            this.mboBoxCircle.TabIndex = 163;
            this.mboBoxCircle.SelectedIndexChanged += new System.EventHandler(this.mboBoxCircle_SelectedIndexChanged_1);
            // 
            // datdataGridViewReportsaGridView2
            // 
            this.datdataGridViewReportsaGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datdataGridViewReportsaGridView2.Location = new System.Drawing.Point(12, 330);
            this.datdataGridViewReportsaGridView2.Name = "datdataGridViewReportsaGridView2";
            this.datdataGridViewReportsaGridView2.RowHeadersWidth = 51;
            this.datdataGridViewReportsaGridView2.RowTemplate.Height = 26;
            this.datdataGridViewReportsaGridView2.Size = new System.Drawing.Size(722, 234);
            this.datdataGridViewReportsaGridView2.TabIndex = 162;
            this.datdataGridViewReportsaGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datdataGridViewReportsaGridView2_CellContentClick_1);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 694);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRefres);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxAttendance);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.mboBoxCircle);
            this.Controls.Add(this.datdataGridViewReportsaGridView2);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.الحضرو_والغياب_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datdataGridViewReportsaGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefres;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxAttendance;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ComboBox mboBoxCircle;
        private System.Windows.Forms.DataGridView datdataGridViewReportsaGridView2;
    }
}