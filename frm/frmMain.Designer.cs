
namespace ExConPram.frm
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.Сountry = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.MachineBrandBox = new System.Windows.Forms.ComboBox();
            this.ADD_button1 = new System.Windows.Forms.Button();
            this.Edit_button2 = new System.Windows.Forms.Button();
            this.Del_button3 = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MarkupSng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SummPrice = new System.Windows.Forms.TextBox();
            this.GrupClassBox = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.ModificationBox = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(55, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна происхождения";
            // 
            // Сountry
            // 
            this.Сountry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Сountry.Location = new System.Drawing.Point(351, 138);
            this.Сountry.Name = "Сountry";
            this.Сountry.Size = new System.Drawing.Size(297, 31);
            this.Сountry.TabIndex = 1;
            this.Сountry.Enter += new System.EventHandler(this.Сountry_Enter);
            this.Сountry.Leave += new System.EventHandler(this.Сountry_Leave);
            // 
            // Comment
            // 
            this.Comment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Comment.Location = new System.Drawing.Point(351, 175);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(297, 31);
            this.Comment.TabIndex = 3;
            this.Comment.Enter += new System.EventHandler(this.Comment_Enter);
            this.Comment.Leave += new System.EventHandler(this.Comment_Leave);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(55, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Коментарий";
            // 
            // Label3
            // 
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Location = new System.Drawing.Point(12, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(290, 31);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Марка бренд машины";
            // 
            // MachineBrandBox
            // 
            this.MachineBrandBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MachineBrandBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MachineBrandBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MachineBrandBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MachineBrandBox.FormattingEnabled = true;
            this.MachineBrandBox.Location = new System.Drawing.Point(308, 9);
            this.MachineBrandBox.Name = "MachineBrandBox";
            this.MachineBrandBox.Size = new System.Drawing.Size(450, 31);
            this.MachineBrandBox.TabIndex = 5;
            this.MachineBrandBox.SelectedIndexChanged += new System.EventHandler(this.MachineBrandBox_SelectedIndexChanged);
            this.MachineBrandBox.Enter += new System.EventHandler(this.MachineBrandBox_Enter);
            // 
            // ADD_button1
            // 
            this.ADD_button1.BackColor = System.Drawing.Color.LightGray;
            this.ADD_button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADD_button1.Location = new System.Drawing.Point(3, 46);
            this.ADD_button1.Name = "ADD_button1";
            this.ADD_button1.Size = new System.Drawing.Size(318, 37);
            this.ADD_button1.TabIndex = 6;
            this.ADD_button1.Text = "Создать";
            this.ADD_button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ADD_button1.UseVisualStyleBackColor = false;
            this.ADD_button1.Click += new System.EventHandler(this.ADD_button1_Click);
            // 
            // Edit_button2
            // 
            this.Edit_button2.BackColor = System.Drawing.Color.LightGray;
            this.Edit_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit_button2.Location = new System.Drawing.Point(3, 89);
            this.Edit_button2.Name = "Edit_button2";
            this.Edit_button2.Size = new System.Drawing.Size(318, 37);
            this.Edit_button2.TabIndex = 7;
            this.Edit_button2.Text = "Изменить";
            this.Edit_button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Edit_button2.UseVisualStyleBackColor = false;
            this.Edit_button2.Click += new System.EventHandler(this.Edit_button2_Click);
            // 
            // Del_button3
            // 
            this.Del_button3.BackColor = System.Drawing.Color.LightGray;
            this.Del_button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Del_button3.Location = new System.Drawing.Point(3, 132);
            this.Del_button3.Name = "Del_button3";
            this.Del_button3.Size = new System.Drawing.Size(318, 37);
            this.Del_button3.TabIndex = 8;
            this.Del_button3.Text = "Удалить";
            this.Del_button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Del_button3.UseVisualStyleBackColor = false;
            this.Del_button3.Click += new System.EventHandler(this.Del_button3_Click);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.LightGray;
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Status.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(351, 227);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(297, 31);
            this.Status.TabIndex = 10;
            this.Status.Enter += new System.EventHandler(this.Status_Enter);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(55, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Текущий статус";
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Price.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(351, 290);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(297, 31);
            this.Price.TabIndex = 12;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Enter += new System.EventHandler(this.Price_Enter);
            this.Price.Leave += new System.EventHandler(this.Price_Leave);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(55, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Цена закупка";
            // 
            // MarkupSng
            // 
            this.MarkupSng.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MarkupSng.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MarkupSng.ForeColor = System.Drawing.Color.Blue;
            this.MarkupSng.Location = new System.Drawing.Point(351, 327);
            this.MarkupSng.Name = "MarkupSng";
            this.MarkupSng.Size = new System.Drawing.Size(297, 31);
            this.MarkupSng.TabIndex = 14;
            this.MarkupSng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MarkupSng.Enter += new System.EventHandler(this.MarkupSng_Enter);
            this.MarkupSng.Leave += new System.EventHandler(this.MarkupSng_Leave);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(55, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Наценка %";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(55, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Продажная цена";
            // 
            // SummPrice
            // 
            this.SummPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.SummPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummPrice.Location = new System.Drawing.Point(351, 364);
            this.SummPrice.Name = "SummPrice";
            this.SummPrice.ReadOnly = true;
            this.SummPrice.Size = new System.Drawing.Size(297, 31);
            this.SummPrice.TabIndex = 16;
            this.SummPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GrupClassBox
            // 
            this.GrupClassBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GrupClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GrupClassBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrupClassBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrupClassBox.FormattingEnabled = true;
            this.GrupClassBox.Location = new System.Drawing.Point(351, 93);
            this.GrupClassBox.Name = "GrupClassBox";
            this.GrupClassBox.Size = new System.Drawing.Size(407, 31);
            this.GrupClassBox.TabIndex = 18;
            this.GrupClassBox.SelectedIndexChanged += new System.EventHandler(this.GrupClassBox_SelectedIndexChanged);
            this.GrupClassBox.Enter += new System.EventHandler(this.GrupClassBox_Enter);
            // 
            // Label8
            // 
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label8.Location = new System.Drawing.Point(55, 93);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(290, 31);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Группа автомобилей";
            // 
            // ModificationBox
            // 
            this.ModificationBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ModificationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModificationBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModificationBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModificationBox.FormattingEnabled = true;
            this.ModificationBox.Location = new System.Drawing.Point(308, 49);
            this.ModificationBox.Name = "ModificationBox";
            this.ModificationBox.Size = new System.Drawing.Size(450, 31);
            this.ModificationBox.TabIndex = 23;
            this.ModificationBox.SelectedIndexChanged += new System.EventHandler(this.ModificationBox_SelectedIndexChanged);
            this.ModificationBox.Enter += new System.EventHandler(this.ModificationBox_Enter);
            // 
            // Label9
            // 
            this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Location = new System.Drawing.Point(12, 49);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(290, 31);
            this.Label9.TabIndex = 22;
            this.Label9.Text = "Комплектация авто";
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.label11);
            this.Panel1.Controls.Add(this.Info);
            this.Panel1.Controls.Add(this.ADD_button1);
            this.Panel1.Controls.Add(this.Edit_button2);
            this.Panel1.Controls.Add(this.Del_button3);
            this.Panel1.Location = new System.Drawing.Point(844, 14);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(326, 192);
            this.Panel1.TabIndex = 24;
            this.Panel1.Visible = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(324, 10);
            this.label11.TabIndex = 9;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.Info.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Info.ForeColor = System.Drawing.Color.Black;
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(324, 29);
            this.Info.TabIndex = 0;
            this.Info.Text = "label10";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_OK
            // 
            this.Button_OK.BackColor = System.Drawing.Color.LightGray;
            this.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_OK.Location = new System.Drawing.Point(844, 362);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(318, 37);
            this.Button_OK.TabIndex = 25;
            this.Button_OK.Text = "OK";
            this.Button_OK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_OK.UseVisualStyleBackColor = false;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.LightGray;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Cancel.Location = new System.Drawing.Point(844, 405);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(318, 37);
            this.Button_Cancel.TabIndex = 26;
            this.Button_Cancel.Text = "Отмена";
            this.Button_Cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // ID
            // 
            this.ID.AccessibleName = "";
            this.ID.BackColor = System.Drawing.Color.Gainsboro;
            this.ID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(351, 423);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(297, 31);
            this.ID.TabIndex = 28;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(55, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(290, 31);
            this.label12.TabIndex = 27;
            this.label12.Text = "ID карточки";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1184, 494);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ModificationBox);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.GrupClassBox);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.SummPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MarkupSng);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MachineBrandBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Сountry);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Автомобиль";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Сountry;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button ADD_button1;
        private System.Windows.Forms.Button Edit_button2;
        private System.Windows.Forms.Button Del_button3;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MarkupSng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SummPrice;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox MachineBrandBox;
        public System.Windows.Forms.ComboBox GrupClassBox;
        public System.Windows.Forms.ComboBox ModificationBox;
    }
}