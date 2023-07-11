
namespace ExConPram
{
    partial class ChooseSql
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.LocalDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TrustServerCertificate = new System.Windows.Forms.CheckBox();
            this.MultipleActiveResultSets = new System.Windows.Forms.CheckBox();
            this.Password_con = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserId_con = new System.Windows.Forms.TextBox();
            this.Database_conString = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Server_conString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Password_Mysql = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UserId_Mysql = new System.Windows.Forms.TextBox();
            this.Database_Mysql = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Server_IP_Mysql = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(818, 340);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.LocalDB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sqlite";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(576, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выполнить соеденение";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // LocalDB
            // 
            this.LocalDB.Location = new System.Drawing.Point(17, 42);
            this.LocalDB.Name = "LocalDB";
            this.LocalDB.Size = new System.Drawing.Size(692, 27);
            this.LocalDB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " Локальное размещение базы данных";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.TrustServerCertificate);
            this.tabPage2.Controls.Add(this.MultipleActiveResultSets);
            this.tabPage2.Controls.Add(this.Password_con);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.UserId_con);
            this.tabPage2.Controls.Add(this.Database_conString);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Server_conString);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MSSQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(640, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Показать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // TrustServerCertificate
            // 
            this.TrustServerCertificate.AutoSize = true;
            this.TrustServerCertificate.Location = new System.Drawing.Point(48, 184);
            this.TrustServerCertificate.Name = "TrustServerCertificate";
            this.TrustServerCertificate.Size = new System.Drawing.Size(179, 24);
            this.TrustServerCertificate.TabIndex = 11;
            this.TrustServerCertificate.Text = "Trust Server Certificate";
            this.TrustServerCertificate.UseVisualStyleBackColor = true;
            // 
            // MultipleActiveResultSets
            // 
            this.MultipleActiveResultSets.AutoSize = true;
            this.MultipleActiveResultSets.Location = new System.Drawing.Point(48, 152);
            this.MultipleActiveResultSets.Name = "MultipleActiveResultSets";
            this.MultipleActiveResultSets.Size = new System.Drawing.Size(256, 24);
            this.MultipleActiveResultSets.TabIndex = 11;
            this.MultipleActiveResultSets.Text = "(MARS)Multiple Active Result Sets";
            this.MultipleActiveResultSets.UseVisualStyleBackColor = true;
            // 
            // Password_con
            // 
            this.Password_con.Location = new System.Drawing.Point(400, 112);
            this.Password_con.Name = "Password_con";
            this.Password_con.PasswordChar = '*';
            this.Password_con.Size = new System.Drawing.Size(232, 27);
            this.Password_con.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль для сервера MSSql";
            // 
            // UserId_con
            // 
            this.UserId_con.Location = new System.Drawing.Point(400, 80);
            this.UserId_con.Name = "UserId_con";
            this.UserId_con.Size = new System.Drawing.Size(232, 27);
            this.UserId_con.TabIndex = 8;
            // 
            // Database_conString
            // 
            this.Database_conString.Location = new System.Drawing.Point(400, 40);
            this.Database_conString.Name = "Database_conString";
            this.Database_conString.Size = new System.Drawing.Size(232, 27);
            this.Database_conString.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логин для сервера MSSql";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя базы данных на сервере  (должна быть создана)";
            // 
            // Server_conString
            // 
            this.Server_conString.Location = new System.Drawing.Point(400, 8);
            this.Server_conString.Name = "Server_conString";
            this.Server_conString.Size = new System.Drawing.Size(232, 27);
            this.Server_conString.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя сервера (не работает с локальной базой данных)";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(576, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Выполнить соеденение";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox2);
            this.tabPage3.Controls.Add(this.Password_Mysql);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.UserId_Mysql);
            this.tabPage3.Controls.Add(this.Database_Mysql);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.Server_IP_Mysql);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(810, 307);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MySQL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(576, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнить соеденение";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar1.ForeColor = System.Drawing.Color.SpringGreen;
            this.ProgressBar1.Location = new System.Drawing.Point(0, 340);
            this.ProgressBar1.Maximum = 50;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(818, 19);
            this.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar1.TabIndex = 1;
            this.ProgressBar1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(640, 104);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 24);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "Показать";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Password_Mysql
            // 
            this.Password_Mysql.Location = new System.Drawing.Point(400, 104);
            this.Password_Mysql.Name = "Password_Mysql";
            this.Password_Mysql.PasswordChar = '*';
            this.Password_Mysql.Size = new System.Drawing.Size(232, 27);
            this.Password_Mysql.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Пароль MySql";
            // 
            // UserId_Mysql
            // 
            this.UserId_Mysql.Location = new System.Drawing.Point(400, 72);
            this.UserId_Mysql.Name = "UserId_Mysql";
            this.UserId_Mysql.Size = new System.Drawing.Size(232, 27);
            this.UserId_Mysql.TabIndex = 17;
            // 
            // Database_Mysql
            // 
            this.Database_Mysql.Location = new System.Drawing.Point(400, 40);
            this.Database_Mysql.Name = "Database_Mysql";
            this.Database_Mysql.Size = new System.Drawing.Size(232, 27);
            this.Database_Mysql.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Логин MySql";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(393, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Имя базы (schema) на сервере  (должна быть создана)";
            // 
            // Server_IP_Mysql
            // 
            this.Server_IP_Mysql.Location = new System.Drawing.Point(400, 8);
            this.Server_IP_Mysql.Name = "Server_IP_Mysql";
            this.Server_IP_Mysql.Size = new System.Drawing.Size(232, 27);
            this.Server_IP_Mysql.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "IP сервера MySql";
            // 
            // ChooseSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 359);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.ProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChooseSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор подключения Sql";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChooseSql_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LocalDB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Server_conString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Database_conString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserId_con;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password_con;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox MultipleActiveResultSets;
        private System.Windows.Forms.CheckBox TrustServerCertificate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox Password_Mysql;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UserId_Mysql;
        private System.Windows.Forms.TextBox Database_Mysql;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Server_IP_Mysql;
        private System.Windows.Forms.Label label9;
    }
}