
namespace ExConPram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridViewMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBox1 = new System.Windows.Forms.CheckBox();
            this.ADD_button1 = new System.Windows.Forms.Button();
            this.Edit_button2 = new System.Windows.Forms.Button();
            this.Del_button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewMain
            // 
            this.DataGridViewMain.AllowUserToAddRows = false;
            this.DataGridViewMain.AllowUserToDeleteRows = false;
            this.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MachineBrand,
            this.Modification,
            this.Status,
            this.Сountry,
            this.Price,
            this.Grup});
            this.DataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewMain.Location = new System.Drawing.Point(0, 91);
            this.DataGridViewMain.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewMain.MultiSelect = false;
            this.DataGridViewMain.Name = "DataGridViewMain";
            this.DataGridViewMain.ReadOnly = true;
            this.DataGridViewMain.RowHeadersWidth = 51;
            this.DataGridViewMain.RowTemplate.Height = 29;
            this.DataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewMain.Size = new System.Drawing.Size(1350, 571);
            this.DataGridViewMain.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // MachineBrand
            // 
            this.MachineBrand.HeaderText = "Марка машины";
            this.MachineBrand.MinimumWidth = 6;
            this.MachineBrand.Name = "MachineBrand";
            this.MachineBrand.ReadOnly = true;
            this.MachineBrand.Width = 300;
            // 
            // Modification
            // 
            this.Modification.HeaderText = "Модификация";
            this.Modification.MinimumWidth = 6;
            this.Modification.Name = "Modification";
            this.Modification.ReadOnly = true;
            this.Modification.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 200;
            // 
            // Сountry
            // 
            this.Сountry.HeaderText = "Страна";
            this.Сountry.MinimumWidth = 6;
            this.Сountry.Name = "Сountry";
            this.Сountry.ReadOnly = true;
            this.Сountry.Width = 200;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена с наценкой";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Grup
            // 
            this.Grup.HeaderText = "Группа";
            this.Grup.MinimumWidth = 6;
            this.Grup.Name = "Grup";
            this.Grup.ReadOnly = true;
            this.Grup.Width = 250;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBox1);
            this.panel1.Controls.Add(this.ADD_button1);
            this.panel1.Controls.Add(this.Edit_button2);
            this.panel1.Controls.Add(this.Del_button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 91);
            this.panel1.TabIndex = 1;
            // 
            // CBox1
            // 
            this.CBox1.AutoSize = true;
            this.CBox1.Location = new System.Drawing.Point(13, 55);
            this.CBox1.Name = "CBox1";
            this.CBox1.Size = new System.Drawing.Size(380, 32);
            this.CBox1.TabIndex = 15;
            this.CBox1.Text = "показать только машины на продажу";
            this.CBox1.UseVisualStyleBackColor = true;
            this.CBox1.CheckedChanged += new System.EventHandler(this.CBox1_CheckedChanged);
            // 
            // ADD_button1
            // 
            this.ADD_button1.BackColor = System.Drawing.Color.LightGray;
            this.ADD_button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADD_button1.Location = new System.Drawing.Point(73, 9);
            this.ADD_button1.Margin = new System.Windows.Forms.Padding(4);
            this.ADD_button1.Name = "ADD_button1";
            this.ADD_button1.Size = new System.Drawing.Size(313, 37);
            this.ADD_button1.TabIndex = 12;
            this.ADD_button1.Text = "Создать";
            this.ADD_button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ADD_button1.UseVisualStyleBackColor = false;
            this.ADD_button1.Click += new System.EventHandler(this.ADD_button1_Click);
            // 
            // Edit_button2
            // 
            this.Edit_button2.BackColor = System.Drawing.Color.LightGray;
            this.Edit_button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit_button2.Location = new System.Drawing.Point(519, 9);
            this.Edit_button2.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_button2.Name = "Edit_button2";
            this.Edit_button2.Size = new System.Drawing.Size(313, 37);
            this.Edit_button2.TabIndex = 13;
            this.Edit_button2.Text = "Изменить";
            this.Edit_button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Edit_button2.UseVisualStyleBackColor = false;
            this.Edit_button2.Click += new System.EventHandler(this.Edit_button2_Click);
            // 
            // Del_button3
            // 
            this.Del_button3.BackColor = System.Drawing.Color.LightGray;
            this.Del_button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Del_button3.Location = new System.Drawing.Point(965, 9);
            this.Del_button3.Margin = new System.Windows.Forms.Padding(4);
            this.Del_button3.Name = "Del_button3";
            this.Del_button3.Size = new System.Drawing.Size(313, 37);
            this.Del_button3.TabIndex = 14;
            this.Del_button3.Text = "Удалить";
            this.Del_button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Del_button3.UseVisualStyleBackColor = false;
            this.Del_button3.Click += new System.EventHandler(this.Del_button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 662);
            this.Controls.Add(this.DataGridViewMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Основная форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ADD_button1;
        private System.Windows.Forms.Button Edit_button2;
        private System.Windows.Forms.Button Del_button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Сountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grup;
        private System.Windows.Forms.CheckBox CBox1;
    }
}

