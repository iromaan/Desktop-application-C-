namespace WindowsFormsApplication2
{
    partial class Autorisation
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.password_check = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(12, 77);
            this.login.Margin = new System.Windows.Forms.Padding(15);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(38, 13);
            this.login.TabIndex = 0;
            this.login.Text = "Логин";
            this.login.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // login_text
            // 
            this.login_text.Location = new System.Drawing.Point(71, 70);
            this.login_text.Margin = new System.Windows.Forms.Padding(15);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(155, 20);
            this.login_text.TabIndex = 2;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(71, 113);
            this.password_text.Margin = new System.Windows.Forms.Padding(15);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(155, 20);
            this.password_text.TabIndex = 3;
            this.password_text.UseSystemPasswordChar = true;
            // 
            // password_check
            // 
            this.password_check.AutoSize = true;
            this.password_check.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_check.Location = new System.Drawing.Point(91, 139);
            this.password_check.Margin = new System.Windows.Forms.Padding(15);
            this.password_check.Name = "password_check";
            this.password_check.Size = new System.Drawing.Size(114, 17);
            this.password_check.TabIndex = 4;
            this.password_check.Text = "Показать пароль";
            this.password_check.UseVisualStyleBackColor = true;
            this.password_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(12, 120);
            this.password.Margin = new System.Windows.Forms.Padding(15);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(45, 13);
            this.password.TabIndex = 5;
            this.password.Text = "Пароль";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(15);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(284, 51);
            this.panel.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(65, 51);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // connect_button
            // 
            this.connect_button.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connect_button.Location = new System.Drawing.Point(91, 163);
            this.connect_button.Margin = new System.Windows.Forms.Padding(15);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(112, 23);
            this.connect_button.TabIndex = 7;
            this.connect_button.Text = "Подключение";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 257);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.password_check);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Name = "Autorisation";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.CheckBox password_check;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button connect_button;
    }
}

