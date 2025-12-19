namespace managment.UserDisplay
{
    partial class User
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSercheUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDeletUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewUserDisplay = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-150, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 147;
            this.button1.Text = "جميع الطلاب ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxSercheUser
            // 
            this.textBoxSercheUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSercheUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSercheUser.Location = new System.Drawing.Point(691, 157);
            this.textBoxSercheUser.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.textBoxSercheUser.Multiline = true;
            this.textBoxSercheUser.Name = "textBoxSercheUser";
            this.textBoxSercheUser.Size = new System.Drawing.Size(263, 36);
            this.textBoxSercheUser.TabIndex = 146;
            this.textBoxSercheUser.TextChanged += new System.EventHandler(this.textBoxSercheUser_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(366, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 32);
            this.label11.TabIndex = 173;
            this.label11.Text = "كلمة المرور ";
            // 
            // buttonDeletUser
            // 
            this.buttonDeletUser.BackColor = System.Drawing.Color.Crimson;
            this.buttonDeletUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeletUser.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletUser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonDeletUser.Location = new System.Drawing.Point(75, 529);
            this.buttonDeletUser.Name = "buttonDeletUser";
            this.buttonDeletUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDeletUser.Size = new System.Drawing.Size(202, 40);
            this.buttonDeletUser.TabIndex = 151;
            this.buttonDeletUser.Text = "حذف مستخدم ";
            this.buttonDeletUser.UseVisualStyleBackColor = false;
            this.buttonDeletUser.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUser.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonAddUser.Location = new System.Drawing.Point(716, 529);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAddUser.Size = new System.Drawing.Size(202, 40);
            this.buttonAddUser.TabIndex = 153;
            this.buttonAddUser.Text = "اضافه مستخدم جديد";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(387, 529);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(202, 40);
            this.button2.TabIndex = 154;
            this.button2.Text = "تعديل مستخدم جديد";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtName.Location = new System.Drawing.Point(75, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 35);
            this.txtName.TabIndex = 168;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPassword.Location = new System.Drawing.Point(75, 125);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(233, 35);
            this.txtPassword.TabIndex = 169;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.BackColor = System.Drawing.Color.GhostWhite;
            this.comboBoxUser.Font = new System.Drawing.Font("Tahoma", 14F);
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "teacher"});
            this.comboBoxUser.Location = new System.Drawing.Point(75, 169);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(233, 36);
            this.comboBoxUser.TabIndex = 170;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(350, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 32);
            this.label13.TabIndex = 171;
            this.label13.Text = "نوع المستخدم ";
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(366, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 32);
            this.label12.TabIndex = 172;
            this.label12.Text = "اسم المستخدم  ";
            // 
            // dataGridViewUserDisplay
            // 
            this.dataGridViewUserDisplay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUserDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserDisplay.Location = new System.Drawing.Point(31, 223);
            this.dataGridViewUserDisplay.Name = "dataGridViewUserDisplay";
            this.dataGridViewUserDisplay.RowHeadersWidth = 51;
            this.dataGridViewUserDisplay.RowTemplate.Height = 26;
            this.dataGridViewUserDisplay.Size = new System.Drawing.Size(948, 280);
            this.dataGridViewUserDisplay.TabIndex = 150;
            this.dataGridViewUserDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserDisplay_CellContentClick);
            this.dataGridViewUserDisplay.SelectionChanged += new System.EventHandler(this.dataGridViewUserDisplay_SelectionChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label21.Location = new System.Drawing.Point(411, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(188, 32);
            this.label21.TabIndex = 230;
            this.label21.Text = "عرض المستخدمين ";
            this.label21.UseWaitCursor = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1013, 624);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonDeletUser);
            this.Controls.Add(this.dataGridViewUserDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSercheUser);
            this.Name = "User";
            this.Text = "111";
            this.Load += new System.EventHandler(this.UserDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSercheUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDeletUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewUserDisplay;
        private System.Windows.Forms.Label label21;
    }
}