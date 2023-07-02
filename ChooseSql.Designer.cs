
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
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
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
            this.checkBox1.Location = new System.Drawing.Point(641, 116);
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
            this.TrustServerCertificate.Location = new System.Drawing.Point(55, 189);
            this.TrustServerCertificate.Name = "TrustServerCertificate";
            this.TrustServerCertificate.Size = new System.Drawing.Size(179, 24);
            this.TrustServerCertificate.TabIndex = 11;
            this.TrustServerCertificate.Text = "Trust Server Certificate";
            this.TrustServerCertificate.UseVisualStyleBackColor = true;
            // 
            // MultipleActiveResultSets
            // 
            this.MultipleActiveResultSets.AutoSize = true;
            this.MultipleActiveResultSets.Location = new System.Drawing.Point(55, 159);
            this.MultipleActiveResultSets.Name = "MultipleActiveResultSets";
            this.MultipleActiveResultSets.Size = new System.Drawing.Size(256, 24);
            this.MultipleActiveResultSets.TabIndex = 11;
            this.MultipleActiveResultSets.Text = "(MARS)Multiple Active Result Sets";
            this.MultipleActiveResultSets.UseVisualStyleBackColor = true;
            // 
            // Password_con
            // 
            this.Password_con.Location = new System.Drawing.Point(404, 113);
            this.Password_con.Name = "Password_con";
            this.Password_con.PasswordChar = '*';
            this.Password_con.Size = new System.Drawing.Size(231, 27);
            this.Password_con.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль для сервера MSSql";
            // 
            // UserId_con
            // 
            this.UserId_con.Location = new System.Drawing.Point(404, 80);
            this.UserId_con.Name = "UserId_con";
            this.UserId_con.Size = new System.Drawing.Size(231, 27);
            this.UserId_con.TabIndex = 8;
            // 
            // Database_conString
            // 
            this.Database_conString.Location = new System.Drawing.Point(404, 47);
            this.Database_conString.Name = "Database_conString";
            this.Database_conString.Size = new System.Drawing.Size(231, 27);
            this.Database_conString.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логин для сервера MSSql";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя базы данных на сервере  (должна быть создана)";
            // 
            // Server_conString
            // 
            this.Server_conString.Location = new System.Drawing.Point(404, 14);
            this.Server_conString.Name = "Server_conString";
            this.Server_conString.Size = new System.Drawing.Size(231, 27);
            this.Server_conString.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 17);
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
    }
}