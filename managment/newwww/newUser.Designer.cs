namespace managment.newwww
{
    partial class newUser
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
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.BackColor = System.Drawing.Color.GhostWhite;
            this.comboBoxUser.Font = new System.Drawing.Font("Tahoma", 14F);
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "teacher"});
            this.comboBoxUser.Location = new System.Drawing.Point(215, 176);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(233, 36);
            this.comboBoxUser.TabIndex = 167;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(492, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 29);
            this.label11.TabIndex = 163;
            this.label11.Text = "كلمة المرور ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(487, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 29);
            this.label12.TabIndex = 162;
            this.label12.Text = "اسم المستخدم  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(475, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 29);
            this.label13.TabIndex = 161;
            this.label13.Text = "نوع المستخدم ";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPassword.Location = new System.Drawing.Point(215, 123);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(233, 35);
            this.txtPassword.TabIndex = 159;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtName.Location = new System.Drawing.Point(215, 73);
            this.txtName.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 35);
            this.txtName.TabIndex = 157;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 44);
            this.button1.TabIndex = 155;
            this.button1.Text = "حفظ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(768, 367);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "newUser";
            this.Text = "newUser";
            this.Load += new System.EventHandler(this.newUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
    }
}